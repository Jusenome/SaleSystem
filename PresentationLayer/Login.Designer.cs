
namespace PresentationLayer
{
    partial class formLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipbImagenLogin = new FontAwesome.Sharp.IconPictureBox();
            this.lblDocumentoLogin = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtDocumentLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.ibtnEnterLogin = new FontAwesome.Sharp.IconButton();
            this.ibtnCancelLogin = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImagenLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 236);
            this.label1.TabIndex = 0;
            // 
            // ipbImagenLogin
            // 
            this.ipbImagenLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.ipbImagenLogin.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.ipbImagenLogin.IconColor = System.Drawing.Color.White;
            this.ipbImagenLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbImagenLogin.IconSize = 117;
            this.ipbImagenLogin.Location = new System.Drawing.Point(45, 47);
            this.ipbImagenLogin.Name = "ipbImagenLogin";
            this.ipbImagenLogin.Size = new System.Drawing.Size(131, 117);
            this.ipbImagenLogin.TabIndex = 2;
            this.ipbImagenLogin.TabStop = false;
            // 
            // lblDocumentoLogin
            // 
            this.lblDocumentoLogin.AutoSize = true;
            this.lblDocumentoLogin.Location = new System.Drawing.Point(267, 29);
            this.lblDocumentoLogin.Name = "lblDocumentoLogin";
            this.lblDocumentoLogin.Size = new System.Drawing.Size(93, 15);
            this.lblDocumentoLogin.TabIndex = 3;
            this.lblDocumentoLogin.Text = "Nro Documento";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(267, 92);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(67, 15);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtDocumentLogin
            // 
            this.txtDocumentLogin.Location = new System.Drawing.Point(267, 47);
            this.txtDocumentLogin.Name = "txtDocumentLogin";
            this.txtDocumentLogin.Size = new System.Drawing.Size(220, 23);
            this.txtDocumentLogin.TabIndex = 5;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(267, 111);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(220, 23);
            this.txtPasswordLogin.TabIndex = 6;
            // 
            // ibtnEnterLogin
            // 
            this.ibtnEnterLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.ibtnEnterLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnEnterLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnEnterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEnterLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnEnterLogin.ForeColor = System.Drawing.Color.White;
            this.ibtnEnterLogin.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtnEnterLogin.IconColor = System.Drawing.Color.White;
            this.ibtnEnterLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEnterLogin.IconSize = 25;
            this.ibtnEnterLogin.Location = new System.Drawing.Point(267, 168);
            this.ibtnEnterLogin.Name = "ibtnEnterLogin";
            this.ibtnEnterLogin.Size = new System.Drawing.Size(93, 36);
            this.ibtnEnterLogin.TabIndex = 7;
            this.ibtnEnterLogin.Text = "Ingresar";
            this.ibtnEnterLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEnterLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEnterLogin.UseVisualStyleBackColor = false;
            this.ibtnEnterLogin.Click += new System.EventHandler(this.ibtnEnterLogin_Click);
            // 
            // ibtnCancelLogin
            // 
            this.ibtnCancelLogin.BackColor = System.Drawing.Color.Red;
            this.ibtnCancelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCancelLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCancelLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnCancelLogin.ForeColor = System.Drawing.Color.White;
            this.ibtnCancelLogin.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.ibtnCancelLogin.IconColor = System.Drawing.Color.White;
            this.ibtnCancelLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCancelLogin.IconSize = 25;
            this.ibtnCancelLogin.Location = new System.Drawing.Point(397, 168);
            this.ibtnCancelLogin.Name = "ibtnCancelLogin";
            this.ibtnCancelLogin.Size = new System.Drawing.Size(93, 36);
            this.ibtnCancelLogin.TabIndex = 8;
            this.ibtnCancelLogin.Text = "Cancelar";
            this.ibtnCancelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCancelLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCancelLogin.UseVisualStyleBackColor = false;
            this.ibtnCancelLogin.Click += new System.EventHandler(this.ibtnCancelLogin_Click);
            // 
            // formLogin
            // 
            this.AcceptButton = this.ibtnEnterLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 236);
            this.Controls.Add(this.ibtnCancelLogin);
            this.Controls.Add(this.ibtnEnterLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtDocumentLogin);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblDocumentoLogin);
            this.Controls.Add(this.ipbImagenLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ipbImagenLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox ipbImagenLogin;
        private System.Windows.Forms.Label lblDocumentoLogin;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtDocumentLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private FontAwesome.Sharp.IconButton ibtnEnterLogin;
        private FontAwesome.Sharp.IconButton ibtnCancelLogin;
    }
}