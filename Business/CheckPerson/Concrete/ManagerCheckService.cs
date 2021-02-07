using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abtsract;
using Entities.Concrete;

namespace Business.CheckPerson.Concrete
{
    public class ManagerCheckService : IPersonCheckService<Manager>
    {
        private IManagerDao _managerDao;

        public ManagerCheckService(IManagerDao managerDao)
        {
            _managerDao = managerDao;
        }

        public bool CheckIfRealPerson(Manager entity)
        {
            foreach (var manager in _managerDao.GetAll())
            {
                if ((manager.ManagerName == entity.ManagerName) && (manager.ManagerPassword == entity.ManagerPassword))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
