using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer
{
    public partial class StaffDetailReport : Form
    {
        private StaffInfo_DTO mStaffInfo;
        public StaffDetailReport(StaffInfo_DTO staffInfo)
        {
            mStaffInfo = staffInfo;
            InitializeComponent();
        }
    }
}
