using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace NorthWind.Writters
{
    internal class FileWriter :Entities.Interfacess.IUserActionWriter
    {
        public void Write(UserAction action)
        {
            File.AppendAllText("AppLogs.txt",
                string.Format("FileWriter: {0 },{1 },{2}",
                action.CreatedDateTime, action.User, action.Description));
                
        }
}
}
