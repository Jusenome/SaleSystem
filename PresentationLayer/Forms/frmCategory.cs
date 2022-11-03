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

namespace PresentationLayer.Forms
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

            cmbState.Items.Add(new Option_ComboBox() { value = 1, text = "ACTIVO" });
            cmbState.Items.Add(new Option_ComboBox() { value = 0, text = "INACTIVO" });
            cmbState.DisplayMember = "text";
            cmbState.ValueMember = "value";
            cmbState.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                if (column.Visible == true && !(column.Name == "edit"))
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
            Category category = new Category()
            {
                Description = txtDescription.Text,
                State = (int)((Option_ComboBox)cmbState.SelectedItem).value == 1 ? true : false
            };

            string result = new BL_Category().CreateCategory(category);
            MessageBox.Show(result);

            Clean();
            frmCategory_Load(sender, e);
        }

        private void ibtnEdit_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                Id = Convert.ToInt32(txtId.Text),
                Description = txtDescription.Text,
                State = (int)((Option_ComboBox)cmbState.SelectedItem).value == 1 ? true : false
            };

            string result = new BL_Category().UpdateCategory(Convert.ToInt32(txtId.Text), category);
            MessageBox.Show(result);

            Clean();
            frmCategory_Load(sender, e);
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            Clean();
            frmCategory_Load(sender, e);
        }

        private void Clean()
        {
            txtId.Text = "0";
            txtDescription.Text = "";
            cmbState.SelectedIndex = 0;

            ibtnSave.Visible = true;
            ibtnSave.Location = new System.Drawing.Point(34, 262);
            ibtnEdit.Visible = false;
            ibtnEdit.Location = new System.Drawing.Point(34, 233);

            dgvList.Rows.Clear();
            cmbState.Items.Clear();
            cmbSearchBy.Items.Clear();

            txtDescription.Select();

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
            if (dgvList.Columns[e.ColumnIndex].Name == "edit")
            {
                if (e.RowIndex >= 0)
                {
                    txtId.Text = dgvList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    txtDescription.Text = dgvList.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                    foreach (Option_ComboBox ocb in cmbState.Items)
                    {
                        if (Convert.ToInt32(ocb.value) == Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["valueState"].Value))
                        {
                            cmbState.SelectedIndex = cmbState.Items.IndexOf(ocb);
                            break;
                        }
                    }

                    ibtnSave.Visible = false;
                    ibtnSave.Location = new System.Drawing.Point(34, 233);
                    ibtnEdit.Visible = true;
                    ibtnEdit.Location = new System.Drawing.Point(34, 262);

                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBy(((Option_ComboBox)cmbSearchBy.SelectedItem).text, txtSearch.Text);
        }

        private void SearchBy(string by, string searchString)
        {
            IQueryable<Category> categories = new BL_Category().GetCategoryList();

            if (!searchString.Trim().Equals(""))
            {
                if (by == "Descripción")
                {
                    dgvList.Rows.Clear();
                    categories = categories.Where(o => o.Description.Contains(searchString));
                }
                else if (by == "Estado")
                {
                    dgvList.Rows.Clear();
                    bool state = false;
                    foreach (Option_ComboBox ocb in cmbState.Items)
                    {
                        if (ocb.text.Contains(searchString.ToUpper()))
                        {
                            cmbState.SelectedIndex = cmbState.Items.IndexOf(ocb);
                            state = (int)((Option_ComboBox)cmbState.SelectedItem).value == 1 ? true : false;
                            break;
                        }
                    }
                    categories = categories.Where(o => o.State == state);
                }
            }
            else
            {
                dgvList.Rows.Clear();
            }


            foreach (Category category in categories)
            {
                dgvList.Rows.Add(new object[] { category.Id, category.Description,
                    category.State == true ? 1 : 0, category.State == true ? "ACTIVO" : "INACTIVO", "" });
            }
        }
    }
}
