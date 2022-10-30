
namespace PresentationLayer.Forms
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUserData = new System.Windows.Forms.Panel();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.ibtnUserCancel = new FontAwesome.Sharp.IconButton();
            this.ibtnUserEdit = new FontAwesome.Sharp.IconButton();
            this.ibtnUserSave = new FontAwesome.Sharp.IconButton();
            this.cmbUserState = new System.Windows.Forms.ComboBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserState = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.txtUserPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserDocument = new System.Windows.Forms.TextBox();
            this.lblUserPasswordConfirm = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserMail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserDocument = new System.Windows.Forms.Label();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.cmbUserSearchBy = new System.Windows.Forms.ComboBox();
            this.lblUserSearchBy = new System.Windows.Forms.Label();
            this.ibtnCleanUserSearch = new FontAwesome.Sharp.IconButton();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ibtnUserSearch = new FontAwesome.Sharp.IconButton();
            this.pnlUserData.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserData
            // 
            this.pnlUserData.BackColor = System.Drawing.Color.White;
            this.pnlUserData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserData.Controls.Add(this.txtUserId);
            this.pnlUserData.Controls.Add(this.ibtnUserCancel);
            this.pnlUserData.Controls.Add(this.ibtnUserEdit);
            this.pnlUserData.Controls.Add(this.ibtnUserSave);
            this.pnlUserData.Controls.Add(this.cmbUserState);
            this.pnlUserData.Controls.Add(this.cmbUserRole);
            this.pnlUserData.Controls.Add(this.lblUserState);
            this.pnlUserData.Controls.Add(this.lblUserRole);
            this.pnlUserData.Controls.Add(this.txtUserPasswordConfirm);
            this.pnlUserData.Controls.Add(this.txtUserPassword);
            this.pnlUserData.Controls.Add(this.txtUserMail);
            this.pnlUserData.Controls.Add(this.txtUserName);
            this.pnlUserData.Controls.Add(this.txtUserDocument);
            this.pnlUserData.Controls.Add(this.lblUserPasswordConfirm);
            this.pnlUserData.Controls.Add(this.lblUserPassword);
            this.pnlUserData.Controls.Add(this.lblUserMail);
            this.pnlUserData.Controls.Add(this.lblUserName);
            this.pnlUserData.Controls.Add(this.lblUserDocument);
            this.pnlUserData.Controls.Add(this.lblUserTitle);
            this.pnlUserData.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserData.Location = new System.Drawing.Point(0, 0);
            this.pnlUserData.Name = "pnlUserData";
            this.pnlUserData.Size = new System.Drawing.Size(258, 497);
            this.pnlUserData.TabIndex = 0;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(191, 44);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(20, 23);
            this.txtUserId.TabIndex = 18;
            this.txtUserId.Text = "0";
            // 
            // ibtnUserCancel
            // 
            this.ibtnUserCancel.BackColor = System.Drawing.Color.Firebrick;
            this.ibtnUserCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnUserCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnUserCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUserCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnUserCancel.ForeColor = System.Drawing.Color.White;
            this.ibtnUserCancel.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.ibtnUserCancel.IconColor = System.Drawing.Color.White;
            this.ibtnUserCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUserCancel.IconSize = 18;
            this.ibtnUserCancel.Location = new System.Drawing.Point(34, 460);
            this.ibtnUserCancel.Name = "ibtnUserCancel";
            this.ibtnUserCancel.Size = new System.Drawing.Size(177, 23);
            this.ibtnUserCancel.TabIndex = 17;
            this.ibtnUserCancel.Text = "Cancelar";
            this.ibtnUserCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnUserCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUserCancel.UseVisualStyleBackColor = false;
            this.ibtnUserCancel.Click += new System.EventHandler(this.ibtnUserCancel_Click);
            // 
            // ibtnUserEdit
            // 
            this.ibtnUserEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.ibtnUserEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnUserEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnUserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUserEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnUserEdit.ForeColor = System.Drawing.Color.White;
            this.ibtnUserEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ibtnUserEdit.IconColor = System.Drawing.Color.White;
            this.ibtnUserEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUserEdit.IconSize = 18;
            this.ibtnUserEdit.Location = new System.Drawing.Point(34, 402);
            this.ibtnUserEdit.Name = "ibtnUserEdit";
            this.ibtnUserEdit.Size = new System.Drawing.Size(177, 23);
            this.ibtnUserEdit.TabIndex = 16;
            this.ibtnUserEdit.Text = "Editar";
            this.ibtnUserEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnUserEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUserEdit.UseVisualStyleBackColor = false;
            this.ibtnUserEdit.Visible = false;
            this.ibtnUserEdit.Click += new System.EventHandler(this.ibtnUserEdit_Click);
            // 
            // ibtnUserSave
            // 
            this.ibtnUserSave.BackColor = System.Drawing.Color.ForestGreen;
            this.ibtnUserSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnUserSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUserSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnUserSave.ForeColor = System.Drawing.Color.White;
            this.ibtnUserSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnUserSave.IconColor = System.Drawing.Color.White;
            this.ibtnUserSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUserSave.IconSize = 18;
            this.ibtnUserSave.Location = new System.Drawing.Point(34, 431);
            this.ibtnUserSave.Name = "ibtnUserSave";
            this.ibtnUserSave.Size = new System.Drawing.Size(177, 23);
            this.ibtnUserSave.TabIndex = 15;
            this.ibtnUserSave.Text = "Guardar";
            this.ibtnUserSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnUserSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUserSave.UseVisualStyleBackColor = false;
            this.ibtnUserSave.Click += new System.EventHandler(this.ibtnUserSave_Click);
            // 
            // cmbUserState
            // 
            this.cmbUserState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserState.FormattingEnabled = true;
            this.cmbUserState.Location = new System.Drawing.Point(34, 363);
            this.cmbUserState.Name = "cmbUserState";
            this.cmbUserState.Size = new System.Drawing.Size(177, 23);
            this.cmbUserState.TabIndex = 14;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(34, 314);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(177, 23);
            this.cmbUserRole.TabIndex = 13;
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.Location = new System.Drawing.Point(34, 344);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(42, 15);
            this.lblUserState.TabIndex = 12;
            this.lblUserState.Text = "Estado";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(34, 295);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(24, 15);
            this.lblUserRole.TabIndex = 11;
            this.lblUserRole.Text = "Rol";
            // 
            // txtUserPasswordConfirm
            // 
            this.txtUserPasswordConfirm.Location = new System.Drawing.Point(34, 265);
            this.txtUserPasswordConfirm.Name = "txtUserPasswordConfirm";
            this.txtUserPasswordConfirm.PasswordChar = '*';
            this.txtUserPasswordConfirm.Size = new System.Drawing.Size(177, 23);
            this.txtUserPasswordConfirm.TabIndex = 10;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(34, 217);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(177, 23);
            this.txtUserPassword.TabIndex = 9;
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(34, 169);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(177, 23);
            this.txtUserMail.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(34, 121);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(177, 23);
            this.txtUserName.TabIndex = 7;
            // 
            // txtUserDocument
            // 
            this.txtUserDocument.Location = new System.Drawing.Point(34, 73);
            this.txtUserDocument.Name = "txtUserDocument";
            this.txtUserDocument.Size = new System.Drawing.Size(177, 23);
            this.txtUserDocument.TabIndex = 6;
            // 
            // lblUserPasswordConfirm
            // 
            this.lblUserPasswordConfirm.AutoSize = true;
            this.lblUserPasswordConfirm.Location = new System.Drawing.Point(34, 247);
            this.lblUserPasswordConfirm.Name = "lblUserPasswordConfirm";
            this.lblUserPasswordConfirm.Size = new System.Drawing.Size(122, 15);
            this.lblUserPasswordConfirm.TabIndex = 5;
            this.lblUserPasswordConfirm.Text = "Confirmar contraseña";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(34, 199);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(67, 15);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "Contraseña";
            // 
            // lblUserMail
            // 
            this.lblUserMail.AutoSize = true;
            this.lblUserMail.Location = new System.Drawing.Point(34, 151);
            this.lblUserMail.Name = "lblUserMail";
            this.lblUserMail.Size = new System.Drawing.Size(43, 15);
            this.lblUserMail.TabIndex = 3;
            this.lblUserMail.Text = "Correo";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(34, 103);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Nombre completo";
            // 
            // lblUserDocument
            // 
            this.lblUserDocument.AutoSize = true;
            this.lblUserDocument.Location = new System.Drawing.Point(34, 54);
            this.lblUserDocument.Name = "lblUserDocument";
            this.lblUserDocument.Size = new System.Drawing.Size(93, 15);
            this.lblUserDocument.TabIndex = 1;
            this.lblUserDocument.Text = "Nro Documento";
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserTitle.Location = new System.Drawing.Point(34, 9);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(84, 28);
            this.lblUserTitle.TabIndex = 0;
            this.lblUserTitle.Text = "Usuario";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.txtUserSearch);
            this.pnlSearch.Controls.Add(this.cmbUserSearchBy);
            this.pnlSearch.Controls.Add(this.lblUserSearchBy);
            this.pnlSearch.Controls.Add(this.ibtnCleanUserSearch);
            this.pnlSearch.Controls.Add(this.lblListTitle);
            this.pnlSearch.Location = new System.Drawing.Point(283, 32);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(744, 38);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(492, 9);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(177, 23);
            this.txtUserSearch.TabIndex = 19;
            // 
            // cmbUserSearchBy
            // 
            this.cmbUserSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserSearchBy.FormattingEnabled = true;
            this.cmbUserSearchBy.Location = new System.Drawing.Point(360, 9);
            this.cmbUserSearchBy.Name = "cmbUserSearchBy";
            this.cmbUserSearchBy.Size = new System.Drawing.Size(126, 23);
            this.cmbUserSearchBy.TabIndex = 19;
            // 
            // lblUserSearchBy
            // 
            this.lblUserSearchBy.AutoSize = true;
            this.lblUserSearchBy.Location = new System.Drawing.Point(291, 12);
            this.lblUserSearchBy.Name = "lblUserSearchBy";
            this.lblUserSearchBy.Size = new System.Drawing.Size(63, 15);
            this.lblUserSearchBy.TabIndex = 19;
            this.lblUserSearchBy.Text = "Buscar Por";
            // 
            // ibtnCleanUserSearch
            // 
            this.ibtnCleanUserSearch.BackColor = System.Drawing.Color.White;
            this.ibtnCleanUserSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCleanUserSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnCleanUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCleanUserSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnCleanUserSearch.ForeColor = System.Drawing.Color.White;
            this.ibtnCleanUserSearch.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.ibtnCleanUserSearch.IconColor = System.Drawing.Color.Black;
            this.ibtnCleanUserSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCleanUserSearch.IconSize = 18;
            this.ibtnCleanUserSearch.Location = new System.Drawing.Point(716, 9);
            this.ibtnCleanUserSearch.Name = "ibtnCleanUserSearch";
            this.ibtnCleanUserSearch.Size = new System.Drawing.Size(25, 23);
            this.ibtnCleanUserSearch.TabIndex = 20;
            this.ibtnCleanUserSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCleanUserSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCleanUserSearch.UseVisualStyleBackColor = false;
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListTitle.Location = new System.Drawing.Point(6, 6);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(196, 28);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Listado de Usuarios";
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userDocument,
            this.userName,
            this.userEmail,
            this.userPassword,
            this.idRole,
            this.userRole,
            this.valueState,
            this.userState,
            this.userEdit});
            this.dgvUserList.Location = new System.Drawing.Point(283, 104);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUserList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserList.RowTemplate.Height = 28;
            this.dgvUserList.Size = new System.Drawing.Size(762, 380);
            this.dgvUserList.TabIndex = 2;
            this.dgvUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellContentClick);
            this.dgvUserList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUserList_CellPainting);
            // 
            // userId
            // 
            this.userId.HeaderText = "Id";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // userDocument
            // 
            this.userDocument.HeaderText = "Nro Documento";
            this.userDocument.Name = "userDocument";
            this.userDocument.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.HeaderText = "Nombre";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 200;
            // 
            // userEmail
            // 
            this.userEmail.HeaderText = "Correo";
            this.userEmail.Name = "userEmail";
            this.userEmail.ReadOnly = true;
            this.userEmail.Width = 150;
            // 
            // userPassword
            // 
            this.userPassword.HeaderText = "userPassword";
            this.userPassword.Name = "userPassword";
            this.userPassword.ReadOnly = true;
            this.userPassword.Visible = false;
            // 
            // idRole
            // 
            this.idRole.HeaderText = "idRole";
            this.idRole.Name = "idRole";
            this.idRole.ReadOnly = true;
            this.idRole.Visible = false;
            // 
            // userRole
            // 
            this.userRole.HeaderText = "Rol";
            this.userRole.Name = "userRole";
            this.userRole.ReadOnly = true;
            this.userRole.Width = 120;
            // 
            // valueState
            // 
            this.valueState.HeaderText = "valueState";
            this.valueState.Name = "valueState";
            this.valueState.ReadOnly = true;
            this.valueState.Visible = false;
            // 
            // userState
            // 
            this.userState.HeaderText = "Estado";
            this.userState.Name = "userState";
            this.userState.ReadOnly = true;
            // 
            // userEdit
            // 
            this.userEdit.HeaderText = "Editar";
            this.userEdit.Name = "userEdit";
            this.userEdit.ReadOnly = true;
            this.userEdit.Width = 50;
            // 
            // ibtnUserSearch
            // 
            this.ibtnUserSearch.BackColor = System.Drawing.Color.White;
            this.ibtnUserSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnUserSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUserSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnUserSearch.ForeColor = System.Drawing.Color.White;
            this.ibtnUserSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnUserSearch.IconColor = System.Drawing.Color.Black;
            this.ibtnUserSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUserSearch.IconSize = 18;
            this.ibtnUserSearch.Location = new System.Drawing.Point(965, 41);
            this.ibtnUserSearch.Name = "ibtnUserSearch";
            this.ibtnUserSearch.Size = new System.Drawing.Size(25, 23);
            this.ibtnUserSearch.TabIndex = 19;
            this.ibtnUserSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnUserSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUserSearch.UseVisualStyleBackColor = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1069, 497);
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.ibtnUserSearch);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlUserData);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.pnlUserData.ResumeLayout(false);
            this.pnlUserData.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserData;
        private System.Windows.Forms.ComboBox cmbUserState;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.TextBox txtUserPasswordConfirm;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserDocument;
        private System.Windows.Forms.Label lblUserPasswordConfirm;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserMail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserDocument;
        private System.Windows.Forms.Label lblUserTitle;
        private FontAwesome.Sharp.IconButton ibtnUserCancel;
        private FontAwesome.Sharp.IconButton ibtnUserEdit;
        private FontAwesome.Sharp.IconButton ibtnUserSave;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.ComboBox cmbUserSearchBy;
        private System.Windows.Forms.Label lblUserSearchBy;
        private FontAwesome.Sharp.IconButton ibtnCleanUserSearch;
        private FontAwesome.Sharp.IconButton ibtnUserSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn userState;
        private System.Windows.Forms.DataGridViewButtonColumn userEdit;
    }
}