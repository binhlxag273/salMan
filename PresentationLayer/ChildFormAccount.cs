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
    public partial class ChildFormAccount : Form
    {
        public ChildFormAccount()
        {
            InitializeComponent();
        }

        private void ClearPnlAccountContainer()
        {
            if (pnlAccountContainer.Controls.Count == 0)
            {
                return;
            }

            ((Form)pnlAccountContainer.Controls[0]).Close();

            pnlAccountContainer.Controls.Clear();
        }

        private void btnAccountAll_Click(object sender, EventArgs e)
        {
            ClearPnlAccountContainer();
            AccountAll childrenForm = new AccountAll();
            childrenForm.TopLevel = false;
            childrenForm.Width = pnlAccountContainer.Width;
            childrenForm.Height = pnlAccountContainer.Height;
            pnlAccountContainer.Controls.Add(childrenForm);
            childrenForm.Show();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
