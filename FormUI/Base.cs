using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.CheckPerson;
using Business.CheckPerson.Abstract;
using Business.CheckPerson.Concrete;
using Business.Concrete;
using DataAccess.Abtsract;
using DataAccess.Concrete.EntityFramework.Repository;
using Entities.Concrete;

namespace FormUI
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();

        }

        private IPersonCheckService<Manager> managerCheckService = new ManagerCheckService(new EfManagerDao());
        private IPersonCheckService<Customer> customerCheckService = new CustomerCheckManager(new EfCustomerDao());
        private void btnLogin_Click(object sender, EventArgs e)
       {
           var manager = ManagerCheckAtama();

            if (managerCheckService.CheckIfRealPerson(manager))
            {
                MessageBox.Show("Giris Onaylandı");
                ManagerForm managerForm = new ManagerForm();
                this.Visible = false;
                managerForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("yanlıs");
            }
       }

       private Manager ManagerCheckAtama()
       {
           Manager manager = new Manager
           {
               ManagerName = txtUsername.Text,
               ManagerPassword = txtPassword.Text
           };
           return manager;
       }

       private Customer CustomerCheckAtama()
       {
           Customer customer = new Customer
           {
               CustomerName = txtUsername.Text,
               CustomerPassword = txtPassword.Text

           };
           return customer;
       }

       private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            this.Visible = false;

            signUp.ShowDialog();
            this.Show(); //geçici çözüm


        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            var customer = CustomerCheckAtama();

            if (customerCheckService.CheckIfRealPerson(customer))
            {
                MessageBox.Show("dogru");
                CustomerForm customerForm = new CustomerForm();
                this.Visible = false;
                customerForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("yanlıs");
            }
        }
    }
}
