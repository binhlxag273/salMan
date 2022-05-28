using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class Helper
    {
        private Helper mInstance;

        private Helper()
        {

        }

        public Helper Instance()
        {
            if (mInstance == null)
            {
                mInstance = new Helper();
            }

            return mInstance;
        }


    }
}
