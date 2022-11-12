
namespace PresentationLayer.Forms
{
    partial class frmBusinessData
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.grpBoxBusiness = new System.Windows.Forms.GroupBox();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.ibtnLoad = new FontAwesome.Sharp.IconButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.grpBoxBusiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.grpBoxBusiness);
            this.pnlData.Controls.Add(this.lblTitle);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(573, 410);
            this.pnlData.TabIndex = 2;
            // 
            // grpBoxBusiness
            // 
            this.grpBoxBusiness.Controls.Add(this.ibtnSave);
            this.grpBoxBusiness.Controls.Add(this.txtPhone);
            this.grpBoxBusiness.Controls.Add(this.lblPhone);
            this.grpBoxBusiness.Controls.Add(this.txtAddress);
            this.grpBoxBusiness.Controls.Add(this.lblAddress);
            this.grpBoxBusiness.Controls.Add(this.txtName);
            this.grpBoxBusiness.Controls.Add(this.lblName);
            this.grpBoxBusiness.Controls.Add(this.txtNit);
            this.grpBoxBusiness.Controls.Add(this.lblNit);
            this.grpBoxBusiness.Controls.Add(this.ibtnLoad);
            this.grpBoxBusiness.Controls.Add(this.lblLogo);
            this.grpBoxBusiness.Controls.Add(this.picBoxLogo);
            this.grpBoxBusiness.Location = new System.Drawing.Point(11, 58);
            this.grpBoxBusiness.Name = "grpBoxBusiness";
            this.grpBoxBusiness.Size = new System.Drawing.Size(545, 278);
            this.grpBoxBusiness.TabIndex = 1;
            this.grpBoxBusiness.TabStop = false;
            // 
            // ibtnSave
            // 
            this.ibtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnSave.IconColor = System.Drawing.Color.Black;
            this.ibtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSave.IconSize = 20;
            this.ibtnSave.Location = new System.Drawing.Point(164, 169);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(375, 24);
            this.ibtnSave.TabIndex = 11;
            this.ibtnSave.Text = "Guardar";
            this.ibtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSave.UseVisualStyleBackColor = true;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(365, 137);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(174, 23);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(365, 116);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 15);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Telefono:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(164, 137);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 23);
            this.txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(164, 116);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 15);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(365, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 23);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(365, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(164, 66);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(174, 23);
            this.txtNit.TabIndex = 4;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNit.Location = new System.Drawing.Point(164, 44);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(33, 15);
            this.lblNit.TabIndex = 3;
            this.lblNit.Text = "NIT:";
            // 
            // ibtnLoad
            // 
            this.ibtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnLoad.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.ibtnLoad.IconColor = System.Drawing.Color.Black;
            this.ibtnLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLoad.IconSize = 20;
            this.ibtnLoad.Location = new System.Drawing.Point(7, 169);
            this.ibtnLoad.Name = "ibtnLoad";
            this.ibtnLoad.Size = new System.Drawing.Size(122, 24);
            this.ibtnLoad.TabIndex = 2;
            this.ibtnLoad.Text = "Cargar";
            this.ibtnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLoad.UseVisualStyleBackColor = true;
            this.ibtnLoad.Click += new System.EventHandler(this.ibtnLoad_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.Location = new System.Drawing.Point(7, 19);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(43, 15);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Logo:";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxLogo.Location = new System.Drawing.Point(6, 44);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(123, 119);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(11, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detalles Negocio";
            // 
            // frmBusinessData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.pnlData);
            this.Name = "frmBusinessData";
            this.Text = "frmBusinessData";
            this.Load += new System.EventHandler(this.frmBusinessData_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.grpBoxBusiness.ResumeLayout(false);
            this.grpBoxBusiness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBoxBusiness;
        private FontAwesome.Sharp.IconButton ibtnLoad;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private FontAwesome.Sharp.IconButton ibtnSave;
    }
}