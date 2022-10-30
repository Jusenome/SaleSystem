using BusinessLayer;
using EntityLayer;
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
    

    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            List<AppUser> users = new BL_User().ToList();
            List<Role> oRoles = new BL_Role().GetRoleList();
            
            foreach(Role role in oRoles)
            {
                cmbUserRole.Items.Add(new Option_ComboBox() { value = role.Id, text = role.Description });
            }
            cmbUserRole.DisplayMember = "text";
            cmbUserRole.ValueMember = "value";
            cmbUserRole.SelectedIndex = 0;

            cmbUserState.Items.Add(new Option_ComboBox() { value = 1, text = "ACTIVO" });
            cmbUserState.Items.Add(new Option_ComboBox() { value = 0, text = "INACTIVO" });
            cmbUserState.DisplayMember = "text";
            cmbUserState.ValueMember = "value";
            cmbUserState.SelectedIndex = 0;

            foreach(DataGridViewColumn column in dgvUserList.Columns)
            {
                if(column.Visible == true)
                {
                    cmbUserSearchBy.Items.Add(new Option_ComboBox() { value = column.Name, text = column.HeaderText });
                }
            }
            cmbUserSearchBy.DisplayMember = "text";
            cmbUserSearchBy.ValueMember = "value";
            cmbUserSearchBy.SelectedIndex = 0;


            foreach (AppUser user in users)
            {
                string roleName = new BL_Role().GetRole((int)user.IdRole).Description;
                
                dgvUserList.Rows.Add(new object[] { user.Id, user.Document, user.FullName, user.Mail, user.Password, user.IdRole, roleName, 
                    user.State == true ? 1 : 0, user.State == true ? "ACTIVO" : "INACTIVO", "" });
            }
            
        }

        private void ibtnUserSave_Click(object sender, EventArgs e)
        {
            BL_User blUser = new BL_User();

            blUser.CreateUser(txtUserDocument.Text, txtUserName.Text, txtUserMail.Text, txtUserPassword.Text, 
                (int)((Option_ComboBox)cmbUserRole.SelectedItem).value, (int)((Option_ComboBox)cmbUserState.SelectedItem).value == 1 ? true : false);

            dgvUserList.Rows.Clear();
            frmUser_Load(sender, e);

            Clean();
        }

        private void ibtnUserClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            txtUserId.Text = "0";
            txtUserDocument.Text = "";
            txtUserName.Text = "";
            txtUserMail.Text = "";
            txtUserPassword.Text = "";
            txtUserPasswordConfirm.Text = "";
            cmbUserRole.SelectedIndex = 0;
            cmbUserState.SelectedIndex = 0;

        }
    }
}
