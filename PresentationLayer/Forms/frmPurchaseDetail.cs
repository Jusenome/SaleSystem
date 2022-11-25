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
    public partial class frmPurchaseDetail : Form
    {
        public frmPurchaseDetail()
        {
            InitializeComponent();
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            Purchase purchase = new BL_Purchase().GetPurchaseByInvoiceNumber(txtSerarch.Text);
            txtDate.Text = purchase.CreationDate.ToString();
            txtDocumentType.Text = purchase.DocumentType;
            txtUser.Text = new BL_User().GetUserById((int)purchase.IdUser).FullName;
            txtInvoiceInGrpProvider.Text = purchase.InvoiceNumber;

            Provider provider = new BL_Provider().GetProviderById((int)purchase.IdProvider);
            txtNit.Text = provider.Document;
            txtProviderName.Text = provider.BusinessName;

            List<PurchaseDetail> purchaseDetails = new BL_PurchaseDetail().GetPurchaseDetailsByPurchaseId(purchase.Id);

            dgvPurchaseList.Rows.Clear();
            foreach(PurchaseDetail purchaseDetail in purchaseDetails)
            {
                string productName = new BL_Product().GetProductById((int)purchaseDetail.IdProduct).Name;
                dgvPurchaseList.Rows.Add(new object[] { productName, purchaseDetail.PurchasePrice, purchaseDetail.Quantity, purchaseDetail.Total });
            }

            txtTotalPay.Text = purchase.Total.ToString();
        }

        private void ibtnClean_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtDocumentType.Text = "";
            txtUser.Text = "";
            txtNit.Text = "";
            txtProviderName.Text = "";
            dgvPurchaseList.Rows.Clear();
            txtTotalPay.Text = "";
        }

        private void ibtnDownload_Click(object sender, EventArgs e)
        {
            if(txtDocumentType.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHtml = Properties.Resources.PlantillaCompra.ToString();
            BusinessData businessData = new BL_BusinessData().GetBusinessData();

            textoHtml = textoHtml.Replace("@nombrenegocio", businessData.Nombre.ToUpper());
            textoHtml = textoHtml.Replace("@docnegocio", businessData.Nit);
            textoHtml = textoHtml.Replace("@direcnegocio", businessData.Address);

            textoHtml = textoHtml.Replace("@tipodocumento", txtDocumentType.Text);
            textoHtml = textoHtml.Replace("@numerodocumento", txtInvoiceInGrpProvider.Text);

            textoHtml = textoHtml.Replace("@docproveedor", txtNit.Text);
            textoHtml = textoHtml.Replace("@nombreproveedor", txtProviderName.Text);
            textoHtml = textoHtml.Replace("@fecharegistro", txtDate.Text);
            textoHtml = textoHtml.Replace("@usuarioregistro", txtUser.Text);

            string filas = "";
            foreach(DataGridViewRow row in dgvPurchaseList.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Product"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PurchasePrice"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Amount"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            textoHtml = textoHtml.Replace("@filas", filas);
            textoHtml = textoHtml.Replace("@montototal", txtTotalPay.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Compra {0}.pdf", txtInvoiceInGrpProvider.Text);
            saveFile.Filter = "Pdf Files | *.pdf";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
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
