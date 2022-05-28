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

            lbBasicSalary.Text = display.basic_salary_amount.ToString();
            lbAllowance.Text = display.allowance_amount.ToString();
            lbIssuance.Text = display.insurance_amount.ToString();

            DateTime today = DateTime.Now;
            lbDataTime.Text = "An Giang, ngày " + today.Day + ", tháng " + today.Month + ", năm " + today.Year;

            KeyValuePair<bool, List<SalaryProcess_DTO>> list_ret = SalaryProcess_BUS.GetMany();
            if (!list_ret.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                UtilityLayer.Logging.Instance().LogInfo("Error [ReportStaffSalaryProcess][BindData]: cannot get data");
                return;
            }

            objectDataSource1.DataSource = list_ret.Value;
        }
    }
}
