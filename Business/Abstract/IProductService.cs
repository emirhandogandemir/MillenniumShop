using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService:IEntityService<Product>
    {
        List<Product> GetAllByCategoryId(Category category);
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
