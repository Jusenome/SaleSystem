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
    public partial class frmSale : Form
    {
        private AppUser oUsuario;

        public frmSale(AppUser usuario)
        {
            oUsuario = usuario;
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            cmbDocumentType.Items.Add(new Option_ComboBox() { value = "Factura", text = "Factura" });
            cmbDocumentType.DisplayMember = "text";
            cmbDocumentType.ValueMember = "value";
            cmbDocumentType.SelectedIndex = 0;

            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        private void ibtnSearchClient_Click(object sender, EventArgs e)
        {
            using (var modal = new MDClient())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtClientId.Text = modal.client.Id.ToString();
                    txtClientDocument.Text = modal.client.Document;
                    txtClientName.Text = modal.client.FullName;
                    txtProductCode.Select();
                }
                else
                {
                    txtClientDocument.Select();
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
                    txtSalePrice.Text = Convert.ToDecimal(modal.product.SalePrice).ToString("0.00");
                    txtStock.Text = modal.product.Stock.ToString();
                    nudAmount.Select();
                }
                else
                {
                    txtProductCode.Select();
                }
            };
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Product product = new BL_Product().GetProducts().Where(o => o.Code == txtProductCode.Text).FirstOrDefault();

                if (product != null)
                {
                    txtProductCode.BackColor = Color.Honeydew;
                    txtProductId.Text = product.Id.ToString();
                    txtProductName.Text = product.Name;
                    txtSalePrice.Text = Convert.ToDecimal(product.SalePrice).ToString("0.00");
                    txtStock.Text = product.Stock.ToString();
                    nudAmount.Select();
                    lblMessage.Visible = false;
                }
                else
                {
                    txtProductCode.BackColor = Color.MistyRose;
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                    txtSalePrice.Text = "";
                    txtStock.Text = "";
                    lblMessage.Text = "No existe producto con el codigo ingresado";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                }
            }
        }

        private void ibtnAdd_Click(object sender, EventArgs e)
        {
            decimal salePrice = 0;
            bool productExists = false;

            if (int.Parse(txtProductId.Text) < 0 || txtProductId.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtSalePrice.Text, out salePrice))
            {
                MessageBox.Show("Precio venta - formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalePrice.Select();
                return;
            }

            if(Convert.ToInt32(txtStock.Text) < Convert.ToInt32(nudAmount.Value))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalePrice.Select();
                return;
            }

            foreach (DataGridViewRow row in dgvSaleList.Rows)
            {
                if (row.Cells["IdProduct"].Value.ToString() == txtProductId.Text)
                {
                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                dgvSaleList.Rows.Add(new object[] {
                    txtProductId.Text,
                    txtProductName.Text,
                    salePrice.ToString("0.00"),
                    nudAmount.Value.ToString(),
                    (nudAmount.Value * salePrice).ToString("0.00")
                });

                BL_Product blProduct = new BL_Product();
                int idProduct = Convert.ToInt32(txtProductId.Text);
                Product product = blProduct.GetProductById(idProduct);
                Product updateProduct = new Product()
                {
                    Id = product.Id,
                    Code = product.Code,
                    Name = product.Name,
                    Description = product.Description,
                    IdCategory = product.IdCategory,
                    Stock = product.Stock - Convert.ToInt32(nudAmount.Value.ToString()),
                    PurchasePrice = product.PurchasePrice,
                    SalePrice = product.SalePrice,
                    State = product.State
                };
                string resultProduct = blProduct.UpdateProduct(idProduct, updateProduct);


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
            txtSalePrice.Text = "";
            txtStock.Text = "";
            nudAmount.Value = 1;
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            if (dgvSaleList.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSaleList.Rows)
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

        private void dgvSaleList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int totalColumn = dgvSaleList.ColumnCount;
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

        private void dgvSaleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSaleList.Columns[e.ColumnIndex].Name == "Delete")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    BL_Product blProduct = new BL_Product();
                    DataGridViewRow row = dgvSaleList.Rows[e.RowIndex];
                    int idProduct = Convert.ToInt32(row.Cells["IdProduct"].Value);
                    Product product = blProduct.GetProductById(idProduct);
                    Product updateProduct = new Product()
                    {
                        Id = product.Id,
                        Code = product.Code,
                        Name = product.Name,
                        Description = product.Description,
                        IdCategory = product.IdCategory,
                        Stock = product.Stock + Convert.ToInt32(row.Cells["Amount"].Value),
                        PurchasePrice = product.PurchasePrice,
                        SalePrice = product.SalePrice,
                        State = product.State
                    };
                    string resultProduct = blProduct.UpdateProduct(idProduct, updateProduct);

                    dgvSaleList.Rows.RemoveAt(index);
                    CalculateTotal();
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

        private void txtPayWith_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CalculateChange()
        {
            if(txtTotalPay.Text == "" || txtTotalPay.Text == "0")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal payWith;
            decimal total = Convert.ToDecimal(txtTotalPay.Text);

            if (txtPayWith.Text.Trim() == "")
                txtPayWith.Text = "0";

            if(decimal.TryParse(txtPayWith.Text.Trim(), out payWith)){
                if(payWith < total)
                {
                    MessageBox.Show("El valor con el que esta pagando es menor al valor a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if(payWith == 0)
                {
                    txtChange.Text = "0.00";
                }
                else
                {
                    txtChange.Text = (payWith - total).ToString("0.00");
                }
            }
        }

        private void txtPayWith_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                CalculateChange();
        }

        private void ibtnRegister_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtClientId.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvSaleList.Rows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar productos para la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                BL_Sale blSale = new BL_Sale();
                BL_SaleDetail blSaleDetail = new BL_SaleDetail();
                BL_Product blProduct = new BL_Product();
                DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

                int iNumber = db.Sales.ToList().Count() + 1; // Cambiar posteriosmente para que la consulta se haga en DL_Sale
                string invoiceNumber = string.Format("{0:00000}", iNumber);
                Sale sale = new Sale()
                {
                    IdUser = oUsuario.Id,
                    DocumentType = ((Option_ComboBox)cmbDocumentType.SelectedItem).text,
                    InvoiceNumber = invoiceNumber,
                    ClientDocument = txtClientDocument.Text,
                    ClientName = txtClientName.Text,
                    Payment = Convert.ToDecimal(txtPayWith.Text),
                    Change = Convert.ToDecimal(txtChange.Text),
                    Total = Convert.ToDecimal(txtTotalPay.Text)
                };
                string resultSale = blSale.CreateSale(sale);

                int idSale = db.Sales.Where(o => o.InvoiceNumber == invoiceNumber).FirstOrDefault().Id; // Cambiar posteriosmente para que la consulta se haga en DL_Sale
                foreach (DataGridViewRow row in dgvSaleList.Rows)
                {
                    SaleDetail saleDetail = new SaleDetail()
                    {
                        IdSale = idSale,
                        IdProduct = Convert.ToInt32(row.Cells["IdProduct"].Value),
                        SalePrice = Convert.ToDecimal(row.Cells["SalePrice"].Value),
                        Quantity = Convert.ToInt32(row.Cells["Amount"].Value),
                        Subtotal = Convert.ToDecimal(row.Cells["SubTotal"].Value)
                    };
                    string resultSaleDetail = blSaleDetail.CreateSaleDetail(saleDetail);
                }

                MessageBox.Show("Comprada realizada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CleanAfterRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanAfterRegister()
        {
            txtClientId.Text = "0";
            txtClientDocument.Text = "";
            txtClientName.Text = "";
            dgvSaleList.Rows.Clear();
            CalculateTotal();
            txtProductCode.Select();
        }
    }
}
