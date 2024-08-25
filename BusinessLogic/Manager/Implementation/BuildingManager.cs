using BusinessLogic.Manager.Abstraction;
using DAL.Model.Implementation;
using DAL.Repos.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.Implementation
{
    public class BuildingManager : IBuildingManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public BuildingManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Building building)
        {
            _unitOfWork.Building.Add(building);
        }

        public void Delete(Building building)
        {
            _unitOfWork.Building.Remove(building);
        }

        public Building GetItemById(int id)
        {
           return _unitOfWork.Building.Get(x=>x.BuildingId==id);
        }

        public void Update(Building building)
        {
            _unitOfWork.Building.Update(building);
        }
    }
}
