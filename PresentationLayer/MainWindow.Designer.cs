namespace PresentationLayer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.btnSalaryProcess = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.iconLogOut = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildrenForm = new System.Windows.Forms.Label();
            this.iconCurrentChildrenForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlFormContainer = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildrenForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnAccount);
            this.pnlMenu.Controls.Add(this.btnCategory);
            this.pnlMenu.Controls.Add(this.btnSalaryProcess);
            this.pnlMenu.Controls.Add(this.btnReport);
            this.pnlMenu.Controls.Add(this.btnStaff);
            this.pnlMenu.Location = new System.Drawing.Point(3, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(261, 658);
            this.pnlMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Sith;
            this.btnSetting.IconColor = System.Drawing.Color.White;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 456);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(256, 60);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAccount.IconColor = System.Drawing.Color.White;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.IconSize = 32;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 390);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAccount.Size = new System.Drawing.Size(256, 60);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnCategory.IconColor = System.Drawing.Color.White;
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategory.IconSize = 32;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 324);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCategory.Size = new System.Drawing.Size(256, 60);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Danh mục";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSalaryProcess
            // 
            this.btnSalaryProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalaryProcess.FlatAppearance.BorderSize = 0;
            this.btnSalaryProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryProcess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalaryProcess.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalaryProcess.IconChar = FontAwesome.Sharp.IconChar.Magento;
            this.btnSalaryProcess.IconColor = System.Drawing.Color.White;
            this.btnSalaryProcess.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalaryProcess.IconSize = 32;
            this.btnSalaryProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryProcess.Location = new System.Drawing.Point(0, 192);
            this.btnSalaryProcess.Name = "btnSalaryProcess";
            this.btnSalaryProcess.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalaryProcess.Size = new System.Drawing.Size(256, 60);
            this.btnSalaryProcess.TabIndex = 2;
            this.btnSalaryProcess.Text = "Quá trình lương";
            this.btnSalaryProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalaryProcess.UseVisualStyleBackColor = true;
            this.btnSalaryProcess.Click += new System.EventHandler(this.btnSalaryProcess_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.btnReport.IconColor = System.Drawing.Color.White;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 32;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(4, 258);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReport.Size = new System.Drawing.Size(256, 60);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.Unsplash;
            this.btnStaff.IconColor = System.Drawing.Color.White;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.IconSize = 32;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(3, 126);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStaff.Size = new System.Drawing.Size(256, 60);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.pnlHeader.Controls.Add(this.iconLogOut);
            this.pnlHeader.Controls.Add(this.lblTitleChildrenForm);
            this.pnlHeader.Controls.Add(this.iconCurrentChildrenForm);
            this.pnlHeader.Location = new System.Drawing.Point(266, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 75);
            this.pnlHeader.TabIndex = 2;
            // 
            // iconLogOut
            // 
            this.iconLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconLogOut.FlatAppearance.BorderSize = 0;
            this.iconLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconLogOut.IconColor = System.Drawing.Color.White;
            this.iconLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogOut.IconSize = 32;
            this.iconLogOut.Location = new System.Drawing.Point(939, 0);
            this.iconLogOut.Name = "iconLogOut";
            this.iconLogOut.Size = new System.Drawing.Size(61, 75);
            this.iconLogOut.TabIndex = 7;
            this.iconLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLogOut.UseVisualStyleBackColor = true;
            this.iconLogOut.Click += new System.EventHandler(this.iconLogOut_Click);
            // 
            // lblTitleChildrenForm
            // 
            this.lblTitleChildrenForm.AutoSize = true;
            this.lblTitleChildrenForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildrenForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildrenForm.Location = new System.Drawing.Point(69, 23);
            this.lblTitleChildrenForm.Name = "lblTitleChildrenForm";
            this.lblTitleChildrenForm.Size = new System.Drawing.Size(119, 32);
            this.lblTitleChildrenForm.TabIndex = 1;
            this.lblTitleChildrenForm.Text = "Trang chủ";
            // 
            // iconCurrentChildrenForm
            // 
            this.iconCurrentChildrenForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.iconCurrentChildrenForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildrenForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildrenForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildrenForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildrenForm.IconSize = 48;
            this.iconCurrentChildrenForm.Location = new System.Drawing.Point(15, 17);
            this.iconCurrentChildrenForm.Name = "iconCurrentChildrenForm";
            this.iconCurrentChildrenForm.Size = new System.Drawing.Size(48, 48);
            this.iconCurrentChildrenForm.TabIndex = 0;
            this.iconCurrentChildrenForm.TabStop = false;
            // 
            // pnlFormContainer
            // 
            this.pnlFormContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlFormContainer.Location = new System.Drawing.Point(265, 79);
            this.pnlFormContainer.Name = "pnlFormContainer";
            this.pnlFormContainer.Size = new System.Drawing.Size(1001, 580);
            this.pnlFormContainer.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 660);
            this.Controls.Add(this.pnlFormContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildrenForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnStaff;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnSalaryProcess;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnSetting;
        private Panel pnlHeader;
        private Panel pnlFormContainer;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildrenForm;
        private Label lblTitleChildrenForm;
        private FontAwesome.Sharp.IconButton iconLogOut;
        private ErrorProvider errorProvider1;
    }
}