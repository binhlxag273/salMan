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

namespace PresentationLayer
{
    public partial class ChildFormSetting : Form
    {
        public ChildFormSetting()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!Helper.Instance().AccountIsAdmin())
            {
                MessageBox.Show("Tài khoản chưa cấp quyền thực hiện tính năng này");
                return;
            }


            if (txbBackup.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng chọn thư mục sao lưu dữ liệu");
            }
            else
            {
                bool result = Setting_BUS.Backup(txbBackup.Text);
                if (result == true)
                {
                    MessageBox.Show("Sao lưu thành công");
                }
                else
                {
                    MessageBox.Show("Sao lưu thất bại");
                }
            }
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txbBackup.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txbRestore.Text = openFileDialog.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            if (!Helper.Instance().AccountIsAdmin())
            {
                MessageBox.Show("Tài khoản chưa cấp quyền thực hiện tính năng này");
                return;
            }

            if (txbRestore.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng chọn tệp khôi phục dữ liệu");
            }
            else
            {
                bool result = Setting_BUS.Restore(txbRestore.Text);
                if (result == true)
                {
                    MessageBox.Show("Khôi phục thành công");
                }
                else
                {
                    MessageBox.Show("Khôi phục thất bại");
                }
            }
        }
    }
}
