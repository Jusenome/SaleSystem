
namespace PresentationLayer.Forms
{
    partial class frmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ibtnCancel = new FontAwesome.Sharp.IconButton();
            this.ibtnEdit = new FontAwesome.Sharp.IconButton();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.cmbUserState = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblUserState = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblUDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
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
            this.ibtnCancel.Location = new System.Drawing.Point(34, 399);
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
            this.ibtnEdit.Location = new System.Drawing.Point(34, 341);
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
            this.ibtnSave.Location = new System.Drawing.Point(34, 370);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(177, 23);
            this.ibtnSave.TabIndex = 15;
            this.ibtnSave.Text = "Guardar";
            this.ibtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSave.UseVisualStyleBackColor = false;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // cmbUserState
            // 
            this.cmbUserState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserState.FormattingEnabled = true;
            this.cmbUserState.Location = new System.Drawing.Point(34, 302);
            this.cmbUserState.Name = "cmbUserState";
            this.cmbUserState.Size = new System.Drawing.Size(177, 23);
            this.cmbUserState.TabIndex = 14;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(34, 253);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(177, 23);
            this.cmbCategory.TabIndex = 13;
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.Location = new System.Drawing.Point(34, 283);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(42, 15);
            this.lblUserState.TabIndex = 12;
            this.lblUserState.Text = "Estado";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(34, 234);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Categoria";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(34, 199);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(177, 23);
            this.txtDescription.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(34, 151);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 23);
            this.txtName.TabIndex = 7;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(34, 103);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(177, 23);
            this.txtCode.TabIndex = 6;
            // 
            // lblUDescription
            // 
            this.lblUDescription.AutoSize = true;
            this.lblUDescription.Location = new System.Drawing.Point(34, 181);
            this.lblUDescription.Name = "lblUDescription";
            this.lblUDescription.Size = new System.Drawing.Size(69, 15);
            this.lblUDescription.TabIndex = 3;
            this.lblUDescription.Text = "Descripción";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(571, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 23);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(427, 9);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(138, 23);
            this.cmbSearchBy.TabIndex = 19;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(358, 12);
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
            this.lblListTitle.Size = new System.Drawing.Size(196, 28);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Listado de Usuarios";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.cmbSearchBy);
            this.pnlSearch.Controls.Add(this.lblSearchBy);
            this.pnlSearch.Controls.Add(this.lblListTitle);
            this.pnlSearch.Location = new System.Drawing.Point(287, 32);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1060, 43);
            this.pnlSearch.TabIndex = 4;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(34, 84);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Codigo";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(34, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Producto";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
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
            this.Code,
            this.PName,
            this.Description,
            this.idCategory,
            this.Category,
            this.Stock,
            this.PurchasePrice,
            this.SalePrice,
            this.valueState,
            this.State,
            this.Edit});
            this.dgvList.Location = new System.Drawing.Point(287, 104);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.RowTemplate.Height = 28;
            this.dgvList.Size = new System.Drawing.Size(1060, 380);
            this.dgvList.TabIndex = 5;
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
            // Code
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Code.DefaultCellStyle = dataGridViewCellStyle2;
            this.Code.FillWeight = 19.29519F;
            this.Code.HeaderText = "Codigo";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // PName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PName.DefaultCellStyle = dataGridViewCellStyle3;
            this.PName.FillWeight = 456.8528F;
            this.PName.HeaderText = "Nombre";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 200;
            // 
            // Description
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Description.DefaultCellStyle = dataGridViewCellStyle4;
            this.Description.FillWeight = 19.29519F;
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 170;
            // 
            // idCategory
            // 
            this.idCategory.HeaderText = "idCategory";
            this.idCategory.Name = "idCategory";
            this.idCategory.ReadOnly = true;
            this.idCategory.Visible = false;
            // 
            // Category
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Category.DefaultCellStyle = dataGridViewCellStyle5;
            this.Category.FillWeight = 19.29519F;
            this.Category.HeaderText = "Categoria";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 110;
            // 
            // Stock
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle6;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.PurchasePrice.HeaderText = "Precio Compra";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // SalePrice
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SalePrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.SalePrice.HeaderText = "Precio Venta";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.State.DefaultCellStyle = dataGridViewCellStyle9;
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
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.txtId);
            this.pnlData.Controls.Add(this.ibtnCancel);
            this.pnlData.Controls.Add(this.ibtnEdit);
            this.pnlData.Controls.Add(this.ibtnSave);
            this.pnlData.Controls.Add(this.cmbUserState);
            this.pnlData.Controls.Add(this.cmbCategory);
            this.pnlData.Controls.Add(this.lblUserState);
            this.pnlData.Controls.Add(this.lblCategory);
            this.pnlData.Controls.Add(this.txtDescription);
            this.pnlData.Controls.Add(this.txtName);
            this.pnlData.Controls.Add(this.txtCode);
            this.pnlData.Controls.Add(this.lblUDescription);
            this.pnlData.Controls.Add(this.lblName);
            this.pnlData.Controls.Add(this.lblCode);
            this.pnlData.Controls.Add(this.lblTitle);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(258, 501);
            this.pnlData.TabIndex = 3;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 501);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlData);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private FontAwesome.Sharp.IconButton ibtnEdit;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private System.Windows.Forms.ComboBox cmbUserState;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblUDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}