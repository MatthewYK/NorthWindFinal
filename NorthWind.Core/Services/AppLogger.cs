using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Core.Services
{
    internal class AppLogger(Ienumerable<IUserActionWriter> writer)
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach (var Writer in writers)
                Writer.WriteLog(Log);


        }
    }
}
