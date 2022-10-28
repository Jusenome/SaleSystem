using BusinessLayer;
using EntityLayer;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        private static AppUser user;
        private static IconMenuItem activeMenu = null;
        private static Form activeForm = null;

        public frmMain(AppUser oUser)
        {
            user = oUser;

            InitializeComponent();
        }

        
        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUserName.Text = user.FullName;

            Role role = new BL_Role().GetRole((int)user.IdRole);

            if (!role.Description.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                foreach(IconMenuItem iconMenu in menu.Items)
                {
                    if (iconMenu.Name == "imiUsers" || iconMenu.Name == "imiReports")
                    {
                        iconMenu.Visible = false;
                    }
                }
                
            }
        }


        private void OpenForm(IconMenuItem menu, Form form)
        {
            if (activeMenu != null)
                activeMenu.BackColor = Color.White;

            menu.BackColor = Color.Silver;
            activeMenu = menu;

            if (activeForm != null)
                activeForm.Close();

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.SteelBlue;

            pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void imiUsers_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new Forms.frmUser());
        }

        private void subMenuCategory_Click(object sender, EventArgs e)
        {
            OpenForm(imiAdmin, new Forms.frmCategory());
        }

        private void subMenuProducts_Click(object sender, EventArgs e)
        {
            OpenForm(imiAdmin, new Forms.frmProduct());
        }

        private void subMenuProviders_Click(object sender, EventArgs e)
        {
            OpenForm(imiAdmin, new Forms.frmProvider());
        }

        private void subMenuPurchaseRegister_Click(object sender, EventArgs e)
        {
            OpenForm(imiPurchases, new Forms.frmPurchase());
        }

        private void subMenuPurchaseDetail_Click(object sender, EventArgs e)
        {
            OpenForm(imiPurchases, new Forms.frmPurchaseDetail());
        }

        private void subMenuSaleRegister_Click(object sender, EventArgs e)
        {
            OpenForm(imiSales, new Forms.frmSale());
        }

        private void subMenuSaleDetail_Click(object sender, EventArgs e)
        {
            OpenForm(imiSales, new Forms.frmSaleDetail());
        }

        private void imiClients_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new Forms.frmClient());
        }

        private void imiReports_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new Forms.frmReport());
        }
    }
}
