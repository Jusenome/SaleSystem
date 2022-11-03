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
                if(column.Visible == true && !(column.Name == "userEdit"))
                {
                    cmbUserSearchBy.Items.Add(new Option_ComboBox() { value = column.Name, text = column.HeaderText });
                }
            }
            cmbUserSearchBy.DisplayMember = "text";
            cmbUserSearchBy.ValueMember = "value";
            cmbUserSearchBy.SelectedIndex = 0;

            SearchBy("", "");
            
            
        }

        private void ibtnUserSave_Click(object sender, EventArgs e)
        {
            BL_User blUser = new BL_User();

            AppUser user = new AppUser()
            {
                Document = txtUserDocument.Text,
                FullName = txtUserName.Text,
                Mail = txtUserMail.Text,
                Password = txtUserPassword.Text,
                IdRole = (int)((Option_ComboBox)cmbUserRole.SelectedItem).value,
                State = (int)((Option_ComboBox)cmbUserState.SelectedItem).value == 1 ? true : false
            };

            string result = blUser.CreateUser(user);
            MessageBox.Show(result);

            Clean();
            frmUser_Load(sender, e);
        }

        private void ibtnUserEdit_Click(object sender, EventArgs e)
        {
            AppUser user = new AppUser() { 
                Id = Convert.ToInt32(txtUserId.Text),
                Document = txtUserDocument.Text,
                FullName = txtUserName.Text,
                Mail = txtUserMail.Text,
                Password = txtUserPassword.Text,
                IdRole = (int)((Option_ComboBox)cmbUserRole.SelectedItem).value,
                State = (int)((Option_ComboBox)cmbUserState.SelectedItem).value == 1 ? true : false 
            };

            string result = new BL_User().UpdateUser(Convert.ToInt32(txtUserId.Text), user);
            MessageBox.Show(result);

            Clean();
            frmUser_Load(sender, e);
        }

        private void ibtnUserCancel_Click(object sender, EventArgs e)
        {
            Clean();
            frmUser_Load(sender, e);
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

            ibtnUserSave.Visible = true;
            ibtnUserSave.Location = new System.Drawing.Point(34, 431);
            ibtnUserEdit.Visible = false;
            ibtnUserEdit.Location = new System.Drawing.Point(34, 402);

            dgvUserList.Rows.Clear();
            cmbUserRole.Items.Clear();
            cmbUserState.Items.Clear();
            cmbUserSearchBy.Items.Clear();

            txtUserDocument.Select();

        }

        private void dgvUserList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int totalColumn = dgvUserList.ColumnCount;
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

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvUserList.Columns[e.ColumnIndex].Name == "userEdit")
            {
                if(e.RowIndex >= 0)
                {
                    txtUserId.Text = dgvUserList.Rows[e.RowIndex].Cells["userId"].Value.ToString();
                    txtUserDocument.Text = dgvUserList.Rows[e.RowIndex].Cells["userDocument"].Value.ToString();
                    txtUserName.Text = dgvUserList.Rows[e.RowIndex].Cells["userName"].Value.ToString();
                    txtUserMail.Text = dgvUserList.Rows[e.RowIndex].Cells["userEmail"].Value.ToString();
                    txtUserPassword.Text = dgvUserList.Rows[e.RowIndex].Cells["userPassword"].Value.ToString();
                    txtUserPasswordConfirm.Text = dgvUserList.Rows[e.RowIndex].Cells["userPassword"].Value.ToString();

                    foreach(Option_ComboBox ocb in cmbUserRole.Items)
                    {
                        if(Convert.ToInt32(ocb.value) == Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["idRole"].Value))
                        {
                            cmbUserRole.SelectedIndex = cmbUserRole.Items.IndexOf(ocb);
                            break;
                        }
                    }

                    foreach(Option_ComboBox ocb in cmbUserState.Items)
                    {
                        if (Convert.ToInt32(ocb.value) == Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["valueState"].Value))
                        {
                            cmbUserState.SelectedIndex = cmbUserState.Items.IndexOf(ocb);
                            break;
                        }
                    }

                    ibtnUserSave.Visible = false;
                    ibtnUserSave.Location = new System.Drawing.Point(34, 402);
                    ibtnUserEdit.Visible = true;
                    ibtnUserEdit.Location = new System.Drawing.Point(34, 431);
                    
                }
            }
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBy(((Option_ComboBox)cmbUserSearchBy.SelectedItem).text, txtUserSearch.Text);
        }

        private void SearchBy(string by, string searchString)
        {
            IQueryable<AppUser> users = new BL_User().ToList();

            if(!searchString.Trim().Equals(""))
            {
                if(by == "Nro Documento")
                {
                    dgvUserList.Rows.Clear();
                    users = users.Where(o => o.Document.Contains(searchString));
                }
                else if (by == "Nombre")
                {
                    dgvUserList.Rows.Clear();
                    users = users.Where(o => o.FullName.Contains(searchString));
                }
                else if(by == "Correo")
                {
                    dgvUserList.Rows.Clear();
                    users = users.Where(o => o.Mail.Contains(searchString));
                }
                else if(by == "Rol")
                {
                    dgvUserList.Rows.Clear();
                    int idRole = 0;
                    foreach (Option_ComboBox ocb in cmbUserRole.Items)
                    {
                        if (ocb.text.Contains(searchString.ToUpper()))
                        {
                            cmbUserRole.SelectedIndex = cmbUserRole.Items.IndexOf(ocb);
                            idRole = (int)((Option_ComboBox)cmbUserRole.SelectedItem).value;
                            cmbUserRole.SelectedIndex = 0;
                            break;
                        }
                    }
                    users = users.Where(o => o.IdRole == idRole);
                }
                else if(by == "Estado")
                {
                    dgvUserList.Rows.Clear();
                    bool state = false;
                    foreach (Option_ComboBox ocb in cmbUserState.Items)
                    {
                        if (ocb.text.Contains(searchString.ToUpper()))
                        {
                            cmbUserState.SelectedIndex = cmbUserState.Items.IndexOf(ocb);
                            state = (int)((Option_ComboBox)cmbUserState.SelectedItem).value == 1 ? true : false;
                            cmbUserState.SelectedIndex = 0;
                            break;
                        }
                    }
                    users = users.Where(o => o.State == state);
                }
            }
            else
            {
                dgvUserList.Rows.Clear();
            }


            foreach (AppUser user in users)
            {
                string roleName = new BL_Role().GetRole((int)user.IdRole).Description;

                dgvUserList.Rows.Add(new object[] { user.Id, user.Document, user.FullName, user.Mail, user.Password, user.IdRole, roleName,
                    user.State == true ? 1 : 0, user.State == true ? "ACTIVO" : "INACTIVO", "" });
            }
        }
    }
}
