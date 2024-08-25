using BusinessLogic.Helpers;
using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class BuildingGroupController : Controller, IUpdateControllers<BuildingGroup>
    {
        private readonly IBuildingGroupManager _buildingGroupManager;
        private readonly AssetDBContex _context;
        public BuildingGroupController(AssetDBContex context, IBuildingGroupManager buildingGroupManager)
        {
            _context = context;
            _buildingGroupManager = buildingGroupManager;
        }
        public IActionResult BuildingGroup(int prodId)
        {
            BuildingGroup group = new();
            group.ProjectId = prodId;
            return View(group);
        }
        [HttpPost]
        public IActionResult BuildingGroup(BuildingGroup  buildingGroup)
        {
            _buildingGroupManager.Create(buildingGroup);
            return View(buildingGroup);
        }
        [HttpGet]
        public IActionResult Update(int id, BuildingGroup buildingGroup)
        {
            buildingGroup = _buildingGroupManager.GetItemById(id);
            buildingGroup.IsUpdated = true;
            return View("BuildingGroup", buildingGroup);
        }

        [HttpPost]
        public IActionResult Update(BuildingGroup buildingGroup)
        {
            _buildingGroupManager.Update(buildingGroup);
            return View("buildingGroup", buildingGroup);
        }
    }
}
