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
    public partial class CategoryDetailSalaryProcessUpsert : Form
    {
        private SalaryProcess_DTO mSalaryProcess;
        public bool mOperationOk = false;
        public bool mIsInsert = false;
        
        public CategoryDetailSalaryProcessUpsert(int staff_info_id)
        {
            InitializeComponent();
            mSalaryProcess = new SalaryProcess_DTO();
            mSalaryProcess.staff_info_id = staff_info_id;
            mIsInsert = true;
            dtTitle.Format = DateTimePickerFormat.Custom;
            dtTitle.CustomFormat = "MM/yyyy";
        }

        public CategoryDetailSalaryProcessUpsert(SalaryProcess_DTO salaryProcess)
        {
            InitializeComponent();
            mSalaryProcess = salaryProcess;
            dtTitle.Format = DateTimePickerFormat.Custom;
            dtTitle.CustomFormat = "MM/yyyy";

            dtTitle.Text = mSalaryProcess.title;
            ckbIsPaid.Checked = mSalaryProcess.is_paid;
            dtPaymentDate.Text = mSalaryProcess.payment_date;
            nudSalary.Value = mSalaryProcess.salary;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            string title = dtTitle.Text;
            bool isPaid = ckbIsPaid.Checked;
            string paymentDate = dtPaymentDate.Text;
            decimal salary = nudSalary.Value;

            SalaryProcess_DTO upsertSalary = Helper.Instance().Clone<SalaryProcess_DTO>(mSalaryProcess);
            upsertSalary.title = title;
            upsertSalary.is_paid = isPaid;
            upsertSalary.payment_date = paymentDate;
            upsertSalary.salary = salary;

            KeyValuePair<bool, string> result;
            if (mIsInsert)
            {
                result = SalaryProcess_BUS.InsertOne(upsertSalary);
            }
            else
            {
                result = SalaryProcess_BUS.UpdateOne(upsertSalary);
            }

            if (!result.Key)
            {
                lblErrorMsg.Text = "Lỗi kết nối";
                UtilityLayer.Logging.Instance().LogInfo(result.Value);
                return;
            }

            mOperationOk = true;
            this.Close();
            return;
        }
    }
}
