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
    public partial class ChildFormCategory : Form
    {
        public ChildFormCategory()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (pnlCategoryContainer.Controls.Count > 0)
            {
                ((Form)pnlCategoryContainer.Controls[0]).Close();
            }

            CategoryAll childerForm = new CategoryAll();
            childerForm.TopLevel = false;
            childerForm.Width = pnlCategoryContainer.Width;
            childerForm.Height = pnlCategoryContainer.Height;
            pnlCategoryContainer.Controls.Add(childerForm);
            childerForm.Show();
        }
    }
}
