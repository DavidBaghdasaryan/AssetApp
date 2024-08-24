using DAL.DBContex;
using DAL.Model.Implementation;
using DAL.Repos.Abstraction;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Implementation
{
    public class BaseProjectRepo : BaseRepo<BDProject>, IBaseProjectRepo
    {
        private AssetDBContex _db;
        public BaseProjectRepo(AssetDBContex db) : base(db)
        {
            _db = db;
        }
        public List<BDProject> GetList()
        {
            return _db.Projects
                         .Include(p => p.BuildingGroups)
                         .ThenInclude(x => x.Buildings)
                         .ThenInclude(x=>x.Rooms)
                         .ThenInclude(x=>x.Elements)
                         .ToList();
        }
    }
}
