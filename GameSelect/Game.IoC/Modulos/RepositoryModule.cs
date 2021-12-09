using Dominio.Service.Interfaces;
using Dominio.Service.Interfaces.Repository;
using Dominio.Service.Services;
using Game.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Game.IoC
{
    public class RepositoryModule
    {
        public static void SetModules(IServiceCollection container)
        {

            container.AddScoped<IGameRepository, GameRepository>();


        }
    }
}
