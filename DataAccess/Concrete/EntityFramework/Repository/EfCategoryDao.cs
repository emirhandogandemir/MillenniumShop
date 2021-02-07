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
   public class EfCategoryDao : ICategoryDao
    {
        public void Add(Category entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                return filter == null ? context.Set<Category>().ToList() :
                    context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
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
