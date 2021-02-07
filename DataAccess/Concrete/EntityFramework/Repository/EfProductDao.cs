using DataAccess.Abtsract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
   public class EfProductDao : IProductDao
    {
        public void Add(Product entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return filter == null ? context.Set<Product>().ToList() :
                    context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
