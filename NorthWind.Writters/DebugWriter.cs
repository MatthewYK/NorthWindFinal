using NorthWind.Entities.Interfaces;
using NorthWind.Entities.Interfacess;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writters
{
    internal class DebugWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            DebugWriter.WriteLine("ConsoleWriter:{ 0},{ 1},{2}",
                action.CreatedDateTime, action.User, action.Description);
        }
    }
}
