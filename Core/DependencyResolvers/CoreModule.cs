using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using System.Diagnostics;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();

        }
    }
}
