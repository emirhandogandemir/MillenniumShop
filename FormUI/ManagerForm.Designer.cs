
namespace FormUI
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.AdminPanelProductAdd = new System.Windows.Forms.TabPage();
            this.lblAdminPanelProductAddClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProductAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtProductAddCategoryId = new System.Windows.Forms.TextBox();
            this.txtProductAddUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductAddUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtProductAddProductName = new System.Windows.Forms.TextBox();
            this.lblProductAddCategoryId = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductAddUnitPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductAddUnitsInStock = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductAddName = new MaterialSkin.Controls.MaterialLabel();
            this.AdminPanelProductUpdate = new System.Windows.Forms.TabPage();
            this.blAdminPanelProducUpdateProductName = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdminPanelProductUpdateCategoryId = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdminPanelProductUpdateUnitPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdminPanelProductUpdateUnitsInStock = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdminPanelProductUpdateProductName = new MaterialSkin.Controls.MaterialLabel();
            this.AdminPanelProductDelete = new System.Windows.Forms.TabPage();
            this.tabPage4AdminPanelProductDetails = new System.Windows.Forms.TabPage();
            this.lblAdminPanelProductDetail = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridWievProductDetails = new System.Windows.Forms.DataGridView();
            this.AdminPanelUnitsInStock = new System.Windows.Forms.TabPage();
            this.btnAdminPanelUnitsInStockShow = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewUnitsInStock = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAdminPanelWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.btnAdminPanelProductDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBoxAdminPanelProductDelete = new System.Windows.Forms.TextBox();
            this.lblAdminPanelDelete = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdminPanelProductUpdateProductId = new System.Windows.Forms.TextBox();
            this.txtAdminPanelProductUpdateProductName = new System.Windows.Forms.TextBox();
            this.txtAdminPanelProductUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtAdminPanelProductUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.txtAdminPanelProductUpdateCategoryId = new System.Windows.Forms.TextBox();
            this.btnAdminPanelProductUpdateClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdminPanelProductUpdateUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.AdminPanelProductAdd.SuspendLayout();
            this.AdminPanelProductUpdate.SuspendLayout();
            this.AdminPanelProductDelete.SuspendLayout();
            this.tabPage4AdminPanelProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWievProductDetails)).BeginInit();
            this.AdminPanelUnitsInStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.AdminPanelProductAdd);
            this.materialTabControl1.Controls.Add(this.AdminPanelProductUpdate);
            this.materialTabControl1.Controls.Add(this.AdminPanelProductDelete);
            this.materialTabControl1.Controls.Add(this.tabPage4AdminPanelProductDetails);
            this.materialTabControl1.Controls.Add(this.AdminPanelUnitsInStock);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 110);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(415, 288);
            this.materialTabControl1.TabIndex = 0;
            // 
            // AdminPanelProductAdd
            // 
            this.AdminPanelProductAdd.Controls.Add(this.lblAdminPanelProductAddClear);
            this.AdminPanelProductAdd.Controls.Add(this.btnProductAdd);
            this.AdminPanelProductAdd.Controls.Add(this.txtProductAddCategoryId);
            this.AdminPanelProductAdd.Controls.Add(this.txtProductAddUnitPrice);
            this.AdminPanelProductAdd.Controls.Add(this.txtProductAddUnitsInStock);
            this.AdminPanelProductAdd.Controls.Add(this.txtProductAddProductName);
            this.AdminPanelProductAdd.Controls.Add(this.lblProductAddCategoryId);
            this.AdminPanelProductAdd.Controls.Add(this.lblProductAddUnitPrice);
            this.AdminPanelProductAdd.Controls.Add(this.lblProductAddUnitsInStock);
            this.AdminPanelProductAdd.Controls.Add(this.lblProductAddName);
            this.AdminPanelProductAdd.Location = new System.Drawing.Point(4, 22);
            this.AdminPanelProductAdd.Name = "AdminPanelProductAdd";
            this.AdminPanelProductAdd.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPanelProductAdd.Size = new System.Drawing.Size(407, 262);
            this.AdminPanelProductAdd.TabIndex = 0;
            this.AdminPanelProductAdd.Text = "Product Add";
            this.AdminPanelProductAdd.UseVisualStyleBackColor = true;
            // 
            // lblAdminPanelProductAddClear
            // 
            this.lblAdminPanelProductAddClear.Depth = 0;
            this.lblAdminPanelProductAddClear.Location = new System.Drawing.Point(238, 201);
            this.lblAdminPanelProductAddClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelProductAddClear.Name = "lblAdminPanelProductAddClear";
            this.lblAdminPanelProductAddClear.Primary = true;
            this.lblAdminPanelProductAddClear.Size = new System.Drawing.Size(100, 26);
            this.lblAdminPanelProductAddClear.TabIndex = 9;
            this.lblAdminPanelProductAddClear.Text = "CLEAR";
            this.lblAdminPanelProductAddClear.UseVisualStyleBackColor = true;
            this.lblAdminPanelProductAddClear.Click += new System.EventHandler(this.lblAdminPanelProductAddClear_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Depth = 0;
            this.btnProductAdd.Location = new System.Drawing.Point(121, 201);
            this.btnProductAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Primary = true;
            this.btnProductAdd.Size = new System.Drawing.Size(100, 26);
            this.btnProductAdd.TabIndex = 8;
            this.btnProductAdd.Text = "ADD";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // txtProductAddCategoryId
            // 
            this.txtProductAddCategoryId.Location = new System.Drawing.Point(194, 164);
            this.txtProductAddCategoryId.Name = "txtProductAddCategoryId";
            this.txtProductAddCategoryId.Size = new System.Drawing.Size(100, 20);
            this.txtProductAddCategoryId.TabIndex = 7;
            // 
            // txtProductAddUnitPrice
            // 
            this.txtProductAddUnitPrice.Location = new System.Drawing.Point(194, 115);
            this.txtProductAddUnitPrice.Name = "txtProductAddUnitPrice";
            this.txtProductAddUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductAddUnitPrice.TabIndex = 6;
            // 
            // txtProductAddUnitsInStock
            // 
            this.txtProductAddUnitsInStock.Location = new System.Drawing.Point(194, 72);
            this.txtProductAddUnitsInStock.Name = "txtProductAddUnitsInStock";
            this.txtProductAddUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.txtProductAddUnitsInStock.TabIndex = 5;
            // 
            // txtProductAddProductName
            // 
            this.txtProductAddProductName.Location = new System.Drawing.Point(194, 31);
            this.txtProductAddProductName.Name = "txtProductAddProductName";
            this.txtProductAddProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductAddProductName.TabIndex = 4;
            // 
            // lblProductAddCategoryId
            // 
            this.lblProductAddCategoryId.AutoSize = true;
            this.lblProductAddCategoryId.Depth = 0;
            this.lblProductAddCategoryId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductAddCategoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductAddCategoryId.Location = new System.Drawing.Point(32, 164);
            this.lblProductAddCategoryId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductAddCategoryId.Name = "lblProductAddCategoryId";
            this.lblProductAddCategoryId.Size = new System.Drawing.Size(89, 19);
            this.lblProductAddCategoryId.TabIndex = 3;
            this.lblProductAddCategoryId.Text = "CategoryNo";
            // 
            // lblProductAddUnitPrice
            // 
            this.lblProductAddUnitPrice.AutoSize = true;
            this.lblProductAddUnitPrice.Depth = 0;
            this.lblProductAddUnitPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductAddUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductAddUnitPrice.Location = new System.Drawing.Point(32, 116);
            this.lblProductAddUnitPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductAddUnitPrice.Name = "lblProductAddUnitPrice";
            this.lblProductAddUnitPrice.Size = new System.Drawing.Size(70, 19);
            this.lblProductAddUnitPrice.TabIndex = 2;
            this.lblProductAddUnitPrice.Text = "UnitPrice";
            // 
            // lblProductAddUnitsInStock
            // 
            this.lblProductAddUnitsInStock.AutoSize = true;
            this.lblProductAddUnitsInStock.Depth = 0;
            this.lblProductAddUnitsInStock.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductAddUnitsInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductAddUnitsInStock.Location = new System.Drawing.Point(32, 74);
            this.lblProductAddUnitsInStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductAddUnitsInStock.Name = "lblProductAddUnitsInStock";
            this.lblProductAddUnitsInStock.Size = new System.Drawing.Size(95, 19);
            this.lblProductAddUnitsInStock.TabIndex = 1;
            this.lblProductAddUnitsInStock.Text = "UnitsInStock";
            // 
            // lblProductAddName
            // 
            this.lblProductAddName.AutoSize = true;
            this.lblProductAddName.Depth = 0;
            this.lblProductAddName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductAddName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductAddName.Location = new System.Drawing.Point(32, 31);
            this.lblProductAddName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductAddName.Name = "lblProductAddName";
            this.lblProductAddName.Size = new System.Drawing.Size(101, 19);
            this.lblProductAddName.TabIndex = 0;
            this.lblProductAddName.Text = "ProductName";
            // 
            // AdminPanelProductUpdate
            // 
            this.AdminPanelProductUpdate.Controls.Add(this.btnAdminPanelProductUpdateUpdate);
            this.AdminPanelProductUpdate.Controls.Add(this.btnAdminPanelProductUpdateClear);
            this.AdminPanelProductUpdate.Controls.Add(this.txtAdminPanelProductUpdateCategoryId);
            this.AdminPanelProductUpdate.Controls.Add(this.txtAdminPanelProductUpdateUnitPrice);
            this.AdminPanelProductUpdate.Controls.Add(this.txtAdminPanelProductUpdateUnitsInStock);
            this.AdminPanelProductUpdate.Controls.Add(this.txtAdminPanelProductUpdateProductName);
            this.AdminPanelProductUpdate.Controls.Add(this.txtAdminPanelProductUpdateProductId);
            this.AdminPanelProductUpdate.Controls.Add(this.blAdminPanelProducUpdateProductName);
            this.AdminPanelProductUpdate.Controls.Add(this.lblAdminPanelProductUpdateCategoryId);
            this.AdminPanelProductUpdate.Controls.Add(this.lblAdminPanelProductUpdateUnitPrice);
            this.AdminPanelProductUpdate.Controls.Add(this.lblAdminPanelProductUpdateUnitsInStock);
            this.AdminPanelProductUpdate.Controls.Add(this.lblAdminPanelProductUpdateProductName);
            this.AdminPanelProductUpdate.Location = new System.Drawing.Point(4, 22);
            this.AdminPanelProductUpdate.Name = "AdminPanelProductUpdate";
            this.AdminPanelProductUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPanelProductUpdate.Size = new System.Drawing.Size(407, 262);
            this.AdminPanelProductUpdate.TabIndex = 1;
            this.AdminPanelProductUpdate.Text = "Product Update";
            this.AdminPanelProductUpdate.UseVisualStyleBackColor = true;
            // 
            // blAdminPanelProducUpdateProductName
            // 
            this.blAdminPanelProducUpdateProductName.AutoSize = true;
            this.blAdminPanelProducUpdateProductName.Depth = 0;
            this.blAdminPanelProducUpdateProductName.Font = new System.Drawing.Font("Roboto", 11F);
            this.blAdminPanelProducUpdateProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.blAdminPanelProducUpdateProductName.Location = new System.Drawing.Point(19, 20);
            this.blAdminPanelProducUpdateProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.blAdminPanelProducUpdateProductName.Name = "blAdminPanelProducUpdateProductName";
            this.blAdminPanelProducUpdateProductName.Size = new System.Drawing.Size(73, 19);
            this.blAdminPanelProducUpdateProductName.TabIndex = 8;
            this.blAdminPanelProducUpdateProductName.Text = "ProductId";
            // 
            // lblAdminPanelProductUpdateCategoryId
            // 
            this.lblAdminPanelProductUpdateCategoryId.AutoSize = true;
            this.lblAdminPanelProductUpdateCategoryId.Depth = 0;
            this.lblAdminPanelProductUpdateCategoryId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminPanelProductUpdateCategoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminPanelProductUpdateCategoryId.Location = new System.Drawing.Point(19, 173);
            this.lblAdminPanelProductUpdateCategoryId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelProductUpdateCategoryId.Name = "lblAdminPanelProductUpdateCategoryId";
            this.lblAdminPanelProductUpdateCategoryId.Size = new System.Drawing.Size(89, 19);
            this.lblAdminPanelProductUpdateCategoryId.TabIndex = 7;
            this.lblAdminPanelProductUpdateCategoryId.Text = "CategoryNo";
            // 
            // lblAdminPanelProductUpdateUnitPrice
            // 
            this.lblAdminPanelProductUpdateUnitPrice.AutoSize = true;
            this.lblAdminPanelProductUpdateUnitPrice.Depth = 0;
            this.lblAdminPanelProductUpdateUnitPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminPanelProductUpdateUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminPanelProductUpdateUnitPrice.Location = new System.Drawing.Point(19, 138);
            this.lblAdminPanelProductUpdateUnitPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelProductUpdateUnitPrice.Name = "lblAdminPanelProductUpdateUnitPrice";
            this.lblAdminPanelProductUpdateUnitPrice.Size = new System.Drawing.Size(70, 19);
            this.lblAdminPanelProductUpdateUnitPrice.TabIndex = 6;
            this.lblAdminPanelProductUpdateUnitPrice.Text = "UnitPrice";
            // 
            // lblAdminPanelProductUpdateUnitsInStock
            // 
            this.lblAdminPanelProductUpdateUnitsInStock.AutoSize = true;
            this.lblAdminPanelProductUpdateUnitsInStock.Depth = 0;
            this.lblAdminPanelProductUpdateUnitsInStock.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminPanelProductUpdateUnitsInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminPanelProductUpdateUnitsInStock.Location = new System.Drawing.Point(19, 103);
            this.lblAdminPanelProductUpdateUnitsInStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelProductUpdateUnitsInStock.Name = "lblAdminPanelProductUpdateUnitsInStock";
            this.lblAdminPanelProductUpdateUnitsInStock.Size = new System.Drawing.Size(95, 19);
            this.lblAdminPanelProductUpdateUnitsInStock.TabIndex = 5;
            this.lblAdminPanelProductUpdateUnitsInStock.Text = "UnitsInStock";
            // 
            // lblAdminPanelProductUpdateProductName
            // 
            this.lblAdminPanelProductUpdateProductName.AutoSize = true;
            this.lblAdminPanelProductUpdateProductName.Depth = 0;
            this.lblAdminPanelProductUpdateProductName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminPanelProductUpdateProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminPanelProductUpdateProductName.Location = new System.Drawing.Point(19, 61);
            this.lblAdminPanelProductUpdateProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelProductUpdateProductName.Name = "lblAdminPanelProductUpdateProductName";
            this.lblAdminPanelProductUpdateProductName.Size = new System.Drawing.Size(101, 19);
            this.lblAdminPanelProductUpdateProductName.TabIndex = 4;
            this.lblAdminPanelProductUpdateProductName.Text = "ProductName";
            // 
            // AdminPanelProductDelete
            // 
            this.AdminPanelProductDelete.Controls.Add(this.lblAdminPanelDelete);
            this.AdminPanelProductDelete.Controls.Add(this.txtBoxAdminPanelProductDelete);
            this.AdminPanelProductDelete.Controls.Add(this.btnAdminPanelProductDelete);
            this.AdminPanelProductDelete.Location = new System.Drawing.Point(4, 22);
            this.AdminPanelProductDelete.Name = "AdminPanelProductDelete";
            this.AdminPanelProductDelete.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPanelProductDelete.Size = new System.Drawing.Size(407, 262);
            this.AdminPanelProductDelete.TabIndex = 2;
            this.AdminPanelProductDelete.Text = "Product Delete";
            this.AdminPanelProductDelete.UseVisualStyleBackColor = true;
            // 
            // tabPage4AdminPanelProductDetails
            // 
            this.tabPage4AdminPanelProductDetails.Controls.Add(this.lblAdminPanelProductDetail);
            this.tabPage4AdminPanelProductDetails.Controls.Add(this.dataGridWievProductDetails);
            this.tabPage4AdminPanelProductDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPage4AdminPanelProductDetails.Name = "tabPage4AdminPanelProductDetails";
            this.tabPage4AdminPanelProductDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4AdminPanelProductDetails.Size = new System.Drawing.Size(407, 262);
            this.tabPage4AdminPanelProductDetails.TabIndex = 3;
            this.tabPage4AdminPanelProductDetails.Text = "Product Details";
            this.tabPage4AdminPanelProductDetails.UseVisualStyleBackColor = true;
            // 
            // lblAdminPanelProductDetail
            // 
            this.lblAdminPanelProductDetail.Depth = 0;
            this.lblAdminPanelProductDetail.Location = new System.Drawing.Point(115, 179);
            this.lblAdminPanelProductDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelProductDetail.Name = "lblAdminPanelProductDetail";
            this.lblAdminPanelProductDetail.Primary = true;
            this.lblAdminPanelProductDetail.Size = new System.Drawing.Size(139, 26);
            this.lblAdminPanelProductDetail.TabIndex = 9;
            this.lblAdminPanelProductDetail.Text = "Details Show";
            this.lblAdminPanelProductDetail.UseVisualStyleBackColor = true;
            this.lblAdminPanelProductDetail.Click += new System.EventHandler(this.lblAdminPanelProductDetail_Click);
            // 
            // dataGridWievProductDetails
            // 
            this.dataGridWievProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWievProductDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridWievProductDetails.Name = "dataGridWievProductDetails";
            this.dataGridWievProductDetails.ReadOnly = true;
            this.dataGridWievProductDetails.Size = new System.Drawing.Size(407, 134);
            this.dataGridWievProductDetails.TabIndex = 0;
            // 
            // AdminPanelUnitsInStock
            // 
            this.AdminPanelUnitsInStock.Controls.Add(this.btnAdminPanelUnitsInStockShow);
            this.AdminPanelUnitsInStock.Controls.Add(this.dataGridViewUnitsInStock);
            this.AdminPanelUnitsInStock.Location = new System.Drawing.Point(4, 22);
            this.AdminPanelUnitsInStock.Name = "AdminPanelUnitsInStock";
            this.AdminPanelUnitsInStock.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPanelUnitsInStock.Size = new System.Drawing.Size(407, 262);
            this.AdminPanelUnitsInStock.TabIndex = 4;
            this.AdminPanelUnitsInStock.Text = "UnitsInStock";
            this.AdminPanelUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // btnAdminPanelUnitsInStockShow
            // 
            this.btnAdminPanelUnitsInStockShow.Depth = 0;
            this.btnAdminPanelUnitsInStockShow.Location = new System.Drawing.Point(267, 21);
            this.btnAdminPanelUnitsInStockShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdminPanelUnitsInStockShow.Name = "btnAdminPanelUnitsInStockShow";
            this.btnAdminPanelUnitsInStockShow.Primary = true;
            this.btnAdminPanelUnitsInStockShow.Size = new System.Drawing.Size(100, 26);
            this.btnAdminPanelUnitsInStockShow.TabIndex = 9;
            this.btnAdminPanelUnitsInStockShow.Text = "Show Stock";
            this.btnAdminPanelUnitsInStockShow.UseVisualStyleBackColor = true;
            this.btnAdminPanelUnitsInStockShow.Click += new System.EventHandler(this.btnAdminPanelUnitsInStockShow_Click);
            // 
            // dataGridViewUnitsInStock
            // 
            this.dataGridViewUnitsInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnitsInStock.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewUnitsInStock.Name = "dataGridViewUnitsInStock";
            this.dataGridViewUnitsInStock.Size = new System.Drawing.Size(239, 259);
            this.dataGridViewUnitsInStock.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(704, 40);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(526, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 62);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(621, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 62);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblAdminPanelWelcome
            // 
            this.lblAdminPanelWelcome.AutoSize = true;
            this.lblAdminPanelWelcome.Depth = 0;
            this.lblAdminPanelWelcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminPanelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminPanelWelcome.Location = new System.Drawing.Point(430, 375);
            this.lblAdminPanelWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelWelcome.Name = "lblAdminPanelWelcome";
            this.lblAdminPanelWelcome.Size = new System.Drawing.Size(274, 19);
            this.lblAdminPanelWelcome.TabIndex = 5;
            this.lblAdminPanelWelcome.Text = "Millennium Admin Paneline Hoşgeldiniz";
            // 
            // btnAdminPanelProductDelete
            // 
            this.btnAdminPanelProductDelete.Depth = 0;
            this.btnAdminPanelProductDelete.Location = new System.Drawing.Point(95, 199);
            this.btnAdminPanelProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdminPanelProductDelete.Name = "btnAdminPanelProductDelete";
            this.btnAdminPanelProductDelete.Primary = true;
            this.btnAdminPanelProductDelete.Size = new System.Drawing.Size(100, 26);
            this.btnAdminPanelProductDelete.TabIndex = 9;
            this.btnAdminPanelProductDelete.Text = "DELETE";
            this.btnAdminPanelProductDelete.UseVisualStyleBackColor = true;
            this.btnAdminPanelProductDelete.Click += new System.EventHandler(this.btnAdminPanelProductDelete_Click);
            // 
            // txtBoxAdminPanelProductDelete
            // 
            this.txtBoxAdminPanelProductDelete.Location = new System.Drawing.Point(132, 41);
            this.txtBoxAdminPanelProductDelete.Name = "txtBoxAdminPanelProductDelete";
            this.txtBoxAdminPanelProductDelete.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAdminPanelProductDelete.TabIndex = 10;
            // 
            // lblAdminPanelDelete
            // 
            this.lblAdminPanelDelete.AutoSize = true;
            this.lblAdminPanelDelete.Depth = 0;
            this.lblAdminPanelDelete.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminPanelDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminPanelDelete.Location = new System.Drawing.Point(29, 42);
            this.lblAdminPanelDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminPanelDelete.Name = "lblAdminPanelDelete";
            this.lblAdminPanelDelete.Size = new System.Drawing.Size(77, 19);
            this.lblAdminPanelDelete.TabIndex = 11;
            this.lblAdminPanelDelete.Text = "Product Id";
            // 
            // txtAdminPanelProductUpdateProductId
            // 
            this.txtAdminPanelProductUpdateProductId.Location = new System.Drawing.Point(161, 20);
            this.txtAdminPanelProductUpdateProductId.Name = "txtAdminPanelProductUpdateProductId";
            this.txtAdminPanelProductUpdateProductId.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPanelProductUpdateProductId.TabIndex = 9;
            // 
            // txtAdminPanelProductUpdateProductName
            // 
            this.txtAdminPanelProductUpdateProductName.Location = new System.Drawing.Point(161, 61);
            this.txtAdminPanelProductUpdateProductName.Name = "txtAdminPanelProductUpdateProductName";
            this.txtAdminPanelProductUpdateProductName.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPanelProductUpdateProductName.TabIndex = 10;
            // 
            // txtAdminPanelProductUpdateUnitsInStock
            // 
            this.txtAdminPanelProductUpdateUnitsInStock.Location = new System.Drawing.Point(161, 102);
            this.txtAdminPanelProductUpdateUnitsInStock.Name = "txtAdminPanelProductUpdateUnitsInStock";
            this.txtAdminPanelProductUpdateUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPanelProductUpdateUnitsInStock.TabIndex = 11;
            // 
            // txtAdminPanelProductUpdateUnitPrice
            // 
            this.txtAdminPanelProductUpdateUnitPrice.Location = new System.Drawing.Point(161, 137);
            this.txtAdminPanelProductUpdateUnitPrice.Name = "txtAdminPanelProductUpdateUnitPrice";
            this.txtAdminPanelProductUpdateUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPanelProductUpdateUnitPrice.TabIndex = 12;
            // 
            // txtAdminPanelProductUpdateCategoryId
            // 
            this.txtAdminPanelProductUpdateCategoryId.Location = new System.Drawing.Point(161, 172);
            this.txtAdminPanelProductUpdateCategoryId.Name = "txtAdminPanelProductUpdateCategoryId";
            this.txtAdminPanelProductUpdateCategoryId.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPanelProductUpdateCategoryId.TabIndex = 13;
            // 
            // btnAdminPanelProductUpdateClear
            // 
            this.btnAdminPanelProductUpdateClear.Depth = 0;
            this.btnAdminPanelProductUpdateClear.Location = new System.Drawing.Point(225, 218);
            this.btnAdminPanelProductUpdateClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdminPanelProductUpdateClear.Name = "btnAdminPanelProductUpdateClear";
            this.btnAdminPanelProductUpdateClear.Primary = true;
            this.btnAdminPanelProductUpdateClear.Size = new System.Drawing.Size(100, 26);
            this.btnAdminPanelProductUpdateClear.TabIndex = 14;
            this.btnAdminPanelProductUpdateClear.Text = "CLEAR";
            this.btnAdminPanelProductUpdateClear.UseVisualStyleBackColor = true;
            this.btnAdminPanelProductUpdateClear.Click += new System.EventHandler(this.btnAdminPanelProductUpdateClear_Click);
            // 
            // btnAdminPanelProductUpdateUpdate
            // 
            this.btnAdminPanelProductUpdateUpdate.Depth = 0;
            this.btnAdminPanelProductUpdateUpdate.Location = new System.Drawing.Point(95, 218);
            this.btnAdminPanelProductUpdateUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdminPanelProductUpdateUpdate.Name = "btnAdminPanelProductUpdateUpdate";
            this.btnAdminPanelProductUpdateUpdate.Primary = true;
            this.btnAdminPanelProductUpdateUpdate.Size = new System.Drawing.Size(100, 26);
            this.btnAdminPanelProductUpdateUpdate.TabIndex = 15;
            this.btnAdminPanelProductUpdateUpdate.Text = "UPDATE";
            this.btnAdminPanelProductUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnAdminPanelProductUpdateUpdate.Click += new System.EventHandler(this.btnAdminPanelProductUpdateUpdate_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 399);
            this.Controls.Add(this.lblAdminPanelWelcome);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "ManagerForm";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.AdminPanelProductAdd.ResumeLayout(false);
            this.AdminPanelProductAdd.PerformLayout();
            this.AdminPanelProductUpdate.ResumeLayout(false);
            this.AdminPanelProductUpdate.PerformLayout();
            this.AdminPanelProductDelete.ResumeLayout(false);
            this.AdminPanelProductDelete.PerformLayout();
            this.tabPage4AdminPanelProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWievProductDetails)).EndInit();
            this.AdminPanelUnitsInStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage AdminPanelProductAdd;
        private System.Windows.Forms.TabPage AdminPanelProductUpdate;
        private System.Windows.Forms.TabPage AdminPanelProductDelete;
        private System.Windows.Forms.TabPage tabPage4AdminPanelProductDetails;
        private System.Windows.Forms.TabPage AdminPanelUnitsInStock;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel lblProductAddName;
        private MaterialSkin.Controls.MaterialLabel lblProductAddCategoryId;
        private MaterialSkin.Controls.MaterialLabel lblProductAddUnitPrice;
        private MaterialSkin.Controls.MaterialLabel lblProductAddUnitsInStock;
        private System.Windows.Forms.TextBox txtProductAddCategoryId;
        private System.Windows.Forms.TextBox txtProductAddUnitPrice;
        private System.Windows.Forms.TextBox txtProductAddUnitsInStock;
        private System.Windows.Forms.TextBox txtProductAddProductName;
        private MaterialSkin.Controls.MaterialRaisedButton btnProductAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel lblAdminPanelWelcome;
        private MaterialSkin.Controls.MaterialLabel blAdminPanelProducUpdateProductName;
        private MaterialSkin.Controls.MaterialLabel lblAdminPanelProductUpdateCategoryId;
        private MaterialSkin.Controls.MaterialLabel lblAdminPanelProductUpdateUnitPrice;
        private MaterialSkin.Controls.MaterialLabel lblAdminPanelProductUpdateUnitsInStock;
        private MaterialSkin.Controls.MaterialLabel lblAdminPanelProductUpdateProductName;
        private MaterialSkin.Controls.MaterialRaisedButton lblAdminPanelProductAddClear;
        private MaterialSkin.Controls.MaterialRaisedButton lblAdminPanelProductDetail;
        private System.Windows.Forms.DataGridView dataGridWievProductDetails;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdminPanelUnitsInStockShow;
        private System.Windows.Forms.DataGridView dataGridViewUnitsInStock;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private MaterialSkin.Controls.MaterialLabel lblAdminPanelDelete;
        private System.Windows.Forms.TextBox txtBoxAdminPanelProductDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdminPanelProductDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdminPanelProductUpdateUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdminPanelProductUpdateClear;
        private System.Windows.Forms.TextBox txtAdminPanelProductUpdateCategoryId;
        private System.Windows.Forms.TextBox txtAdminPanelProductUpdateUnitPrice;
        private System.Windows.Forms.TextBox txtAdminPanelProductUpdateUnitsInStock;
        private System.Windows.Forms.TextBox txtAdminPanelProductUpdateProductName;
        private System.Windows.Forms.TextBox txtAdminPanelProductUpdateProductId;
    }
}