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
    public partial class ChildFormStaff : Form
    {
        private void ClearForm()
        {
            if (pnlStaffContainer.Controls.Count != 0)
                ((Form)pnlStaffContainer.Controls[0]).Close();

            pnlStaffContainer.Controls.Clear();
        }

        private void InitForm()
        {
            ClearForm();

            StaffAll staffAll = new StaffAll();
            staffAll.Width = pnlStaffContainer.Width;
            staffAll.Height = pnlStaffContainer.Height;
            staffAll.TopLevel = false;

            pnlStaffContainer.Controls.Add(staffAll);
            staffAll.Show();
        }

        public ChildFormStaff()
        {
            InitializeComponent();
        }

        private void ChildFormStaff_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnStaffAll_Click(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
