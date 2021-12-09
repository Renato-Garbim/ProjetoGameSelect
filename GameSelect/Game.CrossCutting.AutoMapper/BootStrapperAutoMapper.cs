using System;
using AutoMapper;
using Mercurio.WebApp.CrossCutting.AutoMapper.Profile;

namespace Mercurio.WebApp.CrossCutting.AutoMapper
{
    public static class BootStrapperAutoMapper
    {
        public static Action<IMapperConfigurationExpression> ConfigAction = new Action<IMapperConfigurationExpression>(
       cfg =>
       {
           cfg.AllowNullCollections = true;
           cfg.AllowNullDestinationValues = true;

           
           cfg.AddProfile<TabelasProfile>();
           
       });


        
        
    }
}