using DAL.Model.Implementation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public interface IUpdateControllers<T>
    {
        IActionResult Update(int? id, T item);
    }
}
