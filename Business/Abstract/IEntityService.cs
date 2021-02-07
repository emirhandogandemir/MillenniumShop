using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Business.Abstract
{
   public interface IEntityService <T> where T: class , IEntity,new()
   {
       void Add(T entity);
       void Update(T entity);
       void Delete(T entity);
       List<T> GetAll();
       T GetById(int id);

   }
}
