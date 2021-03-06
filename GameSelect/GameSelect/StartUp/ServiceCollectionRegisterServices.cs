using AutoMapper;
using Game.CrossCutting.IoC;
using Mercurio.WebApp.CrossCutting.AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace GameSelect.StartUp
{
    public static class ServiceCollectionRegisterServices
    {
        

        public static IServiceCollection StartRegisterServices(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(BootStrapperAutoMapper).Assembly);            
            GameBootstrapper.RegisterServices(services);

            //var defaultContainer = services.BuildServiceProvider();
            
            return services;
        }

    }
}
