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
    public partial class FormSignUp : MaterialSkin.Controls.MaterialForm
    {

        public FormSignUp()
        {
            InitializeComponent();

        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);



        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDao());
        ManagerManager managerManager = new ManagerManager(new EfManagerDao());



        private void tabControlManagerSıgnIn_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerPassword.Text == txtCustomerAgainPassword.Text)
            {
                MessageBox.Show("Sisteme kayıtınız başarı ile gerçekleştirilmiştir");
                customerManager.Add(new Customer
                {
                    CustomerName = txtCustomerName.Text,
                    CustomerSurname = txtCustomerSurname.Text,
                    CustomerCity = txtCustomerCity.Text,
                    CustomerEmail = txtCustomerEmail.Text,
                    CustomerPassword = txtCustomerPassword.Text,
                    CustomerPassword2 = txtCustomerAgainPassword.Text
                });

            }
            else
            {
                MessageBox.Show("Parolalar Eşleşemedi");
            }
        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerPassword.Text = "";
            txtCustomerAgainPassword.Text = "";


        }

        private void btnManagerAdd_Click(object sender, EventArgs e)
        {
            if (txtManagerCode.Text == ".millennium")
            {
                if (txtManagerPassword.Text == txtManagerAgainPassword.Text)
                {
                    MessageBox.Show("sisteme kayıtınız başarı ile gerçekleştirilmiştir");
                    managerManager.Add(new Manager
                    {
                        ManagerName = txtManagerName.Text,
                        ManagerSurname = txtManagerSurname.Text,
                        ManagerEMail = txtManagerEmail.Text,
                        ManagerCity = txtManagerCity.Text,
                        ManagerPassword = txtManagerPassword.Text,
                        ManagerPassword2 = txtManagerAgainPassword.Text,
                        ManagerCode = txtManagerCode.Text
                    });
                }
                else
                {
                    MessageBox.Show("PASSWORDLER UYUŞMUYOR");
                }
            }
            else
            {
                MessageBox.Show("girdiginiz kod erişim izni vermiyor");
            }


        }

        private void btnManagerClear_Click(object sender, EventArgs e)
        {
            txtManagerName.Text = "";
            txtManagerEmail.Text = "";
            txtManagerSurname.Text = "";
            txtManagerCity.Text = "";
            txtManagerPassword.Text = "";
            txtManagerAgainPassword.Text = "";
            txtManagerCode.Text = "";
        }
    }


}



