using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abtsract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Repository
{
   public class EfManagerDao : IManagerDao
    {
        public void Add(Manager entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Manager entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Manager Get(Expression<Func<Manager, bool>> filter)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return context.Set<Manager>().SingleOrDefault(filter);
            }
        }

        public List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return filter == null ? context.Set<Manager>().ToList() : context.Set<Manager>().Where(filter).ToList();
            }
        }

        public void Update(Manager entity)
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
