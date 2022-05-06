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
            var result = BussinessLogicLayer.Account_BUS.GetManyDisplay();
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
            AccountUpsert accountUpsert = new AccountUpsert(account);
            accountUpsert.ShowDialog();

            if (accountUpsert.mOperationOk)
            {
                LoadAccounts();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Các dữ liệu liên quan đều sẽ bị xóa, bạn có muốn xóa không?", "Chú ý", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.No) return;

            if (dgAccounts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            bool[] counts = new bool[dgAccounts.Rows.Count];
            for (int i = 0; i < dgAccounts.SelectedCells.Count; ++i)
            {
                int row_idx = dgAccounts.SelectedCells[i].RowIndex;
                counts[row_idx] = true;
            }

            List<int> list_id = new List<int>();
            for (int i = 0; i < counts.Length; ++i)
            {
                if (counts[i]) list_id.Add(Int32.Parse(dgAccounts.Rows[i].Cells["id"].Value.ToString()));
            }

            KeyValuePair<bool, string> result = Account_BUS.DeleteMany(list_id);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
                return;
            }

            LoadAccounts();
            MessageBox.Show("Xóa thành công");
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
            AccountPasswordChange password_change = new AccountPasswordChange(account);
            password_change.ShowDialog();
            if (password_change.mIsOperationOk)
            {
                LoadAccounts();
                MessageBox.Show("Cập nhật mật khẩu thành công");
            }

            return;
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
    }
}
