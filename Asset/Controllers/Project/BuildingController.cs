using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class BuildingController : Controller
    {
        private readonly IBuildingManager _buildingManager;
        private readonly AssetDBContex _context;
        public BuildingController(AssetDBContex context, IBuildingManager buildingManager)
        {
            _context = context;
            _buildingManager = buildingManager;
        }
        public IActionResult Building(int prodId)
        {
            Building building = new();
            building.BuildingGroupId = prodId;
            return View(building);
        }
        [HttpPost]
        public IActionResult Building(Building  building)
        {
            _buildingManager.Create(building);
            return View(building);
        }
    }
}
