using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{
    public class ElementController : Controller
    {
        private readonly IElementManager _elementManager;
        private readonly AssetDBContex _context;
        public ElementController(IElementManager elementManager, AssetDBContex context)
        {
            _context = context;
            _elementManager = elementManager;
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
    }
}
