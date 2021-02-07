using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.CheckPerson.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.CheckPerson.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        ICustomerDao _customerDao;

        public CustomerCheckManager(ICustomerDao customerDao)
        {
            _customerDao = customerDao;
        }

        public bool CheckIfRealPerson(Customer entity)
        {
            foreach (var customer in _customerDao.GetAll())
            {
                if ((customer.CustomerName == entity.CustomerName) && (customer.CustomerPassword == entity.CustomerPassword))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
