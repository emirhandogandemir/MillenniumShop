using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
   public class ProductNameAndUnitsInStock : IDto
    {
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
