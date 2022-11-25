using BusinessLayer;
using EntityLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class frmSaleDetail : Form
    {
        public frmSaleDetail()
        {
            InitializeComponent();
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            Sale sale = new BL_Sale().GetSaleByInvoiceNumber(txtSerarch.Text);
            txtDate.Text = sale.CreationDate.ToString();
            txtDocumentType.Text = sale.DocumentType;
            txtUser.Text = new BL_User().GetUserById((int)sale.IdUser).FullName;
            txtInvoiceInGrpProvider.Text = sale.InvoiceNumber;

            Client client = new BL_Client().GetClientByDocument((sale.ClientDocument));
            txtClientDocument.Text = client.Document;
            txtClientName.Text = client.FullName;

            List<SaleDetail> saleDetails = new BL_SaleDetail().GetSaleDetailsBySaleId(sale.Id);

            dgvSaleList.Rows.Clear();
            foreach (SaleDetail saleDetail in saleDetails)
            {
                string productName = new BL_Product().GetProductById((int)saleDetail.IdProduct).Name;
                dgvSaleList.Rows.Add(new object[] { productName, saleDetail.SalePrice, saleDetail.Quantity, saleDetail.Subtotal });
            }

            txtTotalPay.Text = sale.Total.ToString();
            txtPayWith.Text = sale.Payment.ToString();
            txtChange.Text = sale.Change.ToString();
        }

        private void ibtnClean_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtDocumentType.Text = "";
            txtUser.Text = "";
            txtClientDocument.Text = "";
            txtClientName.Text = "";
            dgvSaleList.Rows.Clear();
            txtTotalPay.Text = "";
            txtPayWith.Text = "";
            txtChange.Text = "";
        }

        private void ibtnDownload_Click(object sender, EventArgs e)
        {
            if (txtDocumentType.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHtml = Properties.Resources.PlantillaVenta.ToString();
            BusinessData businessData = new BL_BusinessData().GetBusinessData();

            textoHtml = textoHtml.Replace("@nombrenegocio", businessData.Nombre.ToUpper());
            textoHtml = textoHtml.Replace("@docnegocio", businessData.Nit);
            textoHtml = textoHtml.Replace("@direcnegocio", businessData.Address);

            textoHtml = textoHtml.Replace("@tipodocumento", txtDocumentType.Text);
            textoHtml = textoHtml.Replace("@numerodocumento", txtInvoiceInGrpProvider.Text);

            textoHtml = textoHtml.Replace("@doccliente", txtClientDocument.Text);
            textoHtml = textoHtml.Replace("@nombrecliente", txtClientName.Text);
            textoHtml = textoHtml.Replace("@fecharegistro", txtDate.Text);
            textoHtml = textoHtml.Replace("@usuarioregistro", txtUser.Text);

            string filas = "";
            foreach (DataGridViewRow row in dgvSaleList.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Product"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SalePrice"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Amount"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            textoHtml = textoHtml.Replace("@filas", filas);
            textoHtml = textoHtml.Replace("@montototal", txtTotalPay.Text);
            textoHtml = textoHtml.Replace("@pagocon", txtPayWith.Text);
            textoHtml = textoHtml.Replace("@cambio", txtChange.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Venta {0}.pdf", txtInvoiceInGrpProvider.Text);
            saveFile.Filter = "Pdf Files | *.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document docPdf = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(docPdf, stream);
                    docPdf.Open();

                    byte[] byteImage = new BL_BusinessData().GetLogo();

                    if (byteImage != null)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(docPdf.Left, docPdf.GetTop(51));
                        docPdf.Add(img);
                    }

                    using (StringReader sr = new StringReader(textoHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, docPdf, sr);
                    }

                    docPdf.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
