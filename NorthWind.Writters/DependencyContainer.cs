﻿using NorthWind.Entities.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writters
{
    internal class DependencyContainer
    {
        public static IserviceCollection AddConsoleWriter(this IserviceCollection services)
        {
            service.AddSingleton<IUserActionWriter, ConsoleWriter>();
            return services;
        }
        public static IserviceCollection AddDebugWriter(this IserviceCollection services)
        {
            service.AddSingleton<IUserActionWriter, DebugWriter>();
            return services;
        }
        public static IserviceCollection AddFileWriter(this IserviceCollection services)
        {
            service.AddSingleton<IUserActionWriter, FileWriter>();
            return services;
        }
    }

    public class IserviceCollection
    {
        public void AddDebugWriter()
        {
            throw new NotImplementedException();
        }

        public void AddDebugWriter(int v)
        {
            throw new NotImplementedException();
        }

        public void AddSingleton<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}
