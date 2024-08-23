using BusinessLogic.Manager.Abstraction;
using DAL.Model;
using DAL.Repos.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.Implementation
{
    public class ElementManager : IElementManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElementManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Element element)
        {
            _unitOfWork.Element.Add(element);
        }

        public void Delete(Element element)
        {
            _unitOfWork.Element.Remove(element);
        }

        public void Update(Element element)
        {
            _unitOfWork.Element.Update(element);
        }
    }
}
