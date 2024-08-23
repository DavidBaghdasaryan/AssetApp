using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class RoomController : Controller
    {
        private readonly IRoomManager _roomManager;
        private readonly AssetDBContex _context;
        public RoomController(IRoomManager RoomManager, AssetDBContex context)
        {
            _context = context;
            _roomManager = RoomManager;
        }
        public IActionResult Room(int prodId)
        {
            Room room = new();
            room.BuildingId = prodId;
            return View(room);
        }
        [HttpPost]
        public IActionResult Room(Room room)
        {
            _roomManager.Create(room);
            return View(room);
        }
    }
}
