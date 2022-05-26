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
            this.tabStaffSalaryProcess = new System.Windows.Forms.TabPage();
            this.tabStaffTimekeeping = new System.Windows.Forms.TabPage();
            this.tabStaffDetail = new System.Windows.Forms.TabControl();
            this.tabStaffDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStaffSalaryProcess
            // 
            this.tabStaffSalaryProcess.Location = new System.Drawing.Point(4, 29);
            this.tabStaffSalaryProcess.Margin = new System.Windows.Forms.Padding(2);
            this.tabStaffSalaryProcess.Name = "tabStaffSalaryProcess";
            this.tabStaffSalaryProcess.Size = new System.Drawing.Size(936, 566);
            this.tabStaffSalaryProcess.TabIndex = 2;
            this.tabStaffSalaryProcess.Text = "Quá trình lương";
            this.tabStaffSalaryProcess.UseVisualStyleBackColor = true;
            // 
            // tabStaffTimekeeping
            // 
            this.tabStaffTimekeeping.Location = new System.Drawing.Point(4, 29);
            this.tabStaffTimekeeping.Margin = new System.Windows.Forms.Padding(2);
            this.tabStaffTimekeeping.Name = "tabStaffTimekeeping";
            this.tabStaffTimekeeping.Size = new System.Drawing.Size(936, 566);
            this.tabStaffTimekeeping.TabIndex = 4;
            this.tabStaffTimekeeping.Text = "Chấm công";
            this.tabStaffTimekeeping.UseVisualStyleBackColor = true;
            // 
            // tabStaffDetail
            // 
            this.tabStaffDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStaffDetail.Controls.Add(this.tabStaffTimekeeping);
            this.tabStaffDetail.Controls.Add(this.tabStaffSalaryProcess);
            this.tabStaffDetail.Location = new System.Drawing.Point(10, 10);
            this.tabStaffDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tabStaffDetail.Name = "tabStaffDetail";
            this.tabStaffDetail.SelectedIndex = 0;
            this.tabStaffDetail.Size = new System.Drawing.Size(944, 599);
            this.tabStaffDetail.TabIndex = 4;
            this.tabStaffDetail.SelectedIndexChanged += new System.EventHandler(this.tabStaffDetail_SelectedIndexChanged);
            // 
            // StaffDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 618);
            this.Controls.Add(this.tabStaffDetail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StaffDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.tabStaffDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabStaffSalaryProcess;
        private TabPage tabStaffTimekeeping;
        private TabControl tabStaffDetail;
    }
}