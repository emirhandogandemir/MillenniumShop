using DataAccess.Abtsract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfProductDao : EfEntityRepositoryBase<Product, MillenniumShopContext>, IProductDao
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var result = from p in context.Products
                    join c in context.Categories
                        on p.CategoryId equals c.CategoryId
                    select new ProductDetailDto
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName,
                        UnitPrice = p.UnitPrice,
                        UnitsInStock = p.UnitsInStock
                    };
                return result.ToList();
            }
        }

        public List<ProductNameAndUnitsInStock> GetUnitsInStockProductName()
        {
            using (MillenniumShopContext context = new MillenniumShopContext())
            {
                var result = from p in context.Products
                    select new ProductNameAndUnitsInStock
                    {
                        ProductName = p.ProductName,
                        UnitsInStock = p.UnitsInStock
                    };
                return result.ToList();
            }
        }
        //sor

    }
}
