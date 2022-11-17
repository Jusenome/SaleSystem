
namespace PresentationLayer.Forms
{
    partial class frmPurchaseDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPurchaseDetail = new System.Windows.Forms.Panel();
            this.ibtnDownload = new FontAwesome.Sharp.IconButton();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvPurchaseList = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbProviderInfo = new System.Windows.Forms.GroupBox();
            this.txtInvoiceInGrpProvider = new System.Windows.Forms.TextBox();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.grpbPurchaseInfo = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDocumentType = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ibtnClean = new FontAwesome.Sharp.IconButton();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSerarch = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPurchaseDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.grpbProviderInfo.SuspendLayout();
            this.grpbPurchaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPurchaseDetail
            // 
            this.pnlPurchaseDetail.BackColor = System.Drawing.Color.White;
            this.pnlPurchaseDetail.Controls.Add(this.ibtnDownload);
            this.pnlPurchaseDetail.Controls.Add(this.txtTotalPay);
            this.pnlPurchaseDetail.Controls.Add(this.lblTotal);
            this.pnlPurchaseDetail.Controls.Add(this.dgvPurchaseList);
            this.pnlPurchaseDetail.Controls.Add(this.grpbProviderInfo);
            this.pnlPurchaseDetail.Controls.Add(this.grpbPurchaseInfo);
            this.pnlPurchaseDetail.Controls.Add(this.ibtnClean);
            this.pnlPurchaseDetail.Controls.Add(this.ibtnSearch);
            this.pnlPurchaseDetail.Controls.Add(this.txtSerarch);
            this.pnlPurchaseDetail.Controls.Add(this.lblInvoiceNumber);
            this.pnlPurchaseDetail.Controls.Add(this.lblTitle);
            this.pnlPurchaseDetail.Location = new System.Drawing.Point(158, 10);
            this.pnlPurchaseDetail.Name = "pnlPurchaseDetail";
            this.pnlPurchaseDetail.Size = new System.Drawing.Size(614, 489);
            this.pnlPurchaseDetail.TabIndex = 0;
            // 
            // ibtnDownload
            // 
            this.ibtnDownload.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnDownload.IconColor = System.Drawing.Color.Black;
            this.ibtnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDownload.IconSize = 20;
            this.ibtnDownload.Location = new System.Drawing.Point(479, 448);
            this.ibtnDownload.Name = "ibtnDownload";
            this.ibtnDownload.Size = new System.Drawing.Size(129, 34);
            this.ibtnDownload.TabIndex = 10;
            this.ibtnDownload.Text = "Descargar PDF";
            this.ibtnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDownload.UseVisualStyleBackColor = true;
            this.ibtnDownload.Click += new System.EventHandler(this.ibtnDownload_Click);
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(48, 455);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(97, 23);
            this.txtTotalPay.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 458);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // dgvPurchaseList
            // 
            this.dgvPurchaseList.AllowUserToAddRows = false;
            this.dgvPurchaseList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.PurchasePrice,
            this.Amount,
            this.Subtotal});
            this.dgvPurchaseList.Location = new System.Drawing.Point(7, 234);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.RowTemplate.Height = 25;
            this.dgvPurchaseList.Size = new System.Drawing.Size(601, 208);
            this.dgvPurchaseList.TabIndex = 7;
            // 
            // Product
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle1;
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.Width = 200;
            // 
            // PurchasePrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurchasePrice.HeaderText = "Precio Compra";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Width = 130;
            // 
            // Amount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.HeaderText = "Cantidad";
            this.Amount.Name = "Amount";
            // 
            // Subtotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Subtotal.HeaderText = "Sub Total";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 130;
            // 
            // grpbProviderInfo
            // 
            this.grpbProviderInfo.Controls.Add(this.txtInvoiceInGrpProvider);
            this.grpbProviderInfo.Controls.Add(this.txtProviderName);
            this.grpbProviderInfo.Controls.Add(this.txtNit);
            this.grpbProviderInfo.Controls.Add(this.lblProviderName);
            this.grpbProviderInfo.Controls.Add(this.lblNit);
            this.grpbProviderInfo.Location = new System.Drawing.Point(7, 150);
            this.grpbProviderInfo.Name = "grpbProviderInfo";
            this.grpbProviderInfo.Size = new System.Drawing.Size(601, 78);
            this.grpbProviderInfo.TabIndex = 6;
            this.grpbProviderInfo.TabStop = false;
            this.grpbProviderInfo.Text = " Información Proveedor";
            // 
            // txtInvoiceInGrpProvider
            // 
            this.txtInvoiceInGrpProvider.Enabled = false;
            this.txtInvoiceInGrpProvider.Location = new System.Drawing.Point(472, 42);
            this.txtInvoiceInGrpProvider.Name = "txtInvoiceInGrpProvider";
            this.txtInvoiceInGrpProvider.Size = new System.Drawing.Size(127, 23);
            this.txtInvoiceInGrpProvider.TabIndex = 5;
            this.txtInvoiceInGrpProvider.Visible = false;
            // 
            // txtProviderName
            // 
            this.txtProviderName.Enabled = false;
            this.txtProviderName.Location = new System.Drawing.Point(217, 42);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(206, 23);
            this.txtProviderName.TabIndex = 4;
            // 
            // txtNit
            // 
            this.txtNit.Enabled = false;
            this.txtNit.Location = new System.Drawing.Point(7, 42);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(204, 23);
            this.txtNit.TabIndex = 3;
            // 
            // lblProviderName
            // 
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Location = new System.Drawing.Point(217, 23);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(51, 15);
            this.lblProviderName.TabIndex = 1;
            this.lblProviderName.Text = "Nombre";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(7, 23);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(26, 15);
            this.lblNit.TabIndex = 0;
            this.lblNit.Text = "Nit:";
            // 
            // grpbPurchaseInfo
            // 
            this.grpbPurchaseInfo.Controls.Add(this.txtUser);
            this.grpbPurchaseInfo.Controls.Add(this.txtDocumentType);
            this.grpbPurchaseInfo.Controls.Add(this.txtDate);
            this.grpbPurchaseInfo.Controls.Add(this.lblUser);
            this.grpbPurchaseInfo.Controls.Add(this.lblDocumentType);
            this.grpbPurchaseInfo.Controls.Add(this.lblDate);
            this.grpbPurchaseInfo.Location = new System.Drawing.Point(5, 66);
            this.grpbPurchaseInfo.Name = "grpbPurchaseInfo";
            this.grpbPurchaseInfo.Size = new System.Drawing.Size(603, 78);
            this.grpbPurchaseInfo.TabIndex = 5;
            this.grpbPurchaseInfo.TabStop = false;
            this.grpbPurchaseInfo.Text = " Información Compra";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(375, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(225, 23);
            this.txtUser.TabIndex = 5;
            // 
            // txtDocumentType
            // 
            this.txtDocumentType.Enabled = false;
            this.txtDocumentType.Location = new System.Drawing.Point(180, 42);
            this.txtDocumentType.Name = "txtDocumentType";
            this.txtDocumentType.Size = new System.Drawing.Size(179, 23);
            this.txtDocumentType.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(7, 42);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(159, 23);
            this.txtDate.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(375, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuario:";
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(180, 23);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(102, 15);
            this.lblDocumentType.TabIndex = 1;
            this.lblDocumentType.Text = " Tipo Documento:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(7, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Fecha:";
            // 
            // ibtnClean
            // 
            this.ibtnClean.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnClean.IconColor = System.Drawing.Color.Black;
            this.ibtnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClean.Location = new System.Drawing.Point(533, 37);
            this.ibtnClean.Name = "ibtnClean";
            this.ibtnClean.Size = new System.Drawing.Size(75, 23);
            this.ibtnClean.TabIndex = 4;
            this.ibtnClean.Text = "Limpiar";
            this.ibtnClean.UseVisualStyleBackColor = true;
            this.ibtnClean.Click += new System.EventHandler(this.ibtnClean_Click);
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnSearch.IconColor = System.Drawing.Color.Black;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.IconSize = 20;
            this.ibtnSearch.Location = new System.Drawing.Point(452, 37);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(75, 23);
            this.ibtnSearch.TabIndex = 3;
            this.ibtnSearch.Text = "Buscar";
            this.ibtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSearch.UseVisualStyleBackColor = true;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // txtSerarch
            // 
            this.txtSerarch.Location = new System.Drawing.Point(335, 37);
            this.txtSerarch.Name = "txtSerarch";
            this.txtSerarch.Size = new System.Drawing.Size(111, 23);
            this.txtSerarch.TabIndex = 2;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(260, 41);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(69, 15);
            this.lblInvoiceNumber.TabIndex = 1;
            this.lblInvoiceNumber.Text = "Nro Factura";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(5, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detalle Compra";
            // 
            // frmPurchaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 510);
            this.Controls.Add(this.pnlPurchaseDetail);
            this.Name = "frmPurchaseDetail";
            this.Text = "frmPurchaseDetail";
            this.pnlPurchaseDetail.ResumeLayout(false);
            this.pnlPurchaseDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.grpbProviderInfo.ResumeLayout(false);
            this.grpbProviderInfo.PerformLayout();
            this.grpbPurchaseInfo.ResumeLayout(false);
            this.grpbPurchaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPurchaseDetail;
        private FontAwesome.Sharp.IconButton ibtnClean;
        private FontAwesome.Sharp.IconButton ibtnSearch;
        private System.Windows.Forms.TextBox txtSerarch;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpbPurchaseInfo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDocumentType;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lblDate;
        private FontAwesome.Sharp.IconButton ibtnDownload;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvPurchaseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.GroupBox grpbProviderInfo;
        private System.Windows.Forms.TextBox txtInvoiceInGrpProvider;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.Label lblNit;
    }
}