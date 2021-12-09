using Game.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.CrossCutting.IoC
{
    public class GameBootstrapper
    {
        public static void RegisterServices(IServiceCollection container)
        {
            RepositoryModule.SetModules(container);
            ServiceModule.SetModules(container);
            ApplicationModule.SetModules(container);

        }
    }
}
