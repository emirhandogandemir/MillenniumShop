using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abtsract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDao _categoryDao;

        public CategoryManager(ICategoryDao categoryDao)
        {
            _categoryDao = categoryDao;
        }


        public void Add(Category category)
        {
           _categoryDao.Add(category);
        }

        public void Delete(Category category)
        {
           _categoryDao.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDao.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDao.Get(category => category.CategoryId == id);
        }

        public void Update(Category category)
        {
          _categoryDao.Update(category);
        }
    }
}
