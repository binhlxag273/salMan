using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class Setting_BUS
    {
        public static bool Backup(string foldLocation)
        {
            return DataAccessLayer.DataProvider.Instance().Backup(foldLocation);
        }

        public static bool Restore(string fileLocation)
        {
            return DataAccessLayer.DataProvider.Instance().Restore(fileLocation);
        }
    }
}
