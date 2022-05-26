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

            Helper.Instance().Bind(dgSalaryProcess, result.Value);
            dgSalaryProcess.Columns["id"].Visible = false;
            dgSalaryProcess.Columns["staff_info_id"].Visible = false;
        }
        public StaffDetailSalaryProcess(StaffInfo_DTO staffInfo)
        {
            mStaffinfo = staffInfo;
            InitializeComponent();

            LoadSalaryProcesses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dgSalaryProcess_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = e.RowIndex;
            if (row_idx < 0) return;

            SalaryProcess_DTO salaryProcess = (SalaryProcess_DTO)dgSalaryProcess.Rows[row_idx].DataBoundItem;
            StaffDetailSalaryProcessUpdate salaryUpdate = new StaffDetailSalaryProcessUpdate(salaryProcess);
            salaryUpdate.ShowDialog();

            if (salaryUpdate.mOperationOk)
            {
                LoadSalaryProcesses();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSalaryProcess.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgSalaryProcess.SelectedCells[0].RowIndex;
            SalaryProcess_DTO salaryProcess = (SalaryProcess_DTO)dgSalaryProcess.Rows[row_idx].DataBoundItem;
            StaffDetailSalaryProcessUpdate salaryUpdate = new StaffDetailSalaryProcessUpdate(salaryProcess);
            salaryUpdate.ShowDialog();

            if (salaryUpdate.mOperationOk)
            {
                LoadSalaryProcesses();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgSalaryProcess.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgSalaryProcess.SelectedCells[0].RowIndex;
            SalaryProcess_DTO salaryProcess = (SalaryProcess_DTO)dgSalaryProcess.Rows[row_idx].DataBoundItem;
            frReportStaffSalaryTable report = new frReportStaffSalaryTable(mStaffinfo, salaryProcess);
            report.PrintReport();
            report.ShowDialog();
        }
    }
}
