namespace PresentationLayer
{
    partial class StaffSearchAdvance
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSearchTarget = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(347, 133);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(300, 34);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Location = new System.Drawing.Point(668, 63);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(300, 31);
            this.dtToDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày công tác đến";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Location = new System.Drawing.Point(347, 63);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(300, 31);
            this.dtFromDate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày công tác từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // cbxSearchTarget
            // 
            this.cbxSearchTarget.FormattingEnabled = true;
            this.cbxSearchTarget.Items.AddRange(new object[] {
            "Họ tên nhân viên",
            "Mã nhân viên",
            "Tên tài khoản",
            "Phòng ban",
            "Chức vụ"});
            this.cbxSearchTarget.Location = new System.Drawing.Point(21, 61);
            this.cbxSearchTarget.Name = "cbxSearchTarget";
            this.cbxSearchTarget.Size = new System.Drawing.Size(300, 33);
            this.cbxSearchTarget.TabIndex = 7;
            // 
            // StaffSearchAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 200);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSearchTarget);
            this.Name = "StaffSearchAdvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nâng cao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConfirm;
        private DateTimePicker dtToDate;
        private Label label3;
        private DateTimePicker dtFromDate;
        private Label label2;
        private Label label1;
        private ComboBox cbxSearchTarget;
    }
}