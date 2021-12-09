using Dominio.Service.Interfaces;
using Dominio.Service.Interfaces.Repository;
using Dominio.Service.Services;
using Game.Application.Interface;
using Game.Application.Services;
using Game.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Game.IoC
{
    public class ApplicationModule
    {
        public static void SetModules(IServiceCollection container)
        {

            container.AddScoped<IJogoAppService, JogoAppService>();


        }
    }
}
