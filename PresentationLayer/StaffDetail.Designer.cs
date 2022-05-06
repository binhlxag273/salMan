namespace PresentationLayer
{
    partial class StaffDetail
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
            this.tabStaffDetail = new System.Windows.Forms.TabControl();
            this.tabStaffTimekeeping = new System.Windows.Forms.TabPage();
            this.tabStaffStatistic = new System.Windows.Forms.TabPage();
            this.tabStaffSalaryProcess = new System.Windows.Forms.TabPage();
            this.tabStaffReport = new System.Windows.Forms.TabPage();
            this.tabStaffDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStaffDetail
            // 
            this.tabStaffDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStaffDetail.Controls.Add(this.tabStaffTimekeeping);
            this.tabStaffDetail.Controls.Add(this.tabStaffStatistic);
            this.tabStaffDetail.Controls.Add(this.tabStaffSalaryProcess);
            this.tabStaffDetail.Controls.Add(this.tabStaffReport);
            this.tabStaffDetail.Location = new System.Drawing.Point(12, 12);
            this.tabStaffDetail.Name = "tabStaffDetail";
            this.tabStaffDetail.SelectedIndex = 0;
            this.tabStaffDetail.Size = new System.Drawing.Size(1180, 749);
            this.tabStaffDetail.TabIndex = 4;
            this.tabStaffDetail.SelectedIndexChanged += new System.EventHandler(this.tabStaffDetail_SelectedIndexChanged);
            // 
            // tabStaffTimekeeping
            // 
            this.tabStaffTimekeeping.Location = new System.Drawing.Point(4, 34);
            this.tabStaffTimekeeping.Name = "tabStaffTimekeeping";
            this.tabStaffTimekeeping.Size = new System.Drawing.Size(1172, 711);
            this.tabStaffTimekeeping.TabIndex = 4;
            this.tabStaffTimekeeping.Text = "Chấm công";
            this.tabStaffTimekeeping.UseVisualStyleBackColor = true;
            // 
            // tabStaffStatistic
            // 
            this.tabStaffStatistic.Location = new System.Drawing.Point(4, 34);
            this.tabStaffStatistic.Name = "tabStaffStatistic";
            this.tabStaffStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaffStatistic.Size = new System.Drawing.Size(1172, 589);
            this.tabStaffStatistic.TabIndex = 1;
            this.tabStaffStatistic.Text = "Thống kê";
            this.tabStaffStatistic.UseVisualStyleBackColor = true;
            // 
            // tabStaffSalaryProcess
            // 
            this.tabStaffSalaryProcess.Location = new System.Drawing.Point(4, 34);
            this.tabStaffSalaryProcess.Name = "tabStaffSalaryProcess";
            this.tabStaffSalaryProcess.Size = new System.Drawing.Size(1172, 589);
            this.tabStaffSalaryProcess.TabIndex = 2;
            this.tabStaffSalaryProcess.Text = "Quá trình lương";
            this.tabStaffSalaryProcess.UseVisualStyleBackColor = true;
            // 
            // tabStaffReport
            // 
            this.tabStaffReport.Location = new System.Drawing.Point(4, 34);
            this.tabStaffReport.Name = "tabStaffReport";
            this.tabStaffReport.Size = new System.Drawing.Size(1172, 589);
            this.tabStaffReport.TabIndex = 5;
            this.tabStaffReport.Text = "Báo cáo";
            this.tabStaffReport.UseVisualStyleBackColor = true;
            // 
            // StaffDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 773);
            this.Controls.Add(this.tabStaffDetail);
            this.MaximizeBox = false;
            this.Name = "StaffDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.tabStaffDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabStaffDetail;
        private TabPage tabStaffStatistic;
        private TabPage tabStaffSalaryProcess;
        private TabPage tabStaffTimekeeping;
        private TabPage tabStaffReport;
    }
}