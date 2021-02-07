using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.CheckPerson.Abstract
{
   public interface IManagerCheckService :IPersonCheckService<Manager>
    {

    }
}
