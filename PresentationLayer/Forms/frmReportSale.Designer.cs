
namespace PresentationLayer.Forms
{
    partial class frmReportSale
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.ibtnExport = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.dtpFinalDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinalDate = new System.Windows.Forms.Label();
            this.dtpInitialDate = new System.Windows.Forms.DateTimePicker();
            this.lblInitialDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.DocumentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1096, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 23);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(938, 14);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(152, 23);
            this.cmbSearchBy.TabIndex = 22;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(853, 16);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(66, 15);
            this.lblSearchBy.TabIndex = 21;
            this.lblSearchBy.Text = "Buscar Por:";
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
            this.ibtnExport.Location = new System.Drawing.Point(16, 12);
            this.ibtnExport.Name = "ibtnExport";
            this.ibtnExport.Size = new System.Drawing.Size(118, 23);
            this.ibtnExport.TabIndex = 20;
            this.ibtnExport.Text = "Exportar";
            this.ibtnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnExport.UseVisualStyleBackColor = false;
            this.ibtnExport.Click += new System.EventHandler(this.ibtnExport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cmbSearchBy);
            this.panel1.Controls.Add(this.lblSearchBy);
            this.panel1.Controls.Add(this.ibtnExport);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(11, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 429);
            this.panel1.TabIndex = 5;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentType,
            this.InvoceNumber,
            this.User,
            this.ClientDocument,
            this.ClientName,
            this.ProductCode,
            this.ProductName,
            this.Category,
            this.SalePrice,
            this.Quantity,
            this.SubTotal,
            this.CreatedDate});
            this.dgvList.Location = new System.Drawing.Point(16, 56);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 25;
            this.dgvList.Size = new System.Drawing.Size(1245, 357);
            this.dgvList.TabIndex = 0;
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnSearch.IconColor = System.Drawing.Color.Black;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.IconSize = 20;
            this.ibtnSearch.Location = new System.Drawing.Point(467, 54);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(75, 23);
            this.ibtnSearch.TabIndex = 7;
            this.ibtnSearch.Text = "Buscar";
            this.ibtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSearch.UseVisualStyleBackColor = true;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // dtpFinalDate
            // 
            this.dtpFinalDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFinalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinalDate.Location = new System.Drawing.Point(343, 56);
            this.dtpFinalDate.Name = "dtpFinalDate";
            this.dtpFinalDate.Size = new System.Drawing.Size(102, 23);
            this.dtpFinalDate.TabIndex = 4;
            // 
            // lblFinalDate
            // 
            this.lblFinalDate.AutoSize = true;
            this.lblFinalDate.Location = new System.Drawing.Point(252, 62);
            this.lblFinalDate.Name = "lblFinalDate";
            this.lblFinalDate.Size = new System.Drawing.Size(69, 15);
            this.lblFinalDate.TabIndex = 3;
            this.lblFinalDate.Text = "Fecha Final:";
            // 
            // dtpInitialDate
            // 
            this.dtpInitialDate.CustomFormat = "yyyy-MM-dd";
            this.dtpInitialDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitialDate.Location = new System.Drawing.Point(107, 56);
            this.dtpInitialDate.Name = "dtpInitialDate";
            this.dtpInitialDate.Size = new System.Drawing.Size(102, 23);
            this.dtpInitialDate.TabIndex = 2;
            // 
            // lblInitialDate
            // 
            this.lblInitialDate.AutoSize = true;
            this.lblInitialDate.Location = new System.Drawing.Point(16, 62);
            this.lblInitialDate.Name = "lblInitialDate";
            this.lblInitialDate.Size = new System.Drawing.Size(73, 15);
            this.lblInitialDate.TabIndex = 1;
            this.lblInitialDate.Text = "Fecha Inicio:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reporte Ventas";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.ibtnSearch);
            this.pnlTitle.Controls.Add(this.dtpFinalDate);
            this.pnlTitle.Controls.Add(this.lblFinalDate);
            this.pnlTitle.Controls.Add(this.dtpInitialDate);
            this.pnlTitle.Controls.Add(this.lblInitialDate);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(11, 9);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1270, 115);
            this.pnlTitle.TabIndex = 6;
            // 
            // DocumentType
            // 
            this.DocumentType.HeaderText = "Tipo Documento";
            this.DocumentType.Name = "DocumentType";
            // 
            // InvoceNumber
            // 
            this.InvoceNumber.HeaderText = "Nro Factura";
            this.InvoceNumber.Name = "InvoceNumber";
            // 
            // User
            // 
            this.User.HeaderText = "Usuario";
            this.User.Name = "User";
            // 
            // ClientDocument
            // 
            this.ClientDocument.HeaderText = "Doc Cliente";
            this.ClientDocument.Name = "ClientDocument";
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Cliente";
            this.ClientName.Name = "ClientName";
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Codigo Producto";
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Producto";
            this.ProductName.Name = "ProductName";
            // 
            // Category
            // 
            this.Category.HeaderText = "Categoria";
            this.Category.Name = "Category";
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "Precio Venta";
            this.SalePrice.Name = "SalePrice";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Toal";
            this.SubTotal.Name = "SubTotal";
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Fecha";
            this.CreatedDate.Name = "CreatedDate";
            // 
            // frmReportSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmReportSale";
            this.Text = "frmReportSale";
            this.Load += new System.EventHandler(this.frmReportSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblSearchBy;
        private FontAwesome.Sharp.IconButton ibtnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private FontAwesome.Sharp.IconButton ibtnSearch;
        private System.Windows.Forms.DateTimePicker dtpFinalDate;
        private System.Windows.Forms.Label lblFinalDate;
        private System.Windows.Forms.DateTimePicker dtpInitialDate;
        private System.Windows.Forms.Label lblInitialDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
    }
}