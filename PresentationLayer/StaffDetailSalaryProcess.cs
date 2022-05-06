using BussinessLogicLayer;
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
    public partial class StaffDetailSalaryProcess : Form
    {
        private StaffInfo_DTO mStaffinfo;

        private void LoadSalaryProcesses()
        {
            KeyValuePair<bool, List<SalaryProcess_DTO>> result = SalaryProcess_BUS.GetMany();
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }
        }
        public StaffDetailSalaryProcess(StaffInfo_DTO staffInfo)
        {
            mStaffinfo = staffInfo;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
