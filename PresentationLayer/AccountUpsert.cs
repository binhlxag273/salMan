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
    public partial class AccountUpsert : Form
    {
        private Account_DTO mAccount;
        private bool isInsert = true;

        private void LoadComboboxData()
        {

        }

        private bool isValidateEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
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
            mAccount = new Account_DTO();
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

            mAccount = account;
            lblErrorMsg.Text = "";
            isInsert = false;
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

            if (account_name.Length == 0)
            {
                lblErrorMsg.Text = "Tên tài khoản bắt buộc nhập";
                return;
            }
            else if (!isValidateEmail(account_name))
            {
                lblErrorMsg.Text = "Tên tài khoản phải là email";
                return;
            }

            lblErrorMsg.Text = "";

            mAccount.account_name = account_name;
            mAccount.validated = validated;
            mAccount.blocked = blocked;

            AccountUpsertConfirm confirm = new AccountUpsertConfirm(mAccount.password);
            confirm.ShowDialog();
            if (!confirm.validate_ok) return;

            KeyValuePair<bool, string> result;
            if (isInsert)
            {
                result = BussinessLogicLayer.Account_BUS.AddOneAccount(mAccount);
            }
            else
            {
                result = BussinessLogicLayer.Account_BUS.UpdateOneAccount(mAccount);
            }


            if (result.Key == false)
            {
                lblErrorMsg.Text = "Lỗi kết nối";
            }

            if (isInsert)
            {
                if (result.Key)
                {
                    lblErrorMsg.Text = "Thêm thành công";
                }
            }
            else
            {
                if (result.Key)
                {
                    lblErrorMsg.Text = "Cập nhật thành công";
                }
            }

            return;
        }
    }
}
