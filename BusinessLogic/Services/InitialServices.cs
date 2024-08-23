using BusinessLogic.Manager.Abstraction;
using BusinessLogic.Manager.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public static partial class InitialServices
    {
        public static void Init(this IServiceCollection services) 
        {
            services.AddScoped<IBaseProjectManager, BaseProjectManager>();
            services.AddScoped<IBuildingGroupManager, BuildingGroupManager>();
            services.AddScoped<IBuildingManager, BuildingManager>();
            services.AddScoped<IRoomManager, RoomManager>();
            services.AddScoped<IElementManager, ElementManager>();
        }
    }
}
