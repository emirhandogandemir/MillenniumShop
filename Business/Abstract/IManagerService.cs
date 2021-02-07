using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IManagerService :IEntityService<Manager>
   {

       List<Manager> GetByCode(string managerCode);

   }
}
