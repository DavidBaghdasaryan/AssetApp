using DAL.DBContex;
using DAL.Model.Implementation;
using DAL.Repos.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Implementation
{
    public class RoomRepo: BaseRepo<Room>, IRoomRepo
    {
        private AssetDBContex _db;
        public RoomRepo(AssetDBContex db) : base(db)
        {
            _db = db;
        }
    }
}
