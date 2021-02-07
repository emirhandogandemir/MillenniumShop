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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, 
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDao());
        ManagerManager managerManager = new ManagerManager(new EfManagerDao());
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CodeControl())
            {
                if (PasswordControl())
                {
                    MessageBox.Show("manager tablosuna eklendi");
                    managerManager.Add(addClickManager());
                   
                }
                else
                {
                    MessageBox.Show("parolalar eşleşmedi");
                }
            }
            else
            {
                if (PasswordControl())
                {
                    MessageBox.Show("customer tablosuna eklendi");
                    customerManager.Add(AddClickCustomer());
                  
                }
                else
                {
                    MessageBox.Show("parolalar eşleşmedi");
                }
            }
        }

        private bool CodeControl()
        {
            if (txtCode.Text == ".millennium")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool PasswordControl()
        {
            if (txtPassword.Text == txtPassword2.Text)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        
     

        private Manager addClickManager()
        {
            Manager manager = new Manager
            {
                ManagerName = txtName.Text,
                ManagerSurname = txtSurname.Text,
                ManagerCity = txtCity.Text,
                ManagerEMail = txtEmail.Text,
                ManagerPassword = txtPassword.Text,
                ManagerPassword2 = txtPassword2.Text,
                ManagerCode = txtCode.Text
            };
            return manager;
        }
        private Customer AddClickCustomer()
        {
            Customer customer =  new Customer
            {
               CustomerName = txtName.Text,
            CustomerSurname = txtSurname.Text,
            CustomerEmail = txtEmail.Text,
            CustomerPassword  =  txtPassword.Text,
            CustomerPassword2 = txtPassword2.Text,
            CustomerCity = txtCity.Text
            
            };
            return customer;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }
    }
}
