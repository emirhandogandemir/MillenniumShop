using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abtsract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfManagerDao : EfEntityRepositoryBase<Manager, MillenniumShopContext>, IManagerDao
    {
        public List<Manager> GetByCode(string managerCode)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return context.Managers.Where(m => m.ManagerCode == managerCode).ToList();
            }
        }
    }
}
