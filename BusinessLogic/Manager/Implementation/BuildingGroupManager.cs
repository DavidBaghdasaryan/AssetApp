﻿using BusinessLogic.Manager.Abstraction;
using DAL.Model;
using DAL.Repos.UnitOfWork.Abstraction;
using DAL.Repos.UnitOfWork.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.Implementation
{
    public class BuildingGroupManager : IBuildingGroupManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public BuildingGroupManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(BuildingGroup buildingGroup)
        {
            _unitOfWork.BuildingGroup.Add(buildingGroup);   
            _unitOfWork.Save();
        }

        public void Delete(BuildingGroup buildingGroup)
        {
            _unitOfWork.BuildingGroup.Remove(buildingGroup);
            _unitOfWork.Save();
        }

        public BuildingGroup GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(BuildingGroup buildingGroup)
        {
            _unitOfWork.BuildingGroup.Update(buildingGroup);
            _unitOfWork.Save();
        }
    }
}
