using BusinessLogic.Manager.Abstraction;
using DAL.Model.Implementation;
using DAL.Repos.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.Implementation
{
    public class RoomManager : IRoomManager
    {

        private readonly IUnitOfWork _unitOfWork;
        public RoomManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Room room)
        {
            _unitOfWork.Room.Add(room);
        }

        public void Delete(Room  room)
        {
            _unitOfWork.Room.Remove(room);
        }

        public Room GetItemById(int id)
        {
           return _unitOfWork.Room.Get(x=>x.RoomId==id);
        }

        public void Update(Room room)
        {
            _unitOfWork.Room.Update(room);
        }
    }
}
