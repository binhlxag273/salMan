namespace PresentationLayer
{
    partial class StaffUpsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBirthPlace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtStartWorkingDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndWorkingDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nudBasicSalary = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudIsuranceAmount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudAllowanceAmount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.ckbWorkingStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasicSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIsuranceAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllowanceAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(43, 45);
            this.txbCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(241, 27);
            this.txbCode.TabIndex = 2;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(393, 45);
            this.txbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(241, 27);
            this.txbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(43, 110);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(241, 27);
            this.dtBirthDate.TabIndex = 5;
            this.dtBirthDate.Value = new System.DateTime(2022, 5, 8, 22, 8, 16, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nơi sinh";
            // 
            // txbBirthPlace
            // 
            this.txbBirthPlace.Location = new System.Drawing.Point(393, 110);
            this.txbBirthPlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBirthPlace.Name = "txbBirthPlace";
            this.txbBirthPlace.Size = new System.Drawing.Size(241, 27);
            this.txbBirthPlace.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(43, 174);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(241, 27);
            this.txbEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày bắt đầu công tác";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày kết thúc công tác";
            // 
            // dtStartWorkingDate
            // 
            this.dtStartWorkingDate.Location = new System.Drawing.Point(43, 303);
            this.dtStartWorkingDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtStartWorkingDate.Name = "dtStartWorkingDate";
            this.dtStartWorkingDate.Size = new System.Drawing.Size(241, 27);
            this.dtStartWorkingDate.TabIndex = 13;
            // 
            // dtEndWorkingDate
            // 
            this.dtEndWorkingDate.Location = new System.Drawing.Point(393, 356);
            this.dtEndWorkingDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtEndWorkingDate.Name = "dtEndWorkingDate";
            this.dtEndWorkingDate.Size = new System.Drawing.Size(241, 27);
            this.dtEndWorkingDate.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 395);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lương cơ bản";
            // 
            // nudBasicSalary
            // 
            this.nudBasicSalary.Location = new System.Drawing.Point(43, 418);
            this.nudBasicSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudBasicSalary.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudBasicSalary.Name = "nudBasicSalary";
            this.nudBasicSalary.Size = new System.Drawing.Size(240, 27);
            this.nudBasicSalary.TabIndex = 16;
            this.nudBasicSalary.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phụ cấp bảo hiểm";
            // 
            // nudIsuranceAmount
            // 
            this.nudIsuranceAmount.Location = new System.Drawing.Point(393, 418);
            this.nudIsuranceAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudIsuranceAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudIsuranceAmount.Name = "nudIsuranceAmount";
            this.nudIsuranceAmount.Size = new System.Drawing.Size(240, 27);
            this.nudIsuranceAmount.TabIndex = 18;
            this.nudIsuranceAmount.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phụ cấp công vụ";
            // 
            // nudAllowanceAmount
            // 
            this.nudAllowanceAmount.Location = new System.Drawing.Point(43, 482);
            this.nudAllowanceAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAllowanceAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudAllowanceAmount.Name = "nudAllowanceAmount";
            this.nudAllowanceAmount.Size = new System.Drawing.Size(240, 27);
            this.nudAllowanceAmount.TabIndex = 20;
            this.nudAllowanceAmount.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Phòng ban";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(43, 240);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(241, 28);
            this.cbxDepartment.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(393, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Chức vụ";
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(393, 240);
            this.cbxPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(241, 28);
            this.cbxPosition.TabIndex = 25;
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(180, 544);
            this.btnUpsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(321, 27);
            this.btnUpsert.TabIndex = 26;
            this.btnUpsert.Text = "Cập nhật";
            this.btnUpsert.UseVisualStyleBackColor = true;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(122, 522);
            this.lblErrorMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMsg.TabIndex = 27;
            // 
            // ckbWorkingStatus
            // 
            this.ckbWorkingStatus.AutoSize = true;
            this.ckbWorkingStatus.Location = new System.Drawing.Point(43, 359);
            this.ckbWorkingStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbWorkingStatus.Name = "ckbWorkingStatus";
            this.ckbWorkingStatus.Size = new System.Drawing.Size(128, 24);
            this.ckbWorkingStatus.TabIndex = 28;
            this.ckbWorkingStatus.Text = "Đang công tác";
            this.ckbWorkingStatus.UseVisualStyleBackColor = true;
            // 
            // StaffUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 603);
            this.Controls.Add(this.ckbWorkingStatus);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudAllowanceAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudIsuranceAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudBasicSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtEndWorkingDate);
            this.Controls.Add(this.dtStartWorkingDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbBirthPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "StaffUpsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.StaffUpsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBasicSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIsuranceAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllowanceAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbCode;
        private TextBox txbName;
        private Label label3;
        private DateTimePicker dtBirthDate;
        private Label label4;
        private TextBox txbBirthPlace;
        private Label label5;
        private TextBox txbEmail;
        private Label label6;
        private Label label7;
        private DateTimePicker dtStartWorkingDate;
        private DateTimePicker dtEndWorkingDate;
        private Label label8;
        private NumericUpDown nudBasicSalary;
        private Label label9;
        private NumericUpDown nudIsuranceAmount;
        private Label label10;
        private NumericUpDown nudAllowanceAmount;
        private Label label11;
        private ComboBox cbxDepartment;
        private Label label12;
        private ComboBox cbxPosition;
        private Button btnUpsert;
        private Label lblErrorMsg;
        private CheckBox ckbWorkingStatus;
    }
}