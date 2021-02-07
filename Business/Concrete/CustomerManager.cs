using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Abtsract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDao _customerDao;
        public CustomerManager(ICustomerDao customerDao) 
        {
            _customerDao  =  customerDao;
        }

        public void Add(Customer entity)
        {
            _customerDao.Add(entity);
        }

        public void Delete(Customer entity)
        {
             _customerDao.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _customerDao.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDao.Get(customer => customer.CustomerId == id);
        }

        public void Update(Customer entity)
        {
            _customerDao.Update(entity);
        }
    }
}
