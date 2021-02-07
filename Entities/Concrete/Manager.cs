using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concrete
{
    public class Manager : IEntity
    {
        
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerEMail { get; set; }
        public string ManagerSurname { get; set; }
        public string ManagerPassword { get; set; }
        public string ManagerPassword2 { get; set; }
        public string ManagerCity { get; set; }

    }
}
