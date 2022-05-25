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
    public partial class StaffDetailSalaryProcessUpdate : Form
    {
        private SalaryProcess_DTO mSalaryProcess;

        public bool mOperationOk { get; set; }
        public StaffDetailSalaryProcessUpdate(SalaryProcess_DTO salaryProcess)
        {
            InitializeComponent();
            mSalaryProcess = salaryProcess;
            chkIsPaid.Checked = mSalaryProcess.is_paid;
            dtPaymentDate.Text = mSalaryProcess.payment_date;
            lblAmountSalary.Text = "Số tiền: " + mSalaryProcess.salary;
            lblMsg.Text = "Lương tháng: " + mSalaryProcess.title;

            if (mSalaryProcess.is_paid)
                btnConfirm.Enabled = false;
            else
                btnConfirm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string paymentDate = dtPaymentDate.Text;
            bool isPaid = chkIsPaid.Checked;

            SalaryProcess_DTO salaryProcess = Helper.Instance().Clone(mSalaryProcess);
            salaryProcess.is_paid = isPaid;
            salaryProcess.payment_date = paymentDate;

            KeyValuePair<bool, string> result = SalaryProcess_BUS.UpdateOne(salaryProcess);
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                UtilityLayer.Logging.Instance().LogInfo("Error: [StaffDetailSalaryProcess]:" + result.Value);
                return;
            }

            mOperationOk = true;
            this.Close();
            return;
        }
    }
}
