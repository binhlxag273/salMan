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
    public partial class StaffDetail : Form
    {
        private void ShowTabControl()
        {
            if (tabStaffDetail.SelectedTab == tabStaffDetail.TabPages["tabStaffTimekeeping"])
            {
                if (tabStaffTimekeeping.Controls.Count > 0) return;
                StaffDetailTimeKeepingProcess timekeeping = new StaffDetailTimeKeepingProcess(mStaffInfo);
                timekeeping.TopLevel = false;
                timekeeping.Width = tabStaffTimekeeping.Width;
                timekeeping.Height = tabStaffTimekeeping.Height;
                tabStaffTimekeeping.Controls.Add(timekeeping);
                timekeeping.Show();
            }
            else if (tabStaffDetail.SelectedTab == tabStaffDetail.TabPages["tabStaffStatistic"])
            {
                if (tabStaffStatistic.Controls.Count > 0) return;
                StaffDetailStatistic statistic = new StaffDetailStatistic(mStaffInfo);
                statistic.TopLevel = false;
                statistic.Width = tabStaffTimekeeping.Width;
                statistic.Height = tabStaffTimekeeping.Height;
                tabStaffStatistic.Controls.Add(statistic);
                statistic.Show();
            }
            else if (tabStaffDetail.SelectedTab == tabStaffDetail.TabPages["tabStaffSalaryProcess"])
            {
                if (tabStaffSalaryProcess.Controls.Count > 0) return;
                StaffDetailSalaryProcess salary = new StaffDetailSalaryProcess(mStaffInfo);
                salary.TopLevel = false;
                salary.Width = tabStaffTimekeeping.Width;
                salary.Height = tabStaffTimekeeping.Height;
                tabStaffSalaryProcess.Controls.Add(salary);
                salary.Show();
            }
            else if (tabStaffDetail.SelectedTab == tabStaffDetail.TabPages["tabStaffReport"])
            {
                if (tabStaffReport.Controls.Count > 0) return;
                StaffDetailReport report = new StaffDetailReport(mStaffInfo);
                report.TopLevel = false;
                report.Width = tabStaffTimekeeping.Width;
                report.Height = tabStaffTimekeeping.Height;
                tabStaffReport.Controls.Add(report);
                report.Show();
            }
        }

        private StaffInfo_DTO mStaffInfo;

        public StaffDetail(StaffInfo_DTO staffInfo)
        {
            mStaffInfo = staffInfo;
            InitializeComponent();
            ShowTabControl();
        }

        private void tabStaffDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTabControl();
        }
    }
}
