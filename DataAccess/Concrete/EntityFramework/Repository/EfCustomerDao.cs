using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCustomerDao : ICustomerDao
    {
        public void Add(Customer entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Customer entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return context.Set<Customer>().SingleOrDefault(filter);
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return filter == null ? context.Set<Customer>().ToList() : context.Set<Customer>().Where(filter).ToList();
            }
        }

        public void Update(Customer entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
