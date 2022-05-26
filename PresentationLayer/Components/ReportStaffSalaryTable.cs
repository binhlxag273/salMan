using BussinessLogicLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer.Components
{
    public partial class ReportStaffSalaryTable : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportStaffSalaryTable()
        {
            InitializeComponent();
        }

        public void BindData(StaffInfo_DTO staffInfo, SalaryProcess_DTO salaryProcess)
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

            lbTotal.Text = (display.basic_salary_amount + display.allowance_amount + display.insurance_amount).ToString();
            lbMonthYear.Text = salaryProcess.title;
            DateTime paymentDate = DateTime.Parse(salaryProcess.payment_date);
            lblPaymentDate.Text = paymentDate.Day + "/" + paymentDate.Month + "/" + paymentDate.Year;

            DateTime today = DateTime.Now;
            lbDataTime.Text = !salaryProcess.is_paid ? "An Giang, ngày ..., tháng ..., năm ..." : "An Giang, ngày " + today.Day + ", tháng " + today.Month + ", năm " + today.Year;
        }
    }
}
