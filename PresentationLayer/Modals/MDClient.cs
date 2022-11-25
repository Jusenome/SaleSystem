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
    public partial class MDClient : Form
    {
        public Client client { get; set; }

        public MDClient()
        {
            InitializeComponent();
        }

        private void MDClient_Load(object sender, EventArgs e)
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
            IQueryable<Client> clients = new BL_Client().GetClients();

            if (!searchString.Trim().Equals(""))
            {
                if (by == "Nro Documento")
                {
                    dgvList.Rows.Clear();
                    clients = clients.Where(o => o.Document.Contains(searchString));
                }
                else if (by == "Nombre")
                {
                    dgvList.Rows.Clear();
                    clients = clients.Where(o => o.FullName.Contains(searchString));
                }
            }
            else
            {
                dgvList.Rows.Clear();
            }


            foreach (Client client in clients)
            {
                if((bool)client.State)
                    dgvList.Rows.Add(new object[] { client.Id, client.Document, client.FullName });
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            if (row >= 0 && column > 0)
            {
                client = new Client()
                {
                    Id = Convert.ToInt32(dgvList.Rows[row].Cells["Id"].Value),
                    Document = dgvList.Rows[row].Cells["Document"].Value.ToString(),
                    FullName = dgvList.Rows[row].Cells["CName"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
