using System;
using Game.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace Mercurio.WebMvc.StartUp
{
    public static class ServiceCollectionDbContext
    {
        public static IServiceCollection StartDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var serverVersion = new MySqlServerVersion(new Version(5, 7, 27));

            services.AddDbContextPool<GameContext>(
                options => options.UseMySql(configuration.GetConnectionString("GameDB"), serverVersion,
                    mySqlOptions =>
                    {                       
                        options.ConfigureWarnings(warnings => warnings.Throw(CoreEventId.CascadeDelete));
                        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                        options.EnableDetailedErrors();                        
                    }
                ));


                
            return services;
        }
    }
}
