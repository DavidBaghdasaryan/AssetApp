using BusinessLogic.Manager.Abstraction;
using DAL.DBContex;
using DAL.Model;
using DAL.Model.Implementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Asset.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseProjectManager  baseProjectManager;
        private readonly AssetDBContex _context;
        public HomeController(ILogger<HomeController> logger, IBaseProjectManager _baseProjectManager, AssetDBContex context)
        {
            _logger = logger;
            baseProjectManager= _baseProjectManager;
            _context= context;
        }

        //public IActionResult Index()
        //{
           
        //    return View();
            
        //}
        public async Task<IActionResult> Index()
        {
            var projects = await _context.Projects
                .Include(p => p.BuildingGroups)
                    .ThenInclude(bg => bg.Buildings)
                        .ThenInclude(b => b.Rooms)
                            .ThenInclude(r => r.Elements)
                .ToListAsync();

            return View(projects);
        }
        public IActionResult Privacy()
        {
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
