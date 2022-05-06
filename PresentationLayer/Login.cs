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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txtPassword.Text;

            if (username.Length == 0)
            {
                lblErrorResponse.Text = "Tên đăng nhập bị trống";
                return;
            }
            else if (password.Length == 0)
            {
                lblErrorResponse.Text = "Mật khẩu bị trống";
                return;
            }

            lblErrorResponse.Text = "";


            //Account_DTO account = new Account_DTO();
            //account.account_name = username;
            //account.password = BCrypt.Net.BCrypt.HashPassword(password);
            //account.blocked = false;
            //account.account_type_id = 1;
            //account.group_type_id = 1;

            //var ret = BussinessLogicLayer.Account_BUS.InsertOne(account);
            //return;


            KeyValuePair<bool, Account_DTO> result = BussinessLogicLayer.Account_BUS.GetOne("account_name", username);
            if (result.Key == false)
            {
                lblErrorResponse.Text = "Không tìm thấy tài khoản";
                return;
            }

            Helper.Instance().gIsLogin = true;
            Helper.Instance().gAccount = result.Value;

            string verify_password = Helper.Instance().gAccount.password;
            bool verified = BCrypt.Net.BCrypt.Verify(password, verify_password);
            
            if (!verified)
            {
                lblErrorResponse.Text = "Mật khẩu không chính xác";
                return;
            }

            UtilityLayer.Logging.Instance().LogInfo("Log auth [Login]: " + username);

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pgbLogin.Value += 1;
            if (pgbLogin.Value == 100)
            {
                timer.Stop();

                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
