using BusinessLogic.Helpers;
using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class BuildingController : Controller, IUpdateControllers<Building>
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
        [HttpGet]
        public IActionResult Update(int id, Building building)
        {
            building = _buildingManager.GetItemById(id);
            building.IsUpdated = true;
            return View("BaseProject", building);
        }

        [HttpPost]
        public IActionResult Update(Building building)
        {
            _buildingManager.Update(building);
            return View("Building", building);
        }
    }
}
