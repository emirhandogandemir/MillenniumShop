using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abtsract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ManagerManager : IManagerService
    {
        private IManagerDao _managerDao;

        public ManagerManager(IManagerDao managerDao)
        {
            _managerDao = managerDao;
        }

        public void Add(Manager manager)
        {
            _managerDao.Add(manager);
        }

        public void Delete(Manager manager)
        {
            _managerDao.Delete(manager);
        }

        public List<Manager> GetAll()
        {
            return _managerDao.GetAll();
        }

        public Manager GetById(int id)
        {
         return _managerDao.Get(manager => manager.ManagerId == id);
        }

        public void Update(Manager manager)
        {
            _managerDao.Update(manager);
        }
    }
}
