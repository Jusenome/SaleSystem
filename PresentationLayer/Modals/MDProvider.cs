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
    public partial class MDProvider : Form
    {
        public Provider provider { get; set; }

        public MDProvider()
        {
            InitializeComponent();
        }

        private void MDProvider_Load(object sender, EventArgs e)
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
            IQueryable<Provider> providers = new BL_Provider().GetProviders();

            if (!searchString.Trim().Equals(""))
            {
                if (by == "Nro Documento")
                {
                    dgvList.Rows.Clear();
                    providers = providers.Where(o => o.Document.Contains(searchString));
                }
                else if (by == "Nombre")
                {
                    dgvList.Rows.Clear();
                    providers = providers.Where(o => o.BusinessName.Contains(searchString));
                }
            }
            else
            {
                dgvList.Rows.Clear();
            }


            foreach (Provider provider in providers)
            {
                dgvList.Rows.Add(new object[] { provider.Id, provider.Document, provider.BusinessName});
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            if(row >= 0 && column > 0)
            {
                provider = new Provider()
                {
                    Id = Convert.ToInt32(dgvList.Rows[row].Cells["Id"].Value),
                    Document = dgvList.Rows[row].Cells["Document"].Value.ToString(),
                    BusinessName = dgvList.Rows[row].Cells["PName"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
