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
    public partial class AccountAll : Form
    {
        private void LoadAccounts()
        {
            var result = Account_BUS.GetManyDisplay();
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            Helper.Instance().Bind(dgAccounts, result.Value);
            dgAccounts.Columns["account_type_id"].Visible = false;
            dgAccounts.Columns["group_type_id"].Visible = false;
            dgAccounts.Columns["id"].Visible = false;
        }

        public AccountAll()
        {
            InitializeComponent();
        }

        private void AccountAll_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void dgAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = e.RowIndex;
            if ( row_idx < 0) return;

            Account_DTO account = (Account_DTO)dgAccounts.CurrentRow.DataBoundItem;


            if (!Helper.Instance().AccountHas_Account_EditPermission(account))
            {
                MessageBox.Show("Tài khoản của bạn không có quyền thực hiện thao tác này");
                return;
            }

            AccountUpsert accountUpsert = new AccountUpsert(account);
            accountUpsert.ShowDialog();

            if (account.account_name == Helper.Instance().gAccount.account_name)
                Helper.Instance().gAccount = account;

            if (accountUpsert.mOperationOk)
            {
                LoadAccounts();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnFront_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AccountUpsert accountUpsert = new AccountUpsert();
            accountUpsert.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Helper.Instance().AccountHas_Account_AddPermission())
            {
                MessageBox.Show("Tài khoản của bạn không có quyền thực hiện thao tác này.");
                return;
            }

            AccountUpsert accountUpsert = new AccountUpsert();
            accountUpsert.ShowDialog();

            if (accountUpsert.mOperationOk)
            {
                LoadAccounts();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgAccounts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgAccounts.SelectedCells[0].RowIndex;
            Account_DTO account = (Account_DTO)dgAccounts.Rows[row_idx].DataBoundItem;
            if (!Helper.Instance().AccountHas_Account_EditPermission(account))
            {
                MessageBox.Show("Tài khoản của bạn không có quyền thực hiện thao tác này.");
                return;
            }

            AccountUpsert accountUpsert = new AccountUpsert(account);
            accountUpsert.ShowDialog();

            if (accountUpsert.mOperationOk)
            {
                LoadAccounts();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

            if (dgAccounts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgAccounts.SelectedCells[0].RowIndex;
            Account_DTO account = (Account_DTO)dgAccounts.Rows[row_idx].DataBoundItem;

            if (!Helper.Instance().AccountHas_Account_ResetPasswordPermission(account))
            {
                MessageBox.Show("Tài khoản chưa cấp quyền thực hiện tính năng này");
                return;
            }

            Account_DTO account_update = Helper.Instance().Clone<Account_DTO>(account);
            account_update.password = BCrypt.Net.BCrypt.HashPassword("00000000");

            AccountUpsertConfirm confirm = new AccountUpsertConfirm(account.password);
            confirm.ShowDialog();
            if (confirm.validate_ok)
            {
                KeyValuePair<bool, string> result = Account_BUS.UpdateOne(account_update);
                if (!result.Key)
                {
                    MessageBox.Show("Lỗi kết nối");
                    return;
                }

                Helper.Instance().gAccount = account_update;

                LoadAccounts();
                MessageBox.Show("Reset thành công về mật khẩu mặc định: 00000000");
            }
        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {

            if (dgAccounts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgAccounts.SelectedCells[0].RowIndex;
            Account_DTO account = (Account_DTO)dgAccounts.Rows[row_idx].DataBoundItem;
            if (!Helper.Instance().AccountHas_Account_ChangePasswordPermission(account))
            {
                MessageBox.Show("Tài khoản chưa được cấp quyền cho tính năng này");
                return;
            }

            AccountPasswordChange password_change = new AccountPasswordChange(account);
            password_change.ShowDialog();
            if (password_change.mIsOperationOk)
            {
                LoadAccounts();
                MessageBox.Show("Cập nhật mật khẩu thành công");
            }

            return;
        }
    }
}
