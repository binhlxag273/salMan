using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer
{
    public class Helper
    {
        private Helper()
        {

        }

        private static Helper _instance;

        public static Helper Instance()
        {
            if (_instance == null)
            {
                _instance = new Helper();
            }

            return _instance;
        }

        public bool gIsLogin { get; set; } = false;

        public Account_DTO gAccount { get; set; }
    }
}
