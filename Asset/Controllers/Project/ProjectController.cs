using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using DAL.DBContex;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers.Project
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
        public  IActionResult BaseProject(int? id,BDProject bDProject)
        {
            bDProject= _baseProjectManager.GetItemById(id.Value);
            return View(bDProject);
        }
    }
}
