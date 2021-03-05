using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
