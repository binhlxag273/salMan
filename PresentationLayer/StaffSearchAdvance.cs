using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PresentationLayer.StaffAll;

namespace PresentationLayer
{
    public partial class StaffSearchAdvance : Form
    {
        public SearchOptions mSearchOptions;

        public StaffSearchAdvance(SearchOptions searchOptions)
        {
            InitializeComponent();
            mSearchOptions = searchOptions;
            cbxSearchTarget.SelectedIndex = mSearchOptions.mSearchTypeIndex;
            if (mSearchOptions.mSearchFromDate.Length > 0)
                dtFromDate.Text = mSearchOptions.mSearchFromDate;

            if (mSearchOptions.mSearchToDate.Length > 0)
                dtToDate.Text = mSearchOptions.mSearchToDate;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            mSearchOptions.mSearchTypeIndex = cbxSearchTarget.SelectedIndex;
            mSearchOptions.mSearchFromDate = dtFromDate.Value.ToString("yyyy-MM-dd");
            mSearchOptions.mSearchToDate = dtToDate.Value.ToString("yyyy-MM-dd");

            mSearchOptions.mUseAdvance = true;

            this.Close();
        }
    }
}
