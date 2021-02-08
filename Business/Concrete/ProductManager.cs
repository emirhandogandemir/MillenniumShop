using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abtsract;
using Entities.Concrete;
namespace Business.Concrete
{
   public class ProductManager : IProductService
    {
        IProductDao _productDao;
      
        public ProductManager(IProductDao productDao)
        {
            _productDao  =  productDao;
           
        }

        public void Add(Product entity)
        {
            _productDao.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDao.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDao.GetAll();
        }

        public List<Product> GetAllByCategoryId(Category category)
        {
            return _productDao.GetAll(product=>product.CategoryId==category.CategoryId);
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _productDao.GetAll(p => p.CategoryId == categoryId);
        }

        public Product GetById(int id)
        {
            return _productDao.Get(p  =>  p.ProductId  ==  id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDao.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public void Update(Product entity)
        {
            _productDao.Update(entity);
        }
    }
}
