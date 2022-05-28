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
    public partial class StaffDetailTimeKeepingProcess : Form
    {
        private StaffInfo_DTO mStaffInfo;
        private int mCountAccomplishDate;
        private int mCountDateInMonth;
        private int mMonth;
        private int mYear;
        private string mMonthYear;
        private int mCountTargetDate;

        Dictionary<string, bool> mInitialDates = new Dictionary<string, bool>();
        Dictionary<string, bool> mUpdateDates  = new Dictionary<string, bool>();

        static int NumberOfParticularDaysInMonth(int year, int month, DayOfWeek dayOfWeek)
        {
            DateTime startDate = new DateTime(year, month, 1);
            int totalDays = startDate.AddMonths(1).Subtract(startDate).Days;

            int answer = Enumerable.Range(1, totalDays)
                .Select(item => new DateTime(year, month, item))
                .Where(date => date.DayOfWeek == dayOfWeek)
                .Count();

            return answer;
        }

        private bool TryInsertSalaryProcessForCurrentMoth()
        {
            SalaryProcess_DTO salary_process = new SalaryProcess_DTO();
            salary_process.staff_info_id = mStaffInfo.id;
            salary_process.title = mMonthYear;
            salary_process.is_paid = false;
            salary_process.payment_date = "";
            salary_process.salary = mStaffInfo.basic_salary_amount + mStaffInfo.basic_salary_amount + mStaffInfo.insurance_amount;
            KeyValuePair<bool, string> result = SalaryProcess_BUS.InsertIfNotExist(salary_process, "title", mMonthYear);
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối, xin thử lại");
                UtilityLayer.Logging.Instance().LogInfo("Error: [StaffDetailSalaryProcess.cs]:" + result.Value);
                return false;
            }

            return true;
        }

        private TableLayoutPanel GenPanel(string date, bool status)
        {
            TableLayoutPanel layoutPanel = new TableLayoutPanel();
            layoutPanel.RowCount = 4;
            layoutPanel.ColumnCount = 1;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            Label lblDate = new Label();
            CheckBox checkbox = new CheckBox();
            lblDate.Text = date;
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            lblDate.Dock = DockStyle.Fill;
            checkbox.Dock = DockStyle.Fill;
            checkbox.CheckAlign = ContentAlignment.MiddleCenter;
            checkbox.Cursor = Cursors.Hand;
            checkbox.Checked = status;
            checkbox.Click += (object sender, EventArgs e) =>
            {
                bool canAdd = false, outValue = false;
                bool ok = mInitialDates.TryGetValue(date, out outValue);
                if (!ok)
                {
                    canAdd = true;
                }

                if (checkbox.Checked != outValue)
                {
                    canAdd = true;
                }

                if (canAdd)
                {
                    mUpdateDates[date] = checkbox.Checked;
                }
            };

            layoutPanel.Controls.Add(lblDate, 0, 1);
            layoutPanel.Controls.Add(checkbox, 0, 2);
            return layoutPanel;
        }

        private void DrawTimeKeepingTable()
        {
            int month = dtTimekeeping.Value.Month;
            int year = dtTimekeeping.Value.Year;
            if (month == mMonth && year == mYear)
                return;

            mMonth = month; mYear = year;
            int datesInMonth = DateTime.DaysInMonth(year, month);

            int cols = tblTimeKeeping.ColumnCount;
            int rows = tblTimeKeeping.RowCount;
            int date_count = 0;
            tblTimeKeeping.Controls.Clear();
            string date_string = "";
            string month_year = dtTimekeeping.Value.ToString("MM/yyyy");
            mMonthYear = month_year;
            KeyValuePair<bool, List<TimekeepingProcess_DTO>> list_timekeeping = TimekeepingProcess_BUS.GetMany(
                "select * from TimekeepingProcess where timekeeping_date like @timekeepingdate order by timekeeping_date ASC",
                sqlCommand => {
                    sqlCommand.Parameters.AddWithValue("@timekeepingdate", '%' + month_year);
                }
            );

            if (!list_timekeeping.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            mCountAccomplishDate = list_timekeeping.Value.Count;
            mCountDateInMonth = datesInMonth;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (++date_count <= datesInMonth)
                    {
                        bool found = false;
                        date_string = (new DateOnly(year, month, date_count).ToString("dd/MM/yyyy"));
                        foreach (var obj in list_timekeeping.Value)
                        {
                            if (obj.timekeeping_date == date_string)
                            {
                                tblTimeKeeping.Controls.Add(GenPanel(date_string, obj.timekeeping_status), j, i);
                                found = true;

                                mInitialDates.Add(obj.timekeeping_date, obj.timekeeping_status);
                                break;
                            }
                        }

                        if (found == false)
                        {
                            tblTimeKeeping.Controls.Add(GenPanel(date_string, false), j, i);
                        }
                    }
                }
            }
        }

        public StaffDetailTimeKeepingProcess(StaffInfo_DTO staffInfo)
        {
            InitializeComponent();
            mStaffInfo = staffInfo;
        }

        private void StaffTimeKeepingProcess_Load(object sender, EventArgs e)
        {
            dtTimekeeping.Format = DateTimePickerFormat.Custom;
            dtTimekeeping.CustomFormat = "MM/yyyy";
            DrawTimeKeepingTable();
            int numOfSunday = NumberOfParticularDaysInMonth(this.mYear, this.mMonth, DayOfWeek.Sunday);
            int numOfSaturday = NumberOfParticularDaysInMonth(this.mYear, this.mMonth, DayOfWeek.Saturday);

            mCountTargetDate = mCountDateInMonth - (numOfSaturday + numOfSunday);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<TimekeepingProcess_DTO> list = new List<TimekeepingProcess_DTO>();
            int countAdd = 0;
            int countMinus = 0;

            if (!Helper.Instance().AccountHas_Staff_EvaluateTimekeepingProcess())
            {
                MessageBox.Show("Tài khoản không có quyền thực hiện tính năng này");
                return;
            }

            foreach (var item in mUpdateDates)
            {
                list.Add(new TimekeepingProcess_DTO { staff_info_id = mStaffInfo.id, timekeeping_date = item.Key, timekeeping_status = item.Value, evaluated_by_id = Helper.Instance().gAccount.id });
                if (item.Value)
                {
                    countAdd += 1;
                }
                else
                {
                    countMinus -= 1;
                }
            }

            if (list.Count > 0)
            {
                KeyValuePair<bool, string> result = TimekeepingProcess_BUS.UpsertMany(list);
                if (!result.Key)
                {
                    MessageBox.Show("Cập nhật thất bại");
                    UtilityLayer.Logging.Instance().LogInfo("[Error][StaffTimekeepingProceess][btnUpdateClick]: " + result.Value);
                    return;
                }
            }

            mCountAccomplishDate += countAdd + countMinus;
            if (mCountAccomplishDate >= mCountTargetDate)
            {
                bool ok = TryInsertSalaryProcessForCurrentMoth();
                if (!ok)
                {
                    MessageBox.Show("Cập nhật thất bại, xin thử lại");
                    return;
                }
            }

            MessageBox.Show("Cập nhật thành công");
            mUpdateDates.Clear();
        }

        private void dtTimekeeping_ValueChanged(object sender, EventArgs e)
        {
            DrawTimeKeepingTable();
        }
    }
}
