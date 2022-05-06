using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer
{
    public partial class AccountUpsert : Form
    {
        private Account_DTO mAccount;
        public  bool mIsInsert = true;
        public bool mOperationOk = false;

        private void LoadComboboxData()
        {
            KeyValuePair<bool, List<CategoryDetail_DTO>> result = CategoryDetail_BUS.GetMany("category_id", "01");
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            cbxAccountType.DisplayMember = "name";
            cbxAccountType.ValueMember = "id";
            cbxAccountType.DataSource = result.Value;

            result = CategoryDetail_BUS.GetMany("category_id", "02");
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            cbxGroupType.DisplayMember = "name";
            cbxGroupType.ValueMember = "id";
            cbxGroupType.DataSource = result.Value;
        }

        public AccountUpsert()
        {
            InitializeComponent();
            LoadComboboxData();
            btnUpsert.Text = "Thêm";
            this.Text = "Thêm tài khoản";
            txbAccountName.Text = "";
            txbAccountName.Enabled = true;

            chkValidated.Checked = false;
            chkBlocked.Checked = false;

            lblErrorMsg.Text = "Tài khoản sẽ được tạo với mật khẩu mặc định là 00000000.\nLần đăng nhập đầu tiên sẽ bắt buộc thay đổi mật khẩu!";
            mAccount = new Account_Display_DTO();
            mAccount.password = BCrypt.Net.BCrypt.HashPassword("00000000");
        }

        public AccountUpsert(Account_DTO account)
        {
            InitializeComponent();
            LoadComboboxData();
            btnUpsert.Text = "Cập nhật";
            this.Text = "Cập nhật tài khoản";
            txbAccountName.Text = account.account_name;
            txbAccountName.Enabled = false;

            chkValidated.Checked = account.validated;
            chkBlocked.Checked = account.blocked;

            cbxAccountType.SelectedValue = account.account_type_id;
            cbxGroupType.SelectedValue = account.group_type_id;

            mAccount = account;
            lblErrorMsg.Text = "";
            mIsInsert = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            string account_name = txbAccountName.Text;

            bool validated = chkValidated.Checked;
            bool blocked = chkBlocked.Checked;
            int account_type_id = Int32.Parse(cbxAccountType.SelectedValue.ToString());
            int group_type_id = Int32.Parse(cbxGroupType.SelectedValue.ToString());

            if (account_name.Length == 0)
            {
                lblErrorMsg.Text = "Tên tài khoản bắt buộc nhập";
                return;
            }
            else if (!Helper.Instance().IsValidEmail(account_name))
            {
                lblErrorMsg.Text = "Tên tài khoản phải là email";
                return;
            }

            lblErrorMsg.Text = "";

            mAccount.account_name = account_name;
            mAccount.validated = validated;
            mAccount.blocked = blocked;
            mAccount.account_type_id = account_type_id;
            mAccount.group_type_id = group_type_id;


            AccountUpsertConfirm confirm = new AccountUpsertConfirm(mAccount.password);
            confirm.ShowDialog();
            if (!confirm.validate_ok) return;

            Account_DTO accountClone = Helper.Instance().Clone(mAccount);
            KeyValuePair<bool, string> result;
            if (mIsInsert)
            {
                result = Account_BUS.InsertOne(accountClone);
            }
            else
            {
                result = Account_BUS.UpdateOne(accountClone);
            }


            if (result.Key == false)
            {
                lblErrorMsg.Text = result.Value;
                return;
            }

            mOperationOk = true;
            this.Close();

            return;
        }
    }
}
