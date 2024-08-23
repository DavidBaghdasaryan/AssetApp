using BusinessLogic.Manager.Abstraction;
using DAL.Model;
using DAL.Repos.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.Implementation
{
    public class BaseProjectManager: IBaseProjectManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public BaseProjectManager(IUnitOfWork unitOfWork)
        {
             _unitOfWork = unitOfWork;
        }
        public void Create(BDProject bDProject)
        {
            _unitOfWork.BaseProject.Add(bDProject);
            _unitOfWork.Save();
        }
        public void Update(BDProject bDProject)
        {
            _unitOfWork.BaseProject.Update(bDProject);
            _unitOfWork.Save();
        }
        public void Delete(BDProject bDProject)
        {
            _unitOfWork.BaseProject.Remove(bDProject);
            _unitOfWork.Save();
        }

        public BDProject GetItemById(int id)
        {
           return   _unitOfWork.BaseProject.Get(x=>x.ProjectId==id);
        }
    }
}
