
namespace PresentationLayer.Forms
{
    partial class frmSaleDetail
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
            this.ibtnClean = new FontAwesome.Sharp.IconButton();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSerarch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDocumentType = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtInvoiceInGrpProvider = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientDocument = new System.Windows.Forms.TextBox();
            this.grpbPurchaseInfo = new System.Windows.Forms.GroupBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.grpbClientInfo = new System.Windows.Forms.GroupBox();
            this.lblClientDocument = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.ibtnDownload = new FontAwesome.Sharp.IconButton();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvSaleList = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSaleDetail = new System.Windows.Forms.Panel();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtPayWith = new System.Windows.Forms.TextBox();
            this.lblPayWith = new System.Windows.Forms.Label();
            this.grpbPurchaseInfo.SuspendLayout();
            this.grpbClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).BeginInit();
            this.pnlSaleDetail.SuspendLayout();
            this.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(5, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detalle Venta";
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
            // txtInvoiceInGrpProvider
            // 
            this.txtInvoiceInGrpProvider.Enabled = false;
            this.txtInvoiceInGrpProvider.Location = new System.Drawing.Point(472, 42);
            this.txtInvoiceInGrpProvider.Name = "txtInvoiceInGrpProvider";
            this.txtInvoiceInGrpProvider.Size = new System.Drawing.Size(127, 23);
            this.txtInvoiceInGrpProvider.TabIndex = 5;
            this.txtInvoiceInGrpProvider.Visible = false;
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(217, 42);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(206, 23);
            this.txtClientName.TabIndex = 4;
            // 
            // txtClientDocument
            // 
            this.txtClientDocument.Enabled = false;
            this.txtClientDocument.Location = new System.Drawing.Point(7, 42);
            this.txtClientDocument.Name = "txtClientDocument";
            this.txtClientDocument.Size = new System.Drawing.Size(204, 23);
            this.txtClientDocument.TabIndex = 3;
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
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(217, 23);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(54, 15);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Nombre:";
            // 
            // grpbClientInfo
            // 
            this.grpbClientInfo.Controls.Add(this.txtInvoiceInGrpProvider);
            this.grpbClientInfo.Controls.Add(this.txtClientName);
            this.grpbClientInfo.Controls.Add(this.txtClientDocument);
            this.grpbClientInfo.Controls.Add(this.lblClientName);
            this.grpbClientInfo.Controls.Add(this.lblClientDocument);
            this.grpbClientInfo.Location = new System.Drawing.Point(7, 150);
            this.grpbClientInfo.Name = "grpbClientInfo";
            this.grpbClientInfo.Size = new System.Drawing.Size(601, 78);
            this.grpbClientInfo.TabIndex = 6;
            this.grpbClientInfo.TabStop = false;
            this.grpbClientInfo.Text = " Información Cliente";
            // 
            // lblClientDocument
            // 
            this.lblClientDocument.AutoSize = true;
            this.lblClientDocument.Location = new System.Drawing.Point(7, 23);
            this.lblClientDocument.Name = "lblClientDocument";
            this.lblClientDocument.Size = new System.Drawing.Size(73, 15);
            this.lblClientDocument.TabIndex = 0;
            this.lblClientDocument.Text = "Documento:";
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
            // ibtnDownload
            // 
            this.ibtnDownload.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnDownload.IconColor = System.Drawing.Color.Black;
            this.ibtnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDownload.IconSize = 20;
            this.ibtnDownload.Location = new System.Drawing.Point(497, 448);
            this.ibtnDownload.Name = "ibtnDownload";
            this.ibtnDownload.Size = new System.Drawing.Size(111, 34);
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
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // dgvSaleList
            // 
            this.dgvSaleList.AllowUserToAddRows = false;
            this.dgvSaleList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.SalePrice,
            this.Amount,
            this.Subtotal});
            this.dgvSaleList.Location = new System.Drawing.Point(7, 234);
            this.dgvSaleList.Name = "dgvSaleList";
            this.dgvSaleList.RowTemplate.Height = 25;
            this.dgvSaleList.Size = new System.Drawing.Size(601, 208);
            this.dgvSaleList.TabIndex = 7;
            // 
            // Product
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle1;
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.Width = 200;
            // 
            // SalePrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SalePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalePrice.HeaderText = "Precio";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Width = 130;
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
            // pnlSaleDetail
            // 
            this.pnlSaleDetail.BackColor = System.Drawing.Color.White;
            this.pnlSaleDetail.Controls.Add(this.txtChange);
            this.pnlSaleDetail.Controls.Add(this.lblChange);
            this.pnlSaleDetail.Controls.Add(this.txtPayWith);
            this.pnlSaleDetail.Controls.Add(this.lblPayWith);
            this.pnlSaleDetail.Controls.Add(this.ibtnDownload);
            this.pnlSaleDetail.Controls.Add(this.txtTotalPay);
            this.pnlSaleDetail.Controls.Add(this.lblTotal);
            this.pnlSaleDetail.Controls.Add(this.dgvSaleList);
            this.pnlSaleDetail.Controls.Add(this.grpbClientInfo);
            this.pnlSaleDetail.Controls.Add(this.grpbPurchaseInfo);
            this.pnlSaleDetail.Controls.Add(this.ibtnClean);
            this.pnlSaleDetail.Controls.Add(this.ibtnSearch);
            this.pnlSaleDetail.Controls.Add(this.txtSerarch);
            this.pnlSaleDetail.Controls.Add(this.lblInvoiceNumber);
            this.pnlSaleDetail.Controls.Add(this.lblTitle);
            this.pnlSaleDetail.Location = new System.Drawing.Point(153, 12);
            this.pnlSaleDetail.Name = "pnlSaleDetail";
            this.pnlSaleDetail.Size = new System.Drawing.Size(614, 489);
            this.pnlSaleDetail.TabIndex = 1;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(379, 455);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(97, 23);
            this.txtChange.TabIndex = 14;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(323, 458);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(52, 15);
            this.lblChange.TabIndex = 13;
            this.lblChange.Text = "Cambio:";
            // 
            // txtPayWith
            // 
            this.txtPayWith.Location = new System.Drawing.Point(215, 455);
            this.txtPayWith.Name = "txtPayWith";
            this.txtPayWith.Size = new System.Drawing.Size(97, 23);
            this.txtPayWith.TabIndex = 12;
            // 
            // lblPayWith
            // 
            this.lblPayWith.AutoSize = true;
            this.lblPayWith.Location = new System.Drawing.Point(154, 458);
            this.lblPayWith.Name = "lblPayWith";
            this.lblPayWith.Size = new System.Drawing.Size(59, 15);
            this.lblPayWith.TabIndex = 11;
            this.lblPayWith.Text = "Paga con:";
            // 
            // frmSaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 526);
            this.Controls.Add(this.pnlSaleDetail);
            this.Name = "frmSaleDetail";
            this.Text = "frmSaleDetail";
            this.grpbPurchaseInfo.ResumeLayout(false);
            this.grpbPurchaseInfo.PerformLayout();
            this.grpbClientInfo.ResumeLayout(false);
            this.grpbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).EndInit();
            this.pnlSaleDetail.ResumeLayout(false);
            this.pnlSaleDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnClean;
        private FontAwesome.Sharp.IconButton ibtnSearch;
        private System.Windows.Forms.TextBox txtSerarch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDocumentType;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtInvoiceInGrpProvider;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientDocument;
        private System.Windows.Forms.GroupBox grpbPurchaseInfo;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.GroupBox grpbClientInfo;
        private System.Windows.Forms.Label lblClientDocument;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private FontAwesome.Sharp.IconButton ibtnDownload;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvSaleList;
        private System.Windows.Forms.Panel pnlSaleDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtPayWith;
        private System.Windows.Forms.Label lblPayWith;
    }
}