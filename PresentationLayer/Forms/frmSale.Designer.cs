
namespace PresentationLayer.Forms
{
    partial class frmSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMessage = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.grpbClientInfo = new System.Windows.Forms.GroupBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.ibtnSearchClient = new FontAwesome.Sharp.IconButton();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientDocument = new System.Windows.Forms.TextBox();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.grpbSaleInfo = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.pnlSale = new System.Windows.Forms.Panel();
            this.lblPayWith = new System.Windows.Forms.Label();
            this.txtPayWith = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.ibtnRegister = new FontAwesome.Sharp.IconButton();
            this.ibtnAdd = new FontAwesome.Sharp.IconButton();
            this.dgvSaleList = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpbProductInfo = new System.Windows.Forms.GroupBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.ibtnSearchProduct = new FontAwesome.Sharp.IconButton();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.grpbClientInfo.SuspendLayout();
            this.grpbSaleInfo.SuspendLayout();
            this.pnlSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).BeginInit();
            this.grpbProductInfo.SuspendLayout();
            this.SuspendLayout();
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
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(460, 40);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(102, 23);
            this.txtStock.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(460, 19);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(39, 15);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock:";
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
            // grpbClientInfo
            // 
            this.grpbClientInfo.Controls.Add(this.txtClientId);
            this.grpbClientInfo.Controls.Add(this.ibtnSearchClient);
            this.grpbClientInfo.Controls.Add(this.txtClientName);
            this.grpbClientInfo.Controls.Add(this.txtClientDocument);
            this.grpbClientInfo.Controls.Add(this.lblProviderName);
            this.grpbClientInfo.Controls.Add(this.lblDocument);
            this.grpbClientInfo.Location = new System.Drawing.Point(288, 38);
            this.grpbClientInfo.Name = "grpbClientInfo";
            this.grpbClientInfo.Size = new System.Drawing.Size(480, 80);
            this.grpbClientInfo.TabIndex = 4;
            this.grpbClientInfo.TabStop = false;
            this.grpbClientInfo.Text = "Información Cliente";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(429, 12);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(36, 23);
            this.txtClientId.TabIndex = 7;
            this.txtClientId.Text = "0";
            this.txtClientId.Visible = false;
            // 
            // ibtnSearchClient
            // 
            this.ibtnSearchClient.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnSearchClient.IconColor = System.Drawing.Color.Black;
            this.ibtnSearchClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearchClient.IconSize = 18;
            this.ibtnSearchClient.Location = new System.Drawing.Point(429, 41);
            this.ibtnSearchClient.Name = "ibtnSearchClient";
            this.ibtnSearchClient.Size = new System.Drawing.Size(36, 25);
            this.ibtnSearchClient.TabIndex = 6;
            this.ibtnSearchClient.UseVisualStyleBackColor = true;
            this.ibtnSearchClient.Click += new System.EventHandler(this.ibtnSearchClient_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(191, 41);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(232, 23);
            this.txtClientName.TabIndex = 5;
            // 
            // txtClientDocument
            // 
            this.txtClientDocument.Enabled = false;
            this.txtClientDocument.Location = new System.Drawing.Point(7, 41);
            this.txtClientDocument.Name = "txtClientDocument";
            this.txtClientDocument.Size = new System.Drawing.Size(178, 23);
            this.txtClientDocument.TabIndex = 4;
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
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(7, 23);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(96, 15);
            this.lblDocument.TabIndex = 0;
            this.lblDocument.Text = "Nro Documento:";
            // 
            // grpbSaleInfo
            // 
            this.grpbSaleInfo.Controls.Add(this.txtDate);
            this.grpbSaleInfo.Controls.Add(this.cmbDocumentType);
            this.grpbSaleInfo.Controls.Add(this.lblDate);
            this.grpbSaleInfo.Controls.Add(this.lblDocumentType);
            this.grpbSaleInfo.Location = new System.Drawing.Point(4, 38);
            this.grpbSaleInfo.Name = "grpbSaleInfo";
            this.grpbSaleInfo.Size = new System.Drawing.Size(278, 80);
            this.grpbSaleInfo.TabIndex = 1;
            this.grpbSaleInfo.TabStop = false;
            this.grpbSaleInfo.Text = "Información Venta";
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
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(567, 19);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 15);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Cantidad:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registrar Venta";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(352, 19);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(43, 15);
            this.lblSalePrice.TabIndex = 10;
            this.lblSalePrice.Text = "Precio:";
            // 
            // pnlSale
            // 
            this.pnlSale.BackColor = System.Drawing.Color.White;
            this.pnlSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSale.Controls.Add(this.lblPayWith);
            this.pnlSale.Controls.Add(this.txtPayWith);
            this.pnlSale.Controls.Add(this.lblChange);
            this.pnlSale.Controls.Add(this.txtChange);
            this.pnlSale.Controls.Add(this.lblTotal);
            this.pnlSale.Controls.Add(this.txtTotalPay);
            this.pnlSale.Controls.Add(this.ibtnRegister);
            this.pnlSale.Controls.Add(this.ibtnAdd);
            this.pnlSale.Controls.Add(this.dgvSaleList);
            this.pnlSale.Controls.Add(this.grpbProductInfo);
            this.pnlSale.Controls.Add(this.grpbClientInfo);
            this.pnlSale.Controls.Add(this.grpbSaleInfo);
            this.pnlSale.Controls.Add(this.lblTitle);
            this.pnlSale.Location = new System.Drawing.Point(69, 12);
            this.pnlSale.Name = "pnlSale";
            this.pnlSale.Size = new System.Drawing.Size(773, 475);
            this.pnlSale.TabIndex = 1;
            // 
            // lblPayWith
            // 
            this.lblPayWith.AutoSize = true;
            this.lblPayWith.Location = new System.Drawing.Point(688, 341);
            this.lblPayWith.Name = "lblPayWith";
            this.lblPayWith.Size = new System.Drawing.Size(59, 15);
            this.lblPayWith.TabIndex = 14;
            this.lblPayWith.Text = "Paga con:";
            // 
            // txtPayWith
            // 
            this.txtPayWith.Location = new System.Drawing.Point(688, 359);
            this.txtPayWith.Name = "txtPayWith";
            this.txtPayWith.Size = new System.Drawing.Size(80, 23);
            this.txtPayWith.TabIndex = 13;
            this.txtPayWith.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayWith_KeyDown);
            this.txtPayWith.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayWith_KeyPress);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(688, 389);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(52, 15);
            this.lblChange.TabIndex = 12;
            this.lblChange.Text = "Cambio:";
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(688, 407);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(80, 23);
            this.txtChange.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(688, 285);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 15);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(688, 303);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(80, 23);
            this.txtTotalPay.TabIndex = 9;
            this.txtTotalPay.Text = "0";
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
            // dgvSaleList
            // 
            this.dgvSaleList.AllowUserToAddRows = false;
            this.dgvSaleList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.Product,
            this.SalePrice,
            this.Amount,
            this.SubTotal,
            this.Delete});
            this.dgvSaleList.Location = new System.Drawing.Point(4, 233);
            this.dgvSaleList.Name = "dgvSaleList";
            this.dgvSaleList.RowTemplate.Height = 25;
            this.dgvSaleList.Size = new System.Drawing.Size(678, 237);
            this.dgvSaleList.TabIndex = 6;
            this.dgvSaleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleList_CellContentClick);
            this.dgvSaleList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSaleList_CellPainting);
            // 
            // IdProduct
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdProduct.HeaderText = "IdProduct";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Visible = false;
            // 
            // Product
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.Width = 235;
            // 
            // SalePrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SalePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalePrice.HeaderText = "Precio";
            this.SalePrice.Name = "SalePrice";
            // 
            // Amount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.HeaderText = "Cantidad";
            this.Amount.Name = "Amount";
            // 
            // SubTotal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.grpbProductInfo.Controls.Add(this.txtStock);
            this.grpbProductInfo.Controls.Add(this.lblStock);
            this.grpbProductInfo.Controls.Add(this.lblSalePrice);
            this.grpbProductInfo.Controls.Add(this.txtSalePrice);
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
            // txtSalePrice
            // 
            this.txtSalePrice.Enabled = false;
            this.txtSalePrice.Location = new System.Drawing.Point(352, 40);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(102, 23);
            this.txtSalePrice.TabIndex = 8;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
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
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 523);
            this.Controls.Add(this.pnlSale);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.grpbClientInfo.ResumeLayout(false);
            this.grpbClientInfo.PerformLayout();
            this.grpbSaleInfo.ResumeLayout(false);
            this.grpbSaleInfo.PerformLayout();
            this.pnlSale.ResumeLayout(false);
            this.pnlSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).EndInit();
            this.grpbProductInfo.ResumeLayout(false);
            this.grpbProductInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.GroupBox grpbClientInfo;
        private System.Windows.Forms.TextBox txtClientId;
        private FontAwesome.Sharp.IconButton ibtnSearchClient;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientDocument;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.GroupBox grpbSaleInfo;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Panel pnlSale;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalPay;
        private FontAwesome.Sharp.IconButton ibtnRegister;
        private FontAwesome.Sharp.IconButton ibtnAdd;
        private System.Windows.Forms.DataGridView dgvSaleList;
        private System.Windows.Forms.GroupBox grpbProductInfo;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtProductId;
        private FontAwesome.Sharp.IconButton ibtnSearchProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblPayWith;
        private System.Windows.Forms.TextBox txtPayWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}