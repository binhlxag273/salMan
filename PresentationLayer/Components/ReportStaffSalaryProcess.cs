using BussinessLogicLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer.Components
{
    public partial class ReportStaffSalaryProcess : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportStaffSalaryProcess()
        {
            InitializeComponent();
        }

        public void BindData(StaffInfo_DTO staffInfo)
        {
            KeyValuePair<bool, StaffInfo_Display_DTO> result = StaffInfo_BUS.GetOneDisplay(staffInfo);
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                UtilityLayer.Logging.Instance().LogInfo("Error: [ReportStaffSalaryTable][BindData]: cannot get data");

                return;
            }

            StaffInfo_Display_DTO display = result.Value;
            lbStaffCode.Text = display.code;
            lbStaffName.Text = display.name;
            lbBirthPlace.Text = display.birth_place;
            DateTime birthDate = DateTime.Parse(display.birth_date);
            lbBirthDate.Text = birthDate.Day + "/" + birthDate.Month + "/" + birthDate.Year;
            lbEmail.Text = display.email;
            lbDepartment.Text = display.department_ext;
            lbPosition.Text = display.position_ext;
            DateTime startWorkingDate = DateTime.Parse(display.start_working_date);
            lbStartWorkingDate.Text = startWorkingDate.Day + "/" + startWorkingDate.Month + "/" + startWorkingDate.Year;

            DateTime today = DateTime.Now;
            lbDataTime.Text = "An Giang, ngày " + today.Day + ", tháng " + today.Month + ", năm " + today.Year;
        }
    }
}
