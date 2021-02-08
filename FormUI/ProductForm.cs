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
using MetroFramework.Drawing;

namespace FormUI
{
    public partial class ProductForm : MetroFramework.Forms.MetroForm
    {
        public ProductForm()
        {
            InitializeComponent();
            DatagridviewSetting();
        }

        private ProductManager productManager = new ProductManager(new EfProductDao());
        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        public void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DatagridviewSetting()
        {
          
            dataGridViewProduct.BorderStyle = (BorderStyle)MetroBorderStyle.None;
            dataGridViewProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewProduct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewProduct.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewProduct.EnableHeadersVisualStyles = false;
            dataGridViewProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void metroButtonProductFormLoad_Click(object sender, EventArgs e)
        {
            dataGridViewProduct.DataSource = productManager.GetById(2);
        }
    }
}
