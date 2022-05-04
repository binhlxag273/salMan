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
        public AccountAll()
        {
            InitializeComponent();
        }

        private void AccountAll_Load(object sender, EventArgs e)
        {
            dgAccounts.DataSource = BussinessLogicLayer.Account_BUS.GetManyAccount();
        }

        private void dgAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = e.RowIndex;
            if ( row_idx < 0)
            {
                return;
            }

            Account_DTO account = (Account_DTO)dgAccounts.CurrentRow.DataBoundItem;
            AccountUpsert accountUpsert = new AccountUpsert(account);
            accountUpsert.ShowDialog();

            if (account.account_name == Helper.Instance().gAccount.account_name)
                Helper.Instance().gAccount = account;

            dgAccounts.Refresh();
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
