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
    public partial class AccountPasswordChange : Form
    {
        private Account_DTO mAccount;
        public bool mIsOperationOk = false;
        public AccountPasswordChange(Account_DTO account)
        {
            InitializeComponent();

            mAccount = account;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string old_password = txbOldPassword.Text;
            string new_password = txbNewPassword.Text;
            string confirm_password = txbConfirmPassword.Text;


            if (old_password.Length == 0)
            {
                lblErrorMsg.Text = "Mật khẩu cũ không được trống";
                return;
            }

            if (new_password.Length == 0)
            {
                lblErrorMsg.Text = "Mật khẩu mới không được trống";
                return;
            }

            if (confirm_password.Length == 0)
            {
                lblErrorMsg.Text = "Mật khẩu xác thực không được trống";
                return;
            }

            bool verified = BCrypt.Net.BCrypt.Verify(txbOldPassword.Text, Helper.Instance().gAccount.password);
            if (!verified)
            {
                lblErrorMsg.Text = "Mật khẩu cũ không chính xác";
                return;
            }

            if (new_password != confirm_password)
            {
                lblErrorMsg.Text = "Mật khẩu xác nhận không chính xác";
                return;
            }

            lblErrorMsg.Text = "";
            Account_DTO account_update = Helper.Instance().Clone<Account_DTO>(mAccount);
            account_update.password = BCrypt.Net.BCrypt.HashPassword(new_password);

            var result = Account_BUS.UpdateOne(account_update);
            if (!result.Key)
            {
                lblErrorMsg.Text = "Lỗi kết nối";
                return;
            }

            if (Helper.Instance().gAccount.id == mAccount.id)
                Helper.Instance().gAccount = mAccount;

            mIsOperationOk = true;
            this.Close();

            return;
        }
    }
}
