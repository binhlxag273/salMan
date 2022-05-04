using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AccountUpsertConfirm : Form
    {
        private string mValidatePassword;

        public bool validate_ok = false;
        public AccountUpsertConfirm()
        {
            InitializeComponent();
        }

        public AccountUpsertConfirm(string validate_password)
        {
            InitializeComponent();
            mValidatePassword = validate_password;
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            bool verified = BCrypt.Net.BCrypt.Verify(txbConfirmPassword.Text, Helper.Instance().gAccount.password);
            if (!verified)
            {
                lblErrorResponse.Text = "Mật khẩu xác thực không chính xác";
                return;
            }

            validate_ok = true;
            this.Close();
        }
    }
}
