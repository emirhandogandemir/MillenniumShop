using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Dynamic;
using System.Text;


namespace Entities.Concrete
{
    public class Product : IEntity

    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }

    }
}
