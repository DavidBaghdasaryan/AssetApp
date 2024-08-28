using BusinessLogic.Helpers;
using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class ElementController : Controller, IUpdateControllers<Element>
    {
        private readonly IElementManager _elementManager;
        private readonly AssetDBContex _context;
        public ElementController(IElementManager elementManager, AssetDBContex context)
        {
            _context = context;
            _elementManager = elementManager;
        }

        public IActionResult Delete(int id)
        {
            var element = _elementManager.GetItemById(id);
            if (element != null)
            {
                _elementManager.Delete(element);
                return Ok(new { success = true, message = "Element  deleted successfully." });
            }
            else
            {
                return BadRequest(new { success = false, message = "Failed to delete the  Element." });
            }
        }

        public IActionResult Element(int prodId)
        {
            Element element = new();
            element.RoomId = prodId;
            return View(element);
        }

        [HttpPost]
        public IActionResult Element(Element element)
        {
            _elementManager.Create(element);
            return View(element);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var element = _elementManager.GetItemById(id);
            element.IsUpdated = true;
            return View("Element", element);
        }

        [HttpPost]
        public IActionResult Update(Element element)
        {
            _elementManager.Update(element);
            return View("/Views/Home/Index.cshtml", _elementManager.GetAll());
        }
    }
}
