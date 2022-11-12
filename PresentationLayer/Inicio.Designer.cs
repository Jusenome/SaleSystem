
namespace PresentationLayer
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.imiUsers = new FontAwesome.Sharp.IconMenuItem();
            this.imiAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategory = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProducts = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProviders = new FontAwesome.Sharp.IconMenuItem();
            this.imiPurchases = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPurchaseRegister = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPurchaseDetail = new FontAwesome.Sharp.IconMenuItem();
            this.imiClients = new FontAwesome.Sharp.IconMenuItem();
            this.imiSales = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSaleRegister = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSaleDetail = new FontAwesome.Sharp.IconMenuItem();
            this.imiReports = new FontAwesome.Sharp.IconMenuItem();
            this.imiAbout = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitle = new System.Windows.Forms.MenuStrip();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.subMenuBusinessData = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imiUsers,
            this.imiAdmin,
            this.imiPurchases,
            this.imiClients,
            this.imiSales,
            this.imiReports,
            this.imiAbout});
            this.menu.Location = new System.Drawing.Point(0, 51);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1370, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // imiUsers
            // 
            this.imiUsers.AutoSize = false;
            this.imiUsers.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.imiUsers.IconColor = System.Drawing.Color.Black;
            this.imiUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiUsers.IconSize = 50;
            this.imiUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiUsers.Name = "imiUsers";
            this.imiUsers.Size = new System.Drawing.Size(90, 69);
            this.imiUsers.Text = "Usuarios";
            this.imiUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiUsers.Click += new System.EventHandler(this.imiUsers_Click);
            // 
            // imiAdmin
            // 
            this.imiAdmin.AutoSize = false;
            this.imiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategory,
            this.subMenuProducts,
            this.subMenuProviders,
            this.subMenuBusinessData});
            this.imiAdmin.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.imiAdmin.IconColor = System.Drawing.Color.Black;
            this.imiAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiAdmin.IconSize = 50;
            this.imiAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiAdmin.Name = "imiAdmin";
            this.imiAdmin.Size = new System.Drawing.Size(122, 69);
            this.imiAdmin.Text = "Administración";
            this.imiAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCategory
            // 
            this.subMenuCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategory.IconColor = System.Drawing.Color.Black;
            this.subMenuCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategory.Name = "subMenuCategory";
            this.subMenuCategory.Size = new System.Drawing.Size(180, 22);
            this.subMenuCategory.Text = "Categorias";
            this.subMenuCategory.Click += new System.EventHandler(this.subMenuCategory_Click);
            // 
            // subMenuProducts
            // 
            this.subMenuProducts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProducts.IconColor = System.Drawing.Color.Black;
            this.subMenuProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProducts.Name = "subMenuProducts";
            this.subMenuProducts.Size = new System.Drawing.Size(180, 22);
            this.subMenuProducts.Text = "Productos";
            this.subMenuProducts.Click += new System.EventHandler(this.subMenuProducts_Click);
            // 
            // subMenuProviders
            // 
            this.subMenuProviders.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProviders.IconColor = System.Drawing.Color.Black;
            this.subMenuProviders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProviders.Name = "subMenuProviders";
            this.subMenuProviders.Size = new System.Drawing.Size(180, 22);
            this.subMenuProviders.Text = "Proveedores";
            this.subMenuProviders.Click += new System.EventHandler(this.subMenuProviders_Click);
            // 
            // imiPurchases
            // 
            this.imiPurchases.AutoSize = false;
            this.imiPurchases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuPurchaseRegister,
            this.subMenuPurchaseDetail});
            this.imiPurchases.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.imiPurchases.IconColor = System.Drawing.Color.Black;
            this.imiPurchases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiPurchases.IconSize = 50;
            this.imiPurchases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiPurchases.Name = "imiPurchases";
            this.imiPurchases.Size = new System.Drawing.Size(90, 69);
            this.imiPurchases.Text = "Compras";
            this.imiPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuPurchaseRegister
            // 
            this.subMenuPurchaseRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPurchaseRegister.IconColor = System.Drawing.Color.Black;
            this.subMenuPurchaseRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPurchaseRegister.Name = "subMenuPurchaseRegister";
            this.subMenuPurchaseRegister.Size = new System.Drawing.Size(129, 22);
            this.subMenuPurchaseRegister.Text = "Registrar";
            this.subMenuPurchaseRegister.Click += new System.EventHandler(this.subMenuPurchaseRegister_Click);
            // 
            // subMenuPurchaseDetail
            // 
            this.subMenuPurchaseDetail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPurchaseDetail.IconColor = System.Drawing.Color.Black;
            this.subMenuPurchaseDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPurchaseDetail.Name = "subMenuPurchaseDetail";
            this.subMenuPurchaseDetail.Size = new System.Drawing.Size(129, 22);
            this.subMenuPurchaseDetail.Text = "Ver Detalle";
            this.subMenuPurchaseDetail.Click += new System.EventHandler(this.subMenuPurchaseDetail_Click);
            // 
            // imiClients
            // 
            this.imiClients.AutoSize = false;
            this.imiClients.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            this.imiClients.IconColor = System.Drawing.Color.Black;
            this.imiClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiClients.IconSize = 50;
            this.imiClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiClients.Name = "imiClients";
            this.imiClients.Size = new System.Drawing.Size(90, 69);
            this.imiClients.Text = "Clientes";
            this.imiClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiClients.Click += new System.EventHandler(this.imiClients_Click);
            // 
            // imiSales
            // 
            this.imiSales.AutoSize = false;
            this.imiSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuSaleRegister,
            this.subMenuSaleDetail});
            this.imiSales.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.imiSales.IconColor = System.Drawing.Color.Black;
            this.imiSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiSales.IconSize = 50;
            this.imiSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiSales.Name = "imiSales";
            this.imiSales.Size = new System.Drawing.Size(90, 69);
            this.imiSales.Text = "Ventas";
            this.imiSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuSaleRegister
            // 
            this.subMenuSaleRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSaleRegister.IconColor = System.Drawing.Color.Black;
            this.subMenuSaleRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSaleRegister.Name = "subMenuSaleRegister";
            this.subMenuSaleRegister.Size = new System.Drawing.Size(129, 22);
            this.subMenuSaleRegister.Text = "Registrar";
            this.subMenuSaleRegister.Click += new System.EventHandler(this.subMenuSaleRegister_Click);
            // 
            // subMenuSaleDetail
            // 
            this.subMenuSaleDetail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSaleDetail.IconColor = System.Drawing.Color.Black;
            this.subMenuSaleDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSaleDetail.Name = "subMenuSaleDetail";
            this.subMenuSaleDetail.Size = new System.Drawing.Size(129, 22);
            this.subMenuSaleDetail.Text = "Ver Detalle";
            this.subMenuSaleDetail.Click += new System.EventHandler(this.subMenuSaleDetail_Click);
            // 
            // imiReports
            // 
            this.imiReports.AutoSize = false;
            this.imiReports.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.imiReports.IconColor = System.Drawing.Color.Black;
            this.imiReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiReports.IconSize = 50;
            this.imiReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiReports.Name = "imiReports";
            this.imiReports.Size = new System.Drawing.Size(90, 69);
            this.imiReports.Text = "Reportes";
            this.imiReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiReports.Click += new System.EventHandler(this.imiReports_Click);
            // 
            // imiAbout
            // 
            this.imiAbout.AutoSize = false;
            this.imiAbout.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.imiAbout.IconColor = System.Drawing.Color.Black;
            this.imiAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiAbout.IconSize = 50;
            this.imiAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiAbout.Name = "imiAbout";
            this.imiAbout.Size = new System.Drawing.Size(90, 69);
            this.imiAbout.Text = "Averca de";
            this.imiAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = false;
            this.menuTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitle.Location = new System.Drawing.Point(0, 0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitle.Size = new System.Drawing.Size(1370, 51);
            this.menuTitle.TabIndex = 1;
            this.menuTitle.Text = "menuStrip2";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Sistema de Ventas";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 124);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1370, 507);
            this.pnlContainer.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(968, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 19);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Usuario";
            // 
            // subMenuBusinessData
            // 
            this.subMenuBusinessData.Name = "subMenuBusinessData";
            this.subMenuBusinessData.Size = new System.Drawing.Size(180, 22);
            this.subMenuBusinessData.Text = "Negocio";
            this.subMenuBusinessData.Click += new System.EventHandler(this.subMenuBusinessData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 631);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitle);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconMenuItem imiUsers;
        private FontAwesome.Sharp.IconMenuItem imiAdmin;
        private FontAwesome.Sharp.IconMenuItem imiPurchases;
        private FontAwesome.Sharp.IconMenuItem imiClients;
        private FontAwesome.Sharp.IconMenuItem imiSales;
        private FontAwesome.Sharp.IconMenuItem imiReports;
        private FontAwesome.Sharp.IconMenuItem imiAbout;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconMenuItem subMenuCategory;
        private FontAwesome.Sharp.IconMenuItem subMenuProducts;
        private FontAwesome.Sharp.IconMenuItem subMenuProviders;
        private FontAwesome.Sharp.IconMenuItem subMenuPurchaseRegister;
        private FontAwesome.Sharp.IconMenuItem subMenuPurchaseDetail;
        private FontAwesome.Sharp.IconMenuItem subMenuSaleRegister;
        private FontAwesome.Sharp.IconMenuItem subMenuSaleDetail;
        private System.Windows.Forms.ToolStripMenuItem subMenuBusinessData;
    }
}

