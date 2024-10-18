using NorthWind.Writters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Core.Services
{
    internal class DependencyContainer
    {
        public static IserviceCollection AddNorthWindServices(
            this IserviceCollection services)
        {
            services.AddSingleton<IAppLogger, AppLogger>();
            services.AddSingleton<IProductService, ProductService>();
            return services;
        }
    }

    internal interface IProductService
    {
    }
}
