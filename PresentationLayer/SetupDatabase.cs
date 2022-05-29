using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SetupDatabase : Form
    {
        public bool mIsOperationOk { get; set; } = false;

        public SetupDatabase()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string host = txbHost.Text;
            string port = txbPort.Text;
            string initDb = txbPort.Text;
            string userId = txbPort.Text;
            string password = txbPassword.Text;

            if (host.Length == 0 || port.Length == 0 || initDb.Length == 0 || userId.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Dữ liệu yêu cầu bị trống");
                return;
            }

            StreamWriter write = new StreamWriter("config.txt");
            write.WriteLine("host=:" + host);
            write.WriteLine("port=:" + port);
            write.WriteLine("initDb=:" + initDb);
            write.WriteLine("userId=:" + userId);
            write.WriteLine("password=:" + password);
            write.Close();

            mIsOperationOk = true;
            this.Close();
        }
    }
}
