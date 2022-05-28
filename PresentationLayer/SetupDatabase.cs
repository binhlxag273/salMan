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
    public partial class SetupDatabase : Form
    {
        public bool mIsOperationOk { get; set; } = false;

        public SetupDatabase()
        {
            InitializeComponent();
        }
    }
}
