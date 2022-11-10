
namespace PresentationLayer.Forms
{
    partial class frmClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ibtnExport = new FontAwesome.Sharp.IconButton();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ibtnCancel = new FontAwesome.Sharp.IconButton();
            this.ibtnEdit = new FontAwesome.Sharp.IconButton();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblUserState = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(34, 84);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(93, 15);
            this.lblDocument.TabIndex = 1;
            this.lblDocument.Text = "Nro Documento";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(34, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cliente";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Document,
            this.CName,
            this.Mail,
            this.Address,
            this.Phone,
            this.valueState,
            this.State,
            this.Edit});
            this.dgvList.Location = new System.Drawing.Point(274, 118);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.RowTemplate.Height = 28;
            this.dgvList.Size = new System.Drawing.Size(856, 349);
            this.dgvList.TabIndex = 8;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            this.dgvList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvList_CellPainting);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Document
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Document.DefaultCellStyle = dataGridViewCellStyle2;
            this.Document.FillWeight = 19.29519F;
            this.Document.HeaderText = "Nro Documento";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            // 
            // CName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CName.FillWeight = 456.8528F;
            this.CName.HeaderText = "Nombre";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 200;
            // 
            // Mail
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mail.DefaultCellStyle = dataGridViewCellStyle4;
            this.Mail.FillWeight = 19.29519F;
            this.Mail.HeaderText = "Correo";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 170;
            // 
            // Address
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Address.DefaultCellStyle = dataGridViewCellStyle5;
            this.Address.HeaderText = "Direccion";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Phone.DefaultCellStyle = dataGridViewCellStyle6;
            this.Phone.HeaderText = "Telefono";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // valueState
            // 
            this.valueState.HeaderText = "valueState";
            this.valueState.Name = "valueState";
            this.valueState.ReadOnly = true;
            this.valueState.Visible = false;
            // 
            // State
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.State.DefaultCellStyle = dataGridViewCellStyle7;
            this.State.FillWeight = 19.29519F;
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 80;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 65.96645F;
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 60;
            // 
            // ibtnExport
            // 
            this.ibtnExport.BackColor = System.Drawing.Color.Silver;
            this.ibtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnExport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnExport.ForeColor = System.Drawing.Color.Black;
            this.ibtnExport.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.ibtnExport.IconColor = System.Drawing.Color.ForestGreen;
            this.ibtnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExport.IconSize = 18;
            this.ibtnExport.Location = new System.Drawing.Point(15, 51);
            this.ibtnExport.Name = "ibtnExport";
            this.ibtnExport.Size = new System.Drawing.Size(118, 23);
            this.ibtnExport.TabIndex = 19;
            this.ibtnExport.Text = "Exportar";
            this.ibtnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnExport.UseVisualStyleBackColor = false;
            this.ibtnExport.Click += new System.EventHandler(this.ibtnExport_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.ibtnExport);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.cmbSearchBy);
            this.pnlSearch.Controls.Add(this.lblSearchBy);
            this.pnlSearch.Controls.Add(this.lblListTitle);
            this.pnlSearch.Location = new System.Drawing.Point(274, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(856, 88);
            this.pnlSearch.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(657, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 23);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(513, 51);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(138, 23);
            this.cmbSearchBy.TabIndex = 19;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(444, 54);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(63, 15);
            this.lblSearchBy.TabIndex = 19;
            this.lblSearchBy.Text = "Buscar Por";
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListTitle.Location = new System.Drawing.Point(6, 6);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(190, 28);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Listado de Clientes";
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.txtPhone);
            this.pnlData.Controls.Add(this.lblPhone);
            this.pnlData.Controls.Add(this.txtAddress);
            this.pnlData.Controls.Add(this.lblAddress);
            this.pnlData.Controls.Add(this.txtId);
            this.pnlData.Controls.Add(this.ibtnCancel);
            this.pnlData.Controls.Add(this.ibtnEdit);
            this.pnlData.Controls.Add(this.ibtnSave);
            this.pnlData.Controls.Add(this.cmbState);
            this.pnlData.Controls.Add(this.lblUserState);
            this.pnlData.Controls.Add(this.txtMail);
            this.pnlData.Controls.Add(this.txtName);
            this.pnlData.Controls.Add(this.txtDocument);
            this.pnlData.Controls.Add(this.lblMail);
            this.pnlData.Controls.Add(this.lblName);
            this.pnlData.Controls.Add(this.lblDocument);
            this.pnlData.Controls.Add(this.lblTitle);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(258, 503);
            this.pnlData.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(34, 296);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 23);
            this.txtPhone.TabIndex = 22;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(34, 278);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 15);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "Telefono";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(34, 248);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 23);
            this.txtAddress.TabIndex = 20;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 230);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 15);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Dirección";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(191, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 23);
            this.txtId.TabIndex = 18;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // ibtnCancel
            // 
            this.ibtnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.ibtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnCancel.ForeColor = System.Drawing.Color.White;
            this.ibtnCancel.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.ibtnCancel.IconColor = System.Drawing.Color.White;
            this.ibtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCancel.IconSize = 18;
            this.ibtnCancel.Location = new System.Drawing.Point(34, 443);
            this.ibtnCancel.Name = "ibtnCancel";
            this.ibtnCancel.Size = new System.Drawing.Size(177, 23);
            this.ibtnCancel.TabIndex = 17;
            this.ibtnCancel.Text = "Cancelar";
            this.ibtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCancel.UseVisualStyleBackColor = false;
            this.ibtnCancel.Click += new System.EventHandler(this.ibtnCancel_Click);
            // 
            // ibtnEdit
            // 
            this.ibtnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.ibtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnEdit.ForeColor = System.Drawing.Color.White;
            this.ibtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ibtnEdit.IconColor = System.Drawing.Color.White;
            this.ibtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEdit.IconSize = 18;
            this.ibtnEdit.Location = new System.Drawing.Point(34, 385);
            this.ibtnEdit.Name = "ibtnEdit";
            this.ibtnEdit.Size = new System.Drawing.Size(177, 23);
            this.ibtnEdit.TabIndex = 16;
            this.ibtnEdit.Text = "Editar";
            this.ibtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEdit.UseVisualStyleBackColor = false;
            this.ibtnEdit.Visible = false;
            this.ibtnEdit.Click += new System.EventHandler(this.ibtnEdit_Click);
            // 
            // ibtnSave
            // 
            this.ibtnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.ibtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnSave.ForeColor = System.Drawing.Color.White;
            this.ibtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnSave.IconColor = System.Drawing.Color.White;
            this.ibtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSave.IconSize = 18;
            this.ibtnSave.Location = new System.Drawing.Point(34, 414);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(177, 23);
            this.ibtnSave.TabIndex = 15;
            this.ibtnSave.Text = "Guardar";
            this.ibtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSave.UseVisualStyleBackColor = false;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(34, 346);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(177, 23);
            this.cmbState.TabIndex = 14;
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.Location = new System.Drawing.Point(34, 327);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(42, 15);
            this.lblUserState.TabIndex = 12;
            this.lblUserState.Text = "Estado";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(34, 199);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(177, 23);
            this.txtMail.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(34, 151);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 23);
            this.txtName.TabIndex = 7;
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(34, 103);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(177, 23);
            this.txtDocument.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(34, 181);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(43, 15);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Correo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre Completo";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1147, 503);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvList;
        private FontAwesome.Sharp.IconButton ibtnExport;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private FontAwesome.Sharp.IconButton ibtnEdit;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
    }
}