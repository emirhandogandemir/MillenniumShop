using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abtsract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
   public interface ICustomerDao : IEntityRepository<Customer>
    {
    }
}
