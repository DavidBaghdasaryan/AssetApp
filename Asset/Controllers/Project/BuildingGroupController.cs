using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class BuildingGroupController : Controller
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
        public IActionResult BuildingGroup(BuildingGroup bDProject)
        {
            _buildingGroupManager.Create(bDProject);
            return View(bDProject);
        }
    }
}
