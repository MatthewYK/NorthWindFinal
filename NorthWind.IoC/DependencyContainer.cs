using NorthWind.Writters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.IoC
{
    public static class DependencyContainer
    {
        public static IserviceCollection AddNorthWindServices(
           this IserviceCollection services)
        {
            services.AddDebugWriter();
            services.AddDebugWriter(9);
            return services;
        }
    }
}
