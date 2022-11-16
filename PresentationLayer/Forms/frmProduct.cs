using BusinessLayer;
using ClosedXML.Excel;
using EntityLayer;
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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            IQueryable<Category> oCategories = new BL_Category().GetCategoryList();

            foreach (Category category in oCategories)
            {
                cmbCategory.Items.Add(new Option_ComboBox() { value = category.Id, text = category.Description });
            }
            cmbCategory.DisplayMember = "text";
            cmbCategory.ValueMember = "value";
            cmbCategory.SelectedIndex = 0;

            cmbUserState.Items.Add(new Option_ComboBox() { value = 1, text = "ACTIVO" });
            cmbUserState.Items.Add(new Option_ComboBox() { value = 0, text = "INACTIVO" });
            cmbUserState.DisplayMember = "text";
            cmbUserState.ValueMember = "value";
            cmbUserState.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                if (column.Visible == true && !(column.Name == "Edit"))
                {
                    cmbSearchBy.Items.Add(new Option_ComboBox() { value = column.Name, text = column.HeaderText });
                }
            }
            cmbSearchBy.DisplayMember = "text";
            cmbSearchBy.ValueMember = "value";
            cmbSearchBy.SelectedIndex = 0;

            SearchBy("", "");
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            BL_Product blProduct = new BL_Product();

            Product product = new Product()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Description = txtDescription.Text,
                IdCategory = (int)((Option_ComboBox)cmbCategory.SelectedItem).value,
                State = (int)((Option_ComboBox)cmbUserState.SelectedItem).value == 1 ? true : false
            };

            string result = blProduct.CreateProduct(product);
            MessageBox.Show(result);

            Clean();
            frmProduct_Load(sender, e);
        }

        private void ibtnEdit_Click(object sender, EventArgs e)
        {
            BL_Product blProduct = new BL_Product();
            Product searchProduct = blProduct.GetProductById(Convert.ToInt32(txtId.Text));

            Product product = new Product()
            {
                Id = Convert.ToInt32(txtId.Text),
                Code = txtCode.Text,
                Name = txtName.Text,
                Description = txtDescription.Text,
                IdCategory = (int)((Option_ComboBox)cmbCategory.SelectedItem).value,
                Stock = searchProduct.Stock,
                PurchasePrice = searchProduct.PurchasePrice,
                SalePrice = searchProduct.SalePrice,
                State = (int)((Option_ComboBox)cmbUserState.SelectedItem).value == 1 ? true : false
            };

            string result = new BL_Product().UpdateProduct(Convert.ToInt32(txtId.Text), product);
            MessageBox.Show(result);

            Clean();
            frmProduct_Load(sender, e);
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            Clean();
            frmProduct_Load(sender, e);
        }

        private void Clean()
        {
            txtId.Text = "0";
            txtCode.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            cmbCategory.SelectedIndex = 0;
            cmbUserState.SelectedIndex = 0;

            ibtnSave.Visible = true;
            ibtnSave.Location = new System.Drawing.Point(34, 370);
            ibtnEdit.Visible = false;
            ibtnEdit.Location = new System.Drawing.Point(34, 341);

            dgvList.Rows.Clear();
            cmbCategory.Items.Clear();
            cmbUserState.Items.Clear();
            cmbSearchBy.Items.Clear();

            txtCode.Select();

        }

        private void dgvList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int totalColumn = dgvList.ColumnCount;
            if (e.ColumnIndex == totalColumn - 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var imageWidth = Properties.Resources.lapiz.Width;
                var imageHeight = Properties.Resources.lapiz.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - imageWidth) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - imageHeight) / 2;

                e.Graphics.DrawImage(Properties.Resources.lapiz, new Rectangle(x, y, imageWidth, imageHeight));
                e.Handled = true;
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (e.RowIndex >= 0)
                {
                    txtId.Text = dgvList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    txtCode.Text = dgvList.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                    txtName.Text = dgvList.Rows[e.RowIndex].Cells["PName"].Value.ToString();
                    txtDescription.Text = dgvList.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                    foreach (Option_ComboBox ocb in cmbCategory.Items)
                    {
                        if (Convert.ToInt32(ocb.value) == Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["idCategory"].Value))
                        {
                            cmbCategory.SelectedIndex = cmbCategory.Items.IndexOf(ocb);
                            break;
                        }
                    }

                    foreach (Option_ComboBox ocb in cmbUserState.Items)
                    {
                        if (Convert.ToInt32(ocb.value) == Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["valueState"].Value))
                        {
                            cmbUserState.SelectedIndex = cmbUserState.Items.IndexOf(ocb);
                            break;
                        }
                    }

                    ibtnSave.Visible = false;
                    ibtnSave.Location = new System.Drawing.Point(34, 341);
                    ibtnEdit.Visible = true;
                    ibtnEdit.Location = new System.Drawing.Point(34, 370);

                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBy(((Option_ComboBox)cmbSearchBy.SelectedItem).text, txtSearch.Text);
        }

        private void SearchBy(string by, string searchString)
        {
            IQueryable<Product> products = new BL_Product().GetProducts();

            if (!searchString.Trim().Equals(""))
            {
                if (by == "Codigo")
                {
                    dgvList.Rows.Clear();
                    products = products.Where(o => o.Code.Contains(searchString));
                }
                else if (by == "Nombre")
                {
                    dgvList.Rows.Clear();
                    products = products.Where(o => o.Name.Contains(searchString));
                }
                else if (by == "Descripcion")
                {
                    dgvList.Rows.Clear();
                    products = products.Where(o => o.Description.Contains(searchString));
                }
                else if (by == "Categoria")
                {
                    dgvList.Rows.Clear();
                    int idCategory = 0;
                    foreach (Option_ComboBox ocb in cmbCategory.Items)
                    {
                        if (ocb.text.Contains(searchString.ToUpper()))
                        {
                            cmbCategory.SelectedIndex = cmbCategory.Items.IndexOf(ocb);
                            idCategory = (int)((Option_ComboBox)cmbCategory.SelectedItem).value;
                            cmbCategory.SelectedIndex = 0;
                            break;
                        }
                    }
                    products = products.Where(o => o.IdCategory == idCategory);
                }
                else if (by == "Estado")
                {
                    dgvList.Rows.Clear();
                    bool state = false;
                    foreach (Option_ComboBox ocb in cmbUserState.Items)
                    {
                        if (ocb.text.Contains(searchString.ToUpper()))
                        {
                            cmbUserState.SelectedIndex = cmbUserState.Items.IndexOf(ocb);
                            state = (int)((Option_ComboBox)cmbUserState.SelectedItem).value == 1 ? true : false;
                            cmbUserState.SelectedIndex = 0;
                            break;
                        }
                    }
                    products = products.Where(o => o.State == state);
                }
            }
            else
            {
                dgvList.Rows.Clear();
            }


            foreach (Product product in products)
            {
                string categoryDescription = new BL_Category().GetCategoryById((int)product.IdCategory).Description;

                dgvList.Rows.Add(new object[] { product.Id, product.Code, product.Name, product.Description, product.IdCategory, 
                    categoryDescription, product.Stock, product.PurchasePrice, product.SalePrice,
                    product.State == true ? 1 : 0, product.State == true ? "ACTIVO" : "INACTIVO", "" });
            }
        }

        private void ibtnExport_Click(object sender, EventArgs e)
        {
            if(dgvList.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach(DataGridViewColumn column in dgvList.Columns)
                {
                    if(column.Name != "Edit" && column.Visible)
                    {
                        dt.Columns.Add(column.HeaderText, typeof(string));
                    }
                }

                foreach(DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[10].Value.ToString()
                        });
                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("Reporte Producto {0}.xlsx", DateTime.Now.ToString("yyyy-MM-dd HHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch
                    {
                        MessageBox.Show("Error al general reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}