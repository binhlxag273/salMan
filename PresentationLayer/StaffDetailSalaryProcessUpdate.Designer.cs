namespace PresentationLayer
{
    partial class StaffDetailSalaryProcessUpdate
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
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.lblAmountSalary = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Location = new System.Drawing.Point(54, 80);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(177, 24);
            this.chkIsPaid.TabIndex = 0;
            this.chkIsPaid.Text = "Xác nhận đã trả lương";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // lblAmountSalary
            // 
            this.lblAmountSalary.AutoSize = true;
            this.lblAmountSalary.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAmountSalary.Location = new System.Drawing.Point(54, 181);
            this.lblAmountSalary.Name = "lblAmountSalary";
            this.lblAmountSalary.Size = new System.Drawing.Size(0, 20);
            this.lblAmountSalary.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(66, 233);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(206, 29);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Location = new System.Drawing.Point(56, 123);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(250, 27);
            this.dtPaymentDate.TabIndex = 5;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.Location = new System.Drawing.Point(29, 18);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 28);
            this.lblMsg.TabIndex = 6;
            // 
            // StaffDetailSalaryProcessUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 321);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAmountSalary);
            this.Controls.Add(this.chkIsPaid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffDetailSalaryProcessUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quá trình lương";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkIsPaid;
        private Label lblAmountSalary;
        private Button btnConfirm;
        private DateTimePicker dtPaymentDate;
        private Label lblMsg;
    }
}