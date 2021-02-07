using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concrete
{
   public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerPassword2 { get; set; }
        public string CustomerCity { get; set; }
    }
}
