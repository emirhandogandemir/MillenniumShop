using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.CheckPerson
{
   public interface IPersonCheckService<T> where T: class ,IEntity ,new()
   {
       bool CheckIfRealPerson(T entity);

   }
}
