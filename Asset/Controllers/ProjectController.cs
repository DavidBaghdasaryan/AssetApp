using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IBaseProjectManager _baseProjectManager;
        private readonly AssetDBContex _context;
        public ProjectController(AssetDBContex context, IBaseProjectManager baseProjectManager)
        {
            _context = context;
            _baseProjectManager = baseProjectManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpSert()
        {
            BDProject project = new BDProject();    
            return View(project);
        }

        [HttpPost]
        public IActionResult UpSert(BDProject bDProject)
        {
            _baseProjectManager.Create(bDProject);
            return View(bDProject);
        }
    }
}
