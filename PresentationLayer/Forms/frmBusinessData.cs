using BusinessLayer;
using EntityLayer;
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
    public partial class frmBusinessData : Form
    {
        byte[] imageBytes = new byte[0];
        bool businessExists = false;

        public frmBusinessData()
        {
            InitializeComponent();
        }

        private void frmBusinessData_Load(object sender, EventArgs e)
        {
            BusinessData business = new BL_BusinessData().GetBusinessData();

            if(business != null)
            {
                if (business.Logo != null)
                    picBoxLogo.Image = ByteToImage(business.Logo);

                txtNit.Text = business.Nit;
                txtName.Text = business.Nombre;
                txtAddress.Text = business.Address;
                txtPhone.Text = business.Phone;
                imageBytes = business.Logo;

                businessExists = true;
            }
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void ibtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                imageBytes = File.ReadAllBytes(openFileDialog.FileName);

            picBoxLogo.Image = ByteToImage(imageBytes);
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            BusinessData business = new BusinessData()
            {
                Nit = txtNit.Text,
                Nombre = txtName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Logo = imageBytes
            };

            string result = "";

            if (!businessExists)
            {
                result = new BL_BusinessData().CreateBusiness(business);
            }
            else
            {
                result = new BL_BusinessData().UpdateBusiness(txtNit.Text, business);
            }

            MessageBox.Show(result);
            frmBusinessData_Load(sender, e);
        }
    }
}
