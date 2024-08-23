using DAL.DBContex;
using DAL.Model;
using DAL.Repos.Abstraction;
using DAL.Repos.Implementation;
using DAL.Repos.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private AssetDBContex _db;
        public IBaseProjectRepo BaseProject { get; private set; }
        public IBuildingGroupRepo BuildingGroup { get; private set; }
        public IBuildingRepo Building { get; private set; }
        public IRoomRepo Room { get; private set; }
        public IElementRepo Element { get; private set; }
        public UnitOfWork(AssetDBContex db)
        {
            _db = db;
            BaseProject = new BaseProjectRepo(_db);
            BuildingGroup= new BuildingGroupRepo(_db);
            Building = new BuildingRepo(_db);
            Room = new RoomRepo(_db);
            Element = new ElementRepo(_db);

        }

    


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
