using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void ibtnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnEnterLogin_Click(object sender, EventArgs e)
        {
            
            AppUser oUser = new BL_User().ToList().Where(o => o.Document == txtDocumentLogin.Text && o.Password == txtPasswordLogin.Text).FirstOrDefault();

            if (oUser != null)
            {
                frmMain frmInicio = new frmMain(oUser);
                frmInicio.Show();
                this.Hide();

                frmInicio.FormClosing += frmClose;
            }
            else
            {
                MessageBox.Show("Documento y/o Contraseña no existen");
                txtPasswordLogin.Text = "";
            }
                

            

            
        }

        //Evento para hacer visible el login luego de cerrar la ventana inicio
        private void frmClose(object sender, FormClosingEventArgs e)
        {
            txtDocumentLogin.Text = "";
            txtPasswordLogin.Text = "";

            this.Show();
        }
    }
}
