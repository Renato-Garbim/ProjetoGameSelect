using Dominio.Service.Interfaces;
using Dominio.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Game.IoC
{
    public class ServiceModule
    {
        public static void SetModules(IServiceCollection container)
        {            
            container.AddScoped<IGameService, GameService>();
            container.AddScoped<ICompeticaoService, CompeticaoService>();

        }
    }
}
