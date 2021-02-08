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
using MetroFramework;

namespace FormUI
{
    public partial class CustomerForm : MetroFramework.Forms.MetroForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            this.StyleManager = msmCustomerPanel;
            msmCustomerPanel.Theme = MetroThemeStyle.Dark;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
        
        }
        ProductManager productManager = new ProductManager(new EfProductDao());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDao());
        ProductForm productForm = new ProductForm();
        public void MetroTileLaptop_Click(object sender, EventArgs e)
        {
        
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(1);
            productForm.ShowDialog();
            this.Show();
            
        }

        private void metroTileTelefon_Click(object sender, EventArgs e)
        {
          
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(2);
            productForm.ShowDialog();
            this.Show();
        }

        private void metroTileHeadPhone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(3);
            productForm.ShowDialog();
            this.Show();
        }

        private void metroTileMouse_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(4);
            productForm.ShowDialog();
            this.Show();
        }

        private void metroTileKeyboard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(5);
            productForm.ShowDialog();
            this.Show();
        }

        private void metroTileMonitör_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(6);
            productForm.ShowDialog();
            this.Show();
        }

        private void metroTileJoystick_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(7);
            productForm.ShowDialog();
            this.Show();
        }

        private void metroTileGamerChair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            productForm.dataGridViewProduct.DataSource = productManager.GetAllByCategoryId(8);
            productForm.ShowDialog();
            this.Show();
        }
    }
}
