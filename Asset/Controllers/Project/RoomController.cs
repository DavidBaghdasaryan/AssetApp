﻿using BusinessLogic.Helpers;
using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class RoomController : Controller, IUpdateControllers<Room>
    {
        private readonly IRoomManager _roomManager;
        private readonly AssetDBContex _context;
        public RoomController(IRoomManager RoomManager, AssetDBContex context)
        {
            _context = context;
            _roomManager = RoomManager;
        }

        public IActionResult Delete(int id)
        {
            var room = _roomManager.GetItemById(id);
            if (room != null) { 
                _roomManager.Delete(room);
                return Ok(new { success = true, message = "Room deleted successfully." });
            }
            else
            {
                return BadRequest(new { success = false, message = "Failed to delete the Room." });
            }
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

        [HttpGet]
        public IActionResult Update(int id)
        {
           var room = _roomManager.GetItemById(id);
            room.IsUpdated = true;
            return View("Room", room);
        }

        [HttpPost]
        public IActionResult Update(Room room)
        {
            _roomManager.Update(room);
            return View("/Views/Home/Index.cshtml", _roomManager.GetAll());
        }
    }
}
