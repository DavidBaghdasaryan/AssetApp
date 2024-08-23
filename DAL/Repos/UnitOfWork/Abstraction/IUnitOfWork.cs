using DAL.Repos.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.UnitOfWork.Abstraction
{
    public interface IUnitOfWork
    {
       IBaseProjectRepo BaseProject { get; }
       IBuildingGroupRepo  BuildingGroup { get; }
       IBuildingRepo  Building { get;  }
       IElementRepo Element{ get;  }
       IRoomRepo Room { get;  }

        void Save();
    }
}
