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
        public void Create()
        {
          
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
