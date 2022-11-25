
namespace PresentationLayer.Forms
{
    partial class frmPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPurchase = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.ibtnRegister = new FontAwesome.Sharp.IconButton();
            this.ibtnAdd = new FontAwesome.Sharp.IconButton();
            this.dgvPurchaseList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpbProductInfo = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.ibtnSearchProduct = new FontAwesome.Sharp.IconButton();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.grpbProviderInfo = new System.Windows.Forms.GroupBox();
            this.txtProviderId = new System.Windows.Forms.TextBox();
            this.ibtnSearchProvider = new FontAwesome.Sharp.IconButton();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.txtProviderNit = new System.Windows.Forms.TextBox();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.lblProviderNit = new System.Windows.Forms.Label();
            this.grpBoxPurchaseInfo = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.grpbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.grpbProviderInfo.SuspendLayout();
            this.grpBoxPurchaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPurchase
            // 
            this.pnlPurchase.BackColor = System.Drawing.Color.White;
            this.pnlPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPurchase.Controls.Add(this.lblTotal);
            this.pnlPurchase.Controls.Add(this.txtTotalPay);
            this.pnlPurchase.Controls.Add(this.ibtnRegister);
            this.pnlPurchase.Controls.Add(this.ibtnAdd);
            this.pnlPurchase.Controls.Add(this.dgvPurchaseList);
            this.pnlPurchase.Controls.Add(this.grpbProductInfo);
            this.pnlPurchase.Controls.Add(this.grpbProviderInfo);
            this.pnlPurchase.Controls.Add(this.grpBoxPurchaseInfo);
            this.pnlPurchase.Controls.Add(this.lblTitle);
            this.pnlPurchase.Location = new System.Drawing.Point(43, 12);
            this.pnlPurchase.Name = "pnlPurchase";
            this.pnlPurchase.Size = new System.Drawing.Size(773, 475);
            this.pnlPurchase.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(688, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 15);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(688, 406);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(80, 23);
            this.txtTotalPay.TabIndex = 9;
            // 
            // ibtnRegister
            // 
            this.ibtnRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnRegister.IconColor = System.Drawing.Color.Black;
            this.ibtnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegister.Location = new System.Drawing.Point(688, 435);
            this.ibtnRegister.Name = "ibtnRegister";
            this.ibtnRegister.Size = new System.Drawing.Size(80, 35);
            this.ibtnRegister.TabIndex = 8;
            this.ibtnRegister.Text = "Registrar";
            this.ibtnRegister.UseVisualStyleBackColor = true;
            this.ibtnRegister.Click += new System.EventHandler(this.ibtnRegister_Click);
            // 
            // ibtnAdd
            // 
            this.ibtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAdd.IconColor = System.Drawing.Color.DarkGreen;
            this.ibtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdd.Location = new System.Drawing.Point(688, 132);
            this.ibtnAdd.Name = "ibtnAdd";
            this.ibtnAdd.Size = new System.Drawing.Size(80, 95);
            this.ibtnAdd.TabIndex = 7;
            this.ibtnAdd.Text = "Agregar";
            this.ibtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnAdd.UseVisualStyleBackColor = true;
            this.ibtnAdd.Click += new System.EventHandler(this.ibtnAdd_Click);
            // 
            // dgvPurchaseList
            // 
            this.dgvPurchaseList.AllowUserToAddRows = false;
            this.dgvPurchaseList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.PurchasePrice,
            this.SalePrice,
            this.Amount,
            this.SubTotal,
            this.Delete});
            this.dgvPurchaseList.Location = new System.Drawing.Point(4, 233);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.RowTemplate.Height = 25;
            this.dgvPurchaseList.Size = new System.Drawing.Size(678, 237);
            this.dgvPurchaseList.TabIndex = 6;
            this.dgvPurchaseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseList_CellContentClick);
            this.dgvPurchaseList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPurchaseList_CellPainting);
            // 
            // Id
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle6;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Product
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle7;
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.Width = 235;
            // 
            // PurchasePrice
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.PurchasePrice.HeaderText = "Precio Compra";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "Precio Venta";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Visible = false;
            // 
            // Amount
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle9;
            this.Amount.HeaderText = "Cantidad";
            this.Amount.Name = "Amount";
            // 
            // SubTotal
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            // 
            // grpbProductInfo
            // 
            this.grpbProductInfo.Controls.Add(this.lblMessage);
            this.grpbProductInfo.Controls.Add(this.nudAmount);
            this.grpbProductInfo.Controls.Add(this.lblAmount);
            this.grpbProductInfo.Controls.Add(this.txtSalePrice);
            this.grpbProductInfo.Controls.Add(this.lblSalePrice);
            this.grpbProductInfo.Controls.Add(this.lblPurchasePrice);
            this.grpbProductInfo.Controls.Add(this.txtPurchasePrice);
            this.grpbProductInfo.Controls.Add(this.txtProductId);
            this.grpbProductInfo.Controls.Add(this.ibtnSearchProduct);
            this.grpbProductInfo.Controls.Add(this.txtProductName);
            this.grpbProductInfo.Controls.Add(this.txtProductCode);
            this.grpbProductInfo.Controls.Add(this.lblProductName);
            this.grpbProductInfo.Controls.Add(this.lblProductCode);
            this.grpbProductInfo.Location = new System.Drawing.Point(4, 124);
            this.grpbProductInfo.Name = "grpbProductInfo";
            this.grpbProductInfo.Size = new System.Drawing.Size(678, 103);
            this.grpbProductInfo.TabIndex = 5;
            this.grpbProductInfo.TabStop = false;
            this.grpbProductInfo.Text = "Información de Producto";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(7, 82);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 15;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(569, 39);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(73, 23);
            this.nudAmount.TabIndex = 14;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(567, 19);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 15);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Cantidad:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(460, 40);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(102, 23);
            this.txtSalePrice.TabIndex = 12;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(460, 19);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(75, 15);
            this.lblSalePrice.TabIndex = 11;
            this.lblSalePrice.Text = "Precio Venta:";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(352, 19);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(89, 15);
            this.lblPurchasePrice.TabIndex = 10;
            this.lblPurchasePrice.Text = "Precio Compra:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(352, 40);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(102, 23);
            this.txtPurchasePrice.TabIndex = 8;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(310, 11);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(36, 23);
            this.txtProductId.TabIndex = 7;
            this.txtProductId.Text = "0";
            this.txtProductId.Visible = false;
            // 
            // ibtnSearchProduct
            // 
            this.ibtnSearchProduct.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnSearchProduct.IconColor = System.Drawing.Color.Black;
            this.ibtnSearchProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearchProduct.IconSize = 18;
            this.ibtnSearchProduct.Location = new System.Drawing.Point(310, 39);
            this.ibtnSearchProduct.Name = "ibtnSearchProduct";
            this.ibtnSearchProduct.Size = new System.Drawing.Size(36, 25);
            this.ibtnSearchProduct.TabIndex = 6;
            this.ibtnSearchProduct.UseVisualStyleBackColor = true;
            this.ibtnSearchProduct.Click += new System.EventHandler(this.ibtnSearchProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(134, 41);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(170, 23);
            this.txtProductName.TabIndex = 5;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(7, 41);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(121, 23);
            this.txtProductCode.TabIndex = 4;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(134, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 15);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Producto:";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(7, 23);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(101, 15);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Codigo Producto:";
            // 
            // grpbProviderInfo
            // 
            this.grpbProviderInfo.Controls.Add(this.txtProviderId);
            this.grpbProviderInfo.Controls.Add(this.ibtnSearchProvider);
            this.grpbProviderInfo.Controls.Add(this.txtProviderName);
            this.grpbProviderInfo.Controls.Add(this.txtProviderNit);
            this.grpbProviderInfo.Controls.Add(this.lblProviderName);
            this.grpbProviderInfo.Controls.Add(this.lblProviderNit);
            this.grpbProviderInfo.Location = new System.Drawing.Point(288, 38);
            this.grpbProviderInfo.Name = "grpbProviderInfo";
            this.grpbProviderInfo.Size = new System.Drawing.Size(480, 80);
            this.grpbProviderInfo.TabIndex = 4;
            this.grpbProviderInfo.TabStop = false;
            this.grpbProviderInfo.Text = "Información Proveedor";
            // 
            // txtProviderId
            // 
            this.txtProviderId.Location = new System.Drawing.Point(429, 12);
            this.txtProviderId.Name = "txtProviderId";
            this.txtProviderId.Size = new System.Drawing.Size(36, 23);
            this.txtProviderId.TabIndex = 7;
            this.txtProviderId.Text = "0";
            this.txtProviderId.Visible = false;
            // 
            // ibtnSearchProvider
            // 
            this.ibtnSearchProvider.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnSearchProvider.IconColor = System.Drawing.Color.Black;
            this.ibtnSearchProvider.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearchProvider.IconSize = 18;
            this.ibtnSearchProvider.Location = new System.Drawing.Point(429, 41);
            this.ibtnSearchProvider.Name = "ibtnSearchProvider";
            this.ibtnSearchProvider.Size = new System.Drawing.Size(36, 25);
            this.ibtnSearchProvider.TabIndex = 6;
            this.ibtnSearchProvider.UseVisualStyleBackColor = true;
            this.ibtnSearchProvider.Click += new System.EventHandler(this.ibtnSearchProvider_Click);
            // 
            // txtProviderName
            // 
            this.txtProviderName.Enabled = false;
            this.txtProviderName.Location = new System.Drawing.Point(191, 41);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(232, 23);
            this.txtProviderName.TabIndex = 5;
            // 
            // txtProviderNit
            // 
            this.txtProviderNit.Enabled = false;
            this.txtProviderNit.Location = new System.Drawing.Point(7, 41);
            this.txtProviderNit.Name = "txtProviderNit";
            this.txtProviderNit.Size = new System.Drawing.Size(178, 23);
            this.txtProviderNit.TabIndex = 4;
            // 
            // lblProviderName
            // 
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Location = new System.Drawing.Point(191, 23);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(54, 15);
            this.lblProviderName.TabIndex = 1;
            this.lblProviderName.Text = "Nombre:";
            // 
            // lblProviderNit
            // 
            this.lblProviderNit.AutoSize = true;
            this.lblProviderNit.Location = new System.Drawing.Point(7, 23);
            this.lblProviderNit.Name = "lblProviderNit";
            this.lblProviderNit.Size = new System.Drawing.Size(28, 15);
            this.lblProviderNit.TabIndex = 0;
            this.lblProviderNit.Text = "NIT:";
            // 
            // grpBoxPurchaseInfo
            // 
            this.grpBoxPurchaseInfo.Controls.Add(this.txtDate);
            this.grpBoxPurchaseInfo.Controls.Add(this.cmbDocumentType);
            this.grpBoxPurchaseInfo.Controls.Add(this.lblDate);
            this.grpBoxPurchaseInfo.Controls.Add(this.lblDocumentType);
            this.grpBoxPurchaseInfo.Location = new System.Drawing.Point(4, 38);
            this.grpBoxPurchaseInfo.Name = "grpBoxPurchaseInfo";
            this.grpBoxPurchaseInfo.Size = new System.Drawing.Size(278, 80);
            this.grpBoxPurchaseInfo.TabIndex = 1;
            this.grpBoxPurchaseInfo.TabStop = false;
            this.grpBoxPurchaseInfo.Text = "Información Compra";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(143, 41);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(119, 23);
            this.txtDate.TabIndex = 3;
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.Enabled = false;
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(7, 42);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(130, 23);
            this.cmbDocumentType.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(143, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Fecha:";
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(7, 23);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(99, 15);
            this.lblDocumentType.TabIndex = 0;
            this.lblDocumentType.Text = "Tipo Documento:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registrar Compra";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 499);
            this.Controls.Add(this.pnlPurchase);
            this.Name = "frmPurchase";
            this.Text = "frmPurchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.pnlPurchase.ResumeLayout(false);
            this.pnlPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.grpbProductInfo.ResumeLayout(false);
            this.grpbProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.grpbProviderInfo.ResumeLayout(false);
            this.grpbProviderInfo.PerformLayout();
            this.grpBoxPurchaseInfo.ResumeLayout(false);
            this.grpBoxPurchaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPurchase;
        private System.Windows.Forms.GroupBox grpBoxPurchaseInfo;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpbProductInfo;
        private System.Windows.Forms.TextBox txtProductId;
        private FontAwesome.Sharp.IconButton ibtnSearchProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.GroupBox grpbProviderInfo;
        private System.Windows.Forms.TextBox txtProviderId;
        private FontAwesome.Sharp.IconButton ibtnSearchProvider;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.TextBox txtProviderNit;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.Label lblProviderNit;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.DataGridView dgvPurchaseList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalPay;
        private FontAwesome.Sharp.IconButton ibtnRegister;
        private FontAwesome.Sharp.IconButton ibtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblMessage;
    }
}