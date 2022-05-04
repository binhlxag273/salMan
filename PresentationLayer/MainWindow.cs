using FontAwesome.Sharp;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer
{
    public partial class MainWindow : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private bool HandleLogin()
        {

            Login loginWindow = new Login();
            loginWindow.ShowDialog();

            return Helper.Instance().gIsLogin;
        }

        private void InitForm()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);

        }

        public MainWindow()
        {
            bool login_ok = HandleLogin();
            if (!login_ok)
            {
                Application.Exit();
                return;
            }
            InitializeComponent();

            InitForm();
        }

        private struct RGPColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildrenForm.IconChar = currentBtn.IconChar;
                iconCurrentChildrenForm.IconColor = color;

                lblTitleChildrenForm.Text = currentBtn.Text;
            }
        }
        
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ClearFormContainer()
        {
            if (pnlFormContainer.Controls.Count == 0) return;

            ((Form)pnlFormContainer.Controls[0]).Close();
            pnlFormContainer.Controls.Clear();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGPColors.color1);

            ClearFormContainer();
            ChildFormStaff childForm = new ChildFormStaff();
            childForm.TopLevel = false;
            childForm.Width = pnlFormContainer.Width;
            childForm.Height = pnlFormContainer.Height;
            pnlFormContainer.Controls.Add(childForm);
            childForm.Show();

        }

        private void btnSalaryProcess_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGPColors.color2);

            ClearFormContainer();
            ChildFormSalaryProcess childForm = new ChildFormSalaryProcess();
            childForm.TopLevel = false;
            childForm.Width = pnlFormContainer.Width;
            childForm.Height = pnlFormContainer.Height;
            pnlFormContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGPColors.color3);

            ClearFormContainer();
            ChildFormReport childForm = new ChildFormReport();
            childForm.TopLevel = false;
            childForm.Width = pnlFormContainer.Width;
            childForm.Height = pnlFormContainer.Height;
            pnlFormContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGPColors.color4);

            ClearFormContainer();
            ChildFormCategory childForm = new ChildFormCategory();
            childForm.TopLevel = false;
            childForm.Width = pnlFormContainer.Width;
            childForm.Height = pnlFormContainer.Height;
            pnlFormContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGPColors.color5);

            ClearFormContainer();
            ChildFormAccount childForm = new ChildFormAccount();
            childForm.TopLevel = false;
            childForm.Width = pnlFormContainer.Width;
            childForm.Height = pnlFormContainer.Height;
            pnlFormContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGPColors.color6);

            ClearFormContainer();
            ChildFormSetting childForm = new ChildFormSetting();
            childForm.TopLevel = false;
            childForm.Width = pnlFormContainer.Width;
            childForm.Height = pnlFormContainer.Height;
            pnlFormContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildrenForm.IconChar = IconChar.Home;
            iconCurrentChildrenForm.IconColor = Color.MediumPurple;
            lblTitleChildrenForm.Text = "Trang chủ";
        }

        private void iconLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                UtilityLayer.Logging.Instance().LogInfo("Log auth [Login]: " + Helper.Instance().gAccount.account_name);
                Helper.Instance().gIsLogin = false;
                Helper.Instance().gAccount = null;

                this.Hide();
                bool login_ok = HandleLogin();
                if (login_ok == false)
                {
                    Application.Exit();
                    return;
                }

                InitForm();
                this.Show();
            }
        }
    }
}
