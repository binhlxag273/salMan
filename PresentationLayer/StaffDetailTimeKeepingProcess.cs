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
        private int mMonth;
        private int mYear;

        List<KeyValuePair<string, bool>> mDates = new List<KeyValuePair<string, bool>>();

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
                mDates.Add(new KeyValuePair<string, bool>(date, checkbox.Checked));
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
        }

        private void dtTimekeeping_ValueChanged(object sender, EventArgs e)
        {
            DrawTimeKeepingTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<TimekeepingProcess_DTO> list = new List<TimekeepingProcess_DTO>();
            mDates.ForEach(date =>
            {
                list.Add(new TimekeepingProcess_DTO { staff_info_id = mStaffInfo.id, timekeeping_date = date.Key, timekeeping_status = date.Value, evaluated_by_id = Helper.Instance().gAccount.id });
            });

            KeyValuePair<bool, string> result = TimekeepingProcess_BUS.InsertMany(list);
            if (!result.Key)
            {
                MessageBox.Show("Cập nhật thất bại");
                UtilityLayer.Logging.Instance().LogInfo("[Error][StaffTimekeepingProceess][btnUpdateClick]: " + result.Value);
                return;
            }

            MessageBox.Show("Cập nhật thành công");
            mDates.Clear();
        }
    }
}
