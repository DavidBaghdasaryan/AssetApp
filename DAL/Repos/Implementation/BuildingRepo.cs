using DAL.DBContex;
using DAL.Model;
using DAL.Repos.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Implementation
{
    public class BuildingRepo : BaseRepo<Building>, IBuildingRepo
    {
        private AssetDBContex _db;
        public BuildingRepo(AssetDBContex db) : base(db)
        {
            _db = db;
        }
    }
}
