using Core.Business;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
   public interface IProductService:IEntityService<Product>
    {
        List<Product> GetAllByCategoryId(int categoryId);
        List<ProductDetailDto> GetProductDetails();
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductNameAndUnitsInStock> GetUnitsInStockProductName();
    }
}
