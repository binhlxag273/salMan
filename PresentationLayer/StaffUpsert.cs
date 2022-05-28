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
    public partial class StaffUpsert : Form
    {
        private StaffInfo_DTO mStaffInfo;
        public bool mIsInsert = false;
        public bool mOperationOk = false;

        private Account_DTO GenAccount()
        {
            Account_DTO acc = new Account_DTO();
            acc.account_type_id = 2;
            acc.group_type_id = 5;
            acc.blocked = false;
            acc.account_name = mStaffInfo.email;
            acc.password = BCrypt.Net.BCrypt.HashPassword("00000000");
            acc.validated = false;

            return acc;
        }

        private void StaffUpsert_Load(object sender, EventArgs e)
        {
            KeyValuePair<bool, List<CategoryDetail_DTO>> departments = CategoryDetail_BUS.GetMany("category_id", "03");
            if (!departments.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            cbxDepartment.DisplayMember = "name";
            cbxDepartment.ValueMember = "id";
            cbxDepartment.DataSource = departments.Value;

            KeyValuePair<bool, List<CategoryDetail_DTO>> positions = CategoryDetail_BUS.GetMany("category_id", "04");
            if (!positions.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            cbxPosition.DisplayMember = "name";
            cbxPosition.ValueMember = "id";
            cbxPosition.DataSource = positions.Value;
        }

        public StaffUpsert()
        {
            InitializeComponent();
            mStaffInfo = new StaffInfo_DTO();
            mIsInsert = true;
        }

        public StaffUpsert(StaffInfo_DTO staffInfo)
        {
            InitializeComponent();
            mStaffInfo = staffInfo;
            txbCode.Text = mStaffInfo.code;
            txbName.Text = mStaffInfo.name;
            dtBirthDate.Text = mStaffInfo.birth_date;
            txbBirthPlace.Text = mStaffInfo.birth_place;
            txbEmail.Text = mStaffInfo.email;
            cbxDepartment.SelectedValue = mStaffInfo.department_id;
            cbxPosition.SelectedValue = mStaffInfo.position_id;
            dtStartWorkingDate.Text = mStaffInfo.start_working_date;
            ckbWorkingStatus.Checked = mStaffInfo.working_status;
            dtEndWorkingDate.Text = mStaffInfo.end_working_date;
            nudBasicSalary.Value = mStaffInfo.basic_salary_amount;
            nudIsuranceAmount.Value = mStaffInfo.insurance_amount;
            nudAllowanceAmount.Value = mStaffInfo.allowance_amount;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            string code = txbCode.Text;
            string name = txbName.Text;
            string birth_date = dtBirthDate.Value.ToString("yyyy-MM-dd");
            string birth_place = txbBirthPlace.Text;
            string email = txbEmail.Text;
            int department = Int32.Parse(cbxDepartment.SelectedValue.ToString());
            int position = Int32.Parse(cbxPosition.SelectedValue.ToString());

            string start_working_date = dtStartWorkingDate.Value.ToString("yyyy-MM-dd");
            string end_working_date = dtEndWorkingDate.Value.ToString("yyyy-MM-dd");

            bool working_status = ckbWorkingStatus.Checked;

            decimal basic_salary = nudBasicSalary.Value;
            decimal isurance_salary = nudIsuranceAmount.Value;
            decimal allowance_salary = nudAllowanceAmount.Value;

            if (code.Length == 0)
            {
                lblErrorMsg.Text = "Mã nhân viên không được trống";
                return;
            }

            if (name.Length == 0)
            {
                lblErrorMsg.Text = "Tên nhân viên không được trống";
                return;
            }

            if (email.Length == 0)
            {
                lblErrorMsg.Text = "Email không được trống";
                return;
            }
            else if (!Helper.Instance().IsValidEmail(email))
            {
                lblErrorMsg.Text = "Email không hợp lệ";
                return;
            }

            mStaffInfo.code = code;
            mStaffInfo.name = name;
            mStaffInfo.birth_date = birth_date;
            mStaffInfo.birth_place = birth_place;
            mStaffInfo.email = email;
            mStaffInfo.department_id = department;
            mStaffInfo.position_id = position;
            mStaffInfo.start_working_date = start_working_date;
            mStaffInfo.working_status = working_status;
            mStaffInfo.end_working_date = working_status ? end_working_date : "";
            mStaffInfo.working_status = working_status;
            mStaffInfo.basic_salary_amount = basic_salary;
            mStaffInfo.insurance_amount = isurance_salary;
            mStaffInfo.allowance_amount = allowance_salary;

            if (mIsInsert)
            {
                Account_DTO accountInsert = GenAccount();
                Tuple<bool, string, int> acc_ret = Account_BUS.InsertOneCount(accountInsert);
                if (!acc_ret.Item1)
                {
                    lblErrorMsg.Text = "Địa chỉ email đã được sử dụng";
                    UtilityLayer.Logging.Instance().LogInfo("[Error][StaffUpsert][btnUpsert_Click]: " + acc_ret.Item2);
                    return;
                }

                mStaffInfo.account_id = acc_ret.Item3;;
            }

            KeyValuePair<bool, string> result;
            StaffInfo_DTO staffClone = Helper.Instance().Clone(mStaffInfo);
            if (mIsInsert)
            {
                result = StaffInfo_BUS.InsertOne(staffClone);
            }
            else
            {
                result = StaffInfo_BUS.UpdateOne(staffClone);
            }

            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                UtilityLayer.Logging.Instance().LogInfo("[Error][StaffUpsert][btnUpert_Click]: " + result.Value);
                return;
            }

            mOperationOk = true;
            this.Close();
        }
    }
}
