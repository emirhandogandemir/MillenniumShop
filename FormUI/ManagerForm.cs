using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework.Repository;
using Entities.Concrete;
using MaterialSkin;

namespace FormUI
{
    public partial class ManagerForm : MaterialSkin.Controls.MaterialForm
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        ProductManager productManager = new ProductManager(new EfProductDao());
        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            productManager.Add(AddProductClick());
            MessageBox.Show("ürün veritabanını eklendi");
        }

        public Product AddProductClick()
        {
            Product product = new Product
            {
                ProductName = txtProductAddProductName.Text,
                UnitPrice = Convert.ToDecimal(txtProductAddUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(txtProductAddUnitsInStock.Text),
                CategoryId = Convert.ToInt32(txtProductAddCategoryId.Text)
            };
            return product;
        }

        private void lblAdminPanelProductDetail_Click(object sender, EventArgs e)
        {
          dataGridWievProductDetails.DataSource =  productManager.GetProductDetails();
        }

        private void btnAdminPanelUnitsInStockShow_Click(object sender, EventArgs e)
        {
            dataGridViewUnitsInStock.DataSource = productManager.GetUnitsInStockProductName();
        }

        private void btnAdminPanelProductDelete_Click(object sender, EventArgs e)
        {
            productManager.Delete(new Product
            {
                ProductId =Convert.ToInt32(txtBoxAdminPanelProductDelete.Text)
            });
            MessageBox.Show("ürün veritabanından silindi");
        }

        private void lblAdminPanelProductAddClear_Click(object sender, EventArgs e)
        {
            txtProductAddProductName.Text = "";
            txtProductAddUnitPrice.Text = "";
            txtProductAddCategoryId.Text = "";
            txtProductAddUnitsInStock.Text = "";
        }

        private void btnAdminPanelProductUpdateUpdate_Click(object sender, EventArgs e)
        {
            productManager.Update(new Product
            {
                ProductId = Convert.ToInt32(txtAdminPanelProductUpdateProductId),
                ProductName = txtAdminPanelProductUpdateProductName.Text,
                UnitsInStock = Convert.ToInt16(txtAdminPanelProductUpdateUnitsInStock.Text),
                UnitPrice = Convert.ToDecimal(txtAdminPanelProductUpdateUnitPrice.Text),
                CategoryId = Convert.ToInt32(txtAdminPanelProductUpdateCategoryId.Text)
            });
            MessageBox.Show("Product Updated");
        }

        private void btnAdminPanelProductUpdateClear_Click(object sender, EventArgs e)
        {
            txtAdminPanelProductUpdateCategoryId.Text = "";
            txtAdminPanelProductUpdateUnitPrice.Text = "";
            txtAdminPanelProductUpdateUnitsInStock.Text = "";
            txtAdminPanelProductUpdateProductId.Text = "";
            txtAdminPanelProductUpdateProductName.Text = "";
        }
    }
}