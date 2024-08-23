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
    internal class BuildingGroupRepo: BaseRepo<BuildingGroup>, IBuildingGroupRepo
    {
        private AssetDBContex _db;
        public BuildingGroupRepo(AssetDBContex db) : base(db)
        {
            _db = db;
        }
    }
}
