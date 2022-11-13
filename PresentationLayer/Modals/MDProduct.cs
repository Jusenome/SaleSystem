using BusinessLayer;
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

namespace PresentationLayer.Modals
{
    public partial class MDProduct : Form
    {
        public Product product { get; set; }

        public MDProduct()
        {
            InitializeComponent();
        }

        private void MDProduct_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                if (column.Visible == true)
                {
                    cmbSearchBy.Items.Add(new Option_ComboBox() { value = column.Name, text = column.HeaderText });
                }
            }
            cmbSearchBy.DisplayMember = "text";
            cmbSearchBy.ValueMember = "value";
            cmbSearchBy.SelectedIndex = 0;

            SearchBy("", "");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBy(((Option_ComboBox)cmbSearchBy.SelectedItem).text, txtSearch.Text);
        }

        private void SearchBy(string by, string searchString)
        {
            DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();
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
                else if(by == "Categoria"){

                }
            }
            else
            {
                dgvList.Rows.Clear();
            }


            foreach (Product product in products)
            {
                var categoryName = db.Categories.Where(o => o.Id == product.IdCategory).FirstOrDefault().Description;
                dgvList.Rows.Add(new object[] { product.Id, product.Code, product.Name, categoryName, product.Stock, product.PurchasePrice, product.SalePrice });
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            if (row >= 0 && column > 0)
            {
                product = new Product()
                {
                    Id = Convert.ToInt32(dgvList.Rows[row].Cells["Id"].Value),
                    Code = dgvList.Rows[row].Cells["Code"].Value.ToString(),
                    Name = dgvList.Rows[row].Cells["PName"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvList.Rows[row].Cells["Stock"].Value),
                    PurchasePrice = Convert.ToDecimal(dgvList.Rows[row].Cells["PurchasePrice"].Value),
                    SalePrice = Convert.ToDecimal(dgvList.Rows[row].Cells["SalePrice"].Value)
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
