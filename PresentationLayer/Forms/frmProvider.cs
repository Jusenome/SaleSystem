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
    public partial class frmProvider : Form
    {
        public frmProvider()
        {
            InitializeComponent();
        }

        private void frmProvider_Load(object sender, EventArgs e)
        {
            cmbState.Items.Add(new Option_ComboBox() { value = 1, text = "ACTIVO" });
            cmbState.Items.Add(new Option_ComboBox() { value = 0, text = "INACTIVO" });
            cmbState.DisplayMember = "text";
            cmbState.ValueMember = "value";
            cmbState.SelectedIndex = 0;

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
            BL_Provider blProvider = new BL_Provider();

            Provider provider = new Provider()
            {
                Document = txtDocument.Text,
                BusinessName = txtName.Text,
                Mail = txtMail.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                State = (int)((Option_ComboBox)cmbState.SelectedItem).value == 1 ? true : false
            };

            string result = blProvider.CreateProvider(provider);
            MessageBox.Show(result);

            Clean();
            frmProvider_Load(sender, e);
        }

        private void ibtnEdit_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider()
            {
                Id = Convert.ToInt32(txtId.Text),
                Document = txtDocument.Text,
                BusinessName = txtName.Text,
                Mail = txtMail.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                State = (int)((Option_ComboBox)cmbState.SelectedItem).value == 1 ? true : false
            };

            string result = new BL_Provider().UpdateProvider(Convert.ToInt32(txtId.Text), provider);
            MessageBox.Show(result);

            Clean();
            frmProvider_Load(sender, e);
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            Clean();
            frmProvider_Load(sender, e);
        }

        private void Clean()
        {
            txtId.Text = "0";
            txtDocument.Text = "";
            txtName.Text = "";
            txtMail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            cmbState.SelectedIndex = 0;

            ibtnSave.Visible = true;
            ibtnSave.Location = new System.Drawing.Point(34, 414);
            ibtnEdit.Visible = false;
            ibtnEdit.Location = new System.Drawing.Point(34, 385);

            dgvList.Rows.Clear();
            cmbState.Items.Clear();
            cmbSearchBy.Items.Clear();

            txtDocument.Select();

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
                    txtDocument.Text = dgvList.Rows[e.RowIndex].Cells["Document"].Value.ToString();
                    txtName.Text = dgvList.Rows[e.RowIndex].Cells["PName"].Value.ToString();
                    txtMail.Text = dgvList.Rows[e.RowIndex].Cells["Mail"].Value.ToString();
                    txtAddress.Text = dgvList.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                    txtPhone.Text = dgvList.Rows[e.RowIndex].Cells["Phone"].Value.ToString();

                    foreach (Option_ComboBox ocb in cmbState.Items)
                    {
                        if (Convert.ToInt32(ocb.value) == Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["valueState"].Value))
                        {
                            cmbState.SelectedIndex = cmbState.Items.IndexOf(ocb);
                            break;
                        }
                    }

                    ibtnSave.Visible = false;
                    ibtnSave.Location = new System.Drawing.Point(34, 385);
                    ibtnEdit.Visible = true;
                    ibtnEdit.Location = new System.Drawing.Point(34, 414);

                }
            }
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
                else if (by == "Correo")
                {
                    dgvList.Rows.Clear();
                    providers = providers.Where(o => o.Mail.Contains(searchString));
                }
                else if (by == "Direccion")
                {
                    dgvList.Rows.Clear();
                    providers = providers.Where(o => o.Address.Contains(searchString));
                }
                else if (by == "Telefono")
                {
                    dgvList.Rows.Clear();
                    providers = providers.Where(o => o.Phone.Contains(searchString));
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
                            cmbState.SelectedIndex = 0;
                            break;
                        }
                    }
                    providers = providers.Where(o => o.State == state);
                }
            }
            else
            {
                dgvList.Rows.Clear();
            }


            foreach (Provider provider in providers)
            {
                dgvList.Rows.Add(new object[] { provider.Id, provider.Document, provider.BusinessName, provider.Mail, provider.Address, provider.Phone,
                    provider.State == true ? 1 : 0, provider.State == true ? "ACTIVO" : "INACTIVO", "" });
            }
        }

        private void ibtnExport_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn column in dgvList.Columns)
                {
                    if (column.Name != "Edit" && column.Visible)
                    {
                        dt.Columns.Add(column.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                        });
                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("Reporte Producto {0}.xlsx", DateTime.Now.ToString("yyyy-MM-dd HHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
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
