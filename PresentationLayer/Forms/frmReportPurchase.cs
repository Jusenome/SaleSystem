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
    public partial class frmReportPurchase : Form
    {
        public frmReportPurchase()
        {
            InitializeComponent();
        }

        private void frmReportPurchase_Load(object sender, EventArgs e)
        {
            IQueryable<Provider> providers = new BL_Provider().GetProviders();

            cmbProvider.Items.Add(new Option_ComboBox() { value = 0, text = "Todos"});
            foreach (Provider provider in providers)
            {
                cmbProvider.Items.Add(new Option_ComboBox() { value = provider.Id, text = provider.BusinessName });
            }
            cmbProvider.DisplayMember = "text";
            cmbProvider.ValueMember = "value";
            cmbProvider.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                cmbSearchBy.Items.Add(new Option_ComboBox() { value = column.Name, text = column.HeaderText });
            }
            cmbSearchBy.DisplayMember = "text";
            cmbSearchBy.ValueMember = "value";
            cmbSearchBy.SelectedIndex = 0;
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            SearchBy("", "");
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
                    dt.Columns.Add(column.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString()
                        });
                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteCompras {0}.xlsx", DateTime.Now.ToString("yyyy-MM-dd HHmmss"));
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBy(((Option_ComboBox)cmbSearchBy.SelectedItem).text, txtSearch.Text);
        }

        private void SearchBy(string by, string searchString)
        {
            IQueryable<ReportPurchase> reportPurchases;
            if (Convert.ToInt32(((Option_ComboBox)cmbProvider.SelectedItem).value.ToString()) == 0)
            {
                reportPurchases = new BL_Report().PurchaseReportAll(dtpInitialDate.Value.ToString(), dtpFinalDate.Value.ToString());
            }
            else
            {
                reportPurchases = new BL_Report().PurchaseReport(dtpInitialDate.Value.ToString(), dtpFinalDate.Value.ToString(), Convert.ToInt32(((Option_ComboBox)cmbProvider.SelectedItem).value.ToString()));
            }

            if (!searchString.Trim().Equals(""))
            {
                if (by == "Tipo Documento")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.DocumentType.Contains(searchString));
                }
                else if (by == "Nro Factura")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.InvoiceNumber.Contains(searchString));
                }
                else if (by == "Usuario")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.UserName.Contains(searchString));
                }
                else if (by == "Doc Proveedor")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.ProviderDocument.Contains(searchString));
                }
                else if (by == "Proveedor")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.ProviderName.Contains(searchString));
                }
                else if (by == "Codigo Producto")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.ProductCode.Contains(searchString));
                }
                else if (by == "Producto")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.ProductName.Contains(searchString));
                }
                else if (by == "Categoria")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.Category.Contains(searchString));
                }
                else if (by == "Precio Compra")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.PurchasePrice.Contains(searchString));
                }
                else if (by == "Precio Venta")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.SalePrice.Contains(searchString));
                }
                else if (by == "Cantidad")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.Quantity.Contains(searchString));
                }
                else if (by == "Sub Total")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.SubTotal.Contains(searchString));
                }
                else if (by == "Fecha")
                {
                    dgvList.Rows.Clear();
                    reportPurchases = reportPurchases.Where(o => o.DateRegister.Contains(searchString));
                }
            }
            else
            {
                dgvList.Rows.Clear();
            }


            foreach (ReportPurchase rp in reportPurchases)
            {
                dgvList.Rows.Add(new object[] { rp.DocumentType, rp.InvoiceNumber, rp.UserName, rp.ProviderDocument, rp.ProviderName, 
                    rp.ProductCode, rp.ProductName, rp.Category, rp.PurchasePrice, rp.SalePrice, rp.Quantity, rp.SubTotal, rp.DateRegister});
            }
        }
    }
}
