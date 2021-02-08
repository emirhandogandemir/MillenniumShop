using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Core.Entities;


namespace Entities.Concrete
{
    public class Category : IEntity
    {
       
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public  virtual List<Product> Products { get; set; }
    }
}
