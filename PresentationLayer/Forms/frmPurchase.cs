using BusinessLayer;
using EntityLayer;
using PresentationLayer.Modals;
using PresentationLayer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class frmPurchase : Form
    {
        AppUser oUsuario;

        public frmPurchase(AppUser usuario)
        {
            oUsuario = usuario;
            InitializeComponent();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            cmbDocumentType.Items.Add(new Option_ComboBox() { value = "Factura", text = "Factura" });
            cmbDocumentType.DisplayMember = "text";
            cmbDocumentType.ValueMember = "value";
            cmbDocumentType.SelectedIndex = 0;

            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        private void ibtnSearchProvider_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProvider())
            {
                var result = modal.ShowDialog();

                if(result == DialogResult.OK)
                {
                    txtProviderId.Text = modal.provider.Id.ToString();
                    txtProviderNit.Text = modal.provider.Document;
                    txtProviderName.Text = modal.provider.BusinessName;
                }
                else
                {
                    txtProviderNit.Select();
                }
            };
        }

        private void ibtnSearchProduct_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProduct())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtProductId.Text = modal.product.Id.ToString();
                    txtProductCode.Text = modal.product.Code;
                    txtProductName.Text = modal.product.Name;
                    txtPurchasePrice.Select();
                }
                else
                {
                    txtProductCode.Select();
                }
            };
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Product product = new BL_Product().GetProducts().Where(o => o.Code == txtProductCode.Text).FirstOrDefault();

                if(product != null)
                {
                    txtProductCode.BackColor = Color.Honeydew;
                    txtProductId.Text = product.Id.ToString();
                    txtProductName.Text = product.Name;
                    txtPurchasePrice.Select();
                    lblMessage.Visible = false;
                }
                else
                {
                    txtProductCode.BackColor = Color.MistyRose;
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                    lblMessage.Text = "No existe producto con el codigo ingresado";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                }
            }
        }

        private void ibtnAdd_Click(object sender, EventArgs e)
        {
            decimal purchasePrice = 0;
            decimal salePrice = 0;
            bool productExists = false;

            if(int.Parse(txtProductId.Text) < 0 || txtProductId.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(!decimal.TryParse(txtPurchasePrice.Text, out purchasePrice))
            {
                MessageBox.Show("Precio compra - formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPurchasePrice.Select();
                return;
            }

            if (!decimal.TryParse(txtSalePrice.Text, out salePrice))
            {
                MessageBox.Show("Precio venta - formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalePrice.Select();
                return;
            }

            foreach(DataGridViewRow row in dgvPurchaseList.Rows)
            {
                if(row.Cells["Id"].Value.ToString() == txtProductId.Text)
                {
                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                dgvPurchaseList.Rows.Add(new object[] { 
                    txtProductId.Text,
                    txtProductName.Text,
                    purchasePrice.ToString("0.00"),
                    salePrice.ToString("0.00"),
                    nudAmount.Value.ToString(),
                    (nudAmount.Value * purchasePrice).ToString("0.00")
                });

                CalculateTotal();
                CleanProductData();
                txtProductCode.Select();
            }
        }

        private void CleanProductData()
        {
            txtProductId.Text = "0";
            txtProductCode.Text = "";
            txtProductCode.BackColor = Color.White;
            txtProductName.Text = "";
            txtPurchasePrice.Text = "";
            txtSalePrice.Text = "";
            nudAmount.Value = 1;
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            if(dgvPurchaseList.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvPurchaseList.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }

                txtTotalPay.Text = total.ToString("0.00");
            }
            else
            {
                txtTotalPay.Text = "";
            }
        }

        private void dgvPurchaseList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int totalColumn = dgvPurchaseList.ColumnCount;
            if (e.ColumnIndex == totalColumn - 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var imageWidth = Properties.Resources.delete.Width;
                var imageHeight = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - imageWidth) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - imageHeight) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, imageWidth, imageHeight));
                e.Handled = true;
            }
        }

        private void dgvPurchaseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPurchaseList.Columns[e.ColumnIndex].Name == "Delete")
            {
                int index = e.RowIndex;

                if(index >= 0)
                {
                    dgvPurchaseList.Rows.RemoveAt(index);
                    CalculateTotal();
                }
            }
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                lblMessage.Visible = false;
            }
            else
            {
                if(txtPurchasePrice.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                    lblMessage.Text = "Esta intentando ingresar un valor no valido";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                }
                else
                {
                    if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                        lblMessage.Visible = false;
                    }
                    else
                    {
                        e.Handled = true;
                        lblMessage.Text = "Esta intentando ingresar un valor no valido";
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Visible = true;
                    }
                }
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                lblMessage.Visible = false;
            }
            else
            {
                if (txtSalePrice.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                    lblMessage.Text = "Esta intentando ingresar un valor no valido";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                        lblMessage.Visible = false;
                    }
                    else
                    {
                        e.Handled = true;
                        lblMessage.Text = "Esta intentando ingresar un valor no valido";
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Visible = true;
                    }
                }
            }
        }
    }
}
