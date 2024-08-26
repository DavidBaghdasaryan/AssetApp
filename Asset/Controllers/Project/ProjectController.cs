using BusinessLogic.Helpers;
using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
{

    public class ProjectController : Controller, IUpdateControllers<BDProject>
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
        public IActionResult BaseProject()
        {
            BDProject project = new BDProject();
            return View(project);
        }

        [HttpPost]
        public IActionResult BaseProject(BDProject bDProject)
        {
            if(bDProject.ProjectId>0)
            _baseProjectManager.Update(bDProject);
            else
                _baseProjectManager.Create(bDProject);
            return View(bDProject);
        }
        [HttpGet]
        public  IActionResult Update(int id)
        {
            if (ModelState.IsValid)
            {
                var bDProject = _baseProjectManager.GetItemById(id);
                bDProject.IsUpdated = true;
                return View("BaseProject", bDProject);
            }
            else
            { return NotFound(); }
        }

        [HttpPost]
        public IActionResult Update( BDProject bDProject)
        {
            _baseProjectManager.Update(bDProject);
            var list = _baseProjectManager.GetAll();
            return View("/Views/Home/Index.cshtml", _baseProjectManager.GetAll());
        }
    }
}
