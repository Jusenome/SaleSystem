using EntityLayer;
using PresentationLayer.Modals;
using PresentationLayer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class frmPurchase : Form
    {
        AppUser oUsuario;

        public frmPurchase(AppUser usuario)
        {
            oUsuario = usuario;
            InitializeComponent();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            cmbDocumentType.Items.Add(new Option_ComboBox() { value = "Factura", text = "Factura" });
            cmbDocumentType.DisplayMember = "text";
            cmbDocumentType.ValueMember = "value";
            cmbDocumentType.SelectedIndex = 0;

            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        private void ibtnSearchProvider_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProvider())
            {
                var result = modal.ShowDialog();

                if(result == DialogResult.OK)
                {
                    txtProviderId.Text = modal.provider.Id.ToString();
                    txtProviderNit.Text = modal.provider.Document;
                    txtProviderName.Text = modal.provider.BusinessName;
                }
                else
                {
                    txtProviderNit.Select();
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
                }
                else
                {
                    txtProductCode.Select();
                }
            };
        }
    }
}
