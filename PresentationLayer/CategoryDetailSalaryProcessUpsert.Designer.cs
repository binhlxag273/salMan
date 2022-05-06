namespace PresentationLayer
{
    partial class CategoryDetailSalaryProcessUpsert
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
            this.dtTitle = new System.Windows.Forms.DateTimePicker();
            this.ckbIsPaid = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lương tháng";
            // 
            // dtTitle
            // 
            this.dtTitle.Location = new System.Drawing.Point(37, 59);
            this.dtTitle.Name = "dtTitle";
            this.dtTitle.Size = new System.Drawing.Size(300, 31);
            this.dtTitle.TabIndex = 1;
            // 
            // ckbIsPaid
            // 
            this.ckbIsPaid.AutoSize = true;
            this.ckbIsPaid.Location = new System.Drawing.Point(149, 120);
            this.ckbIsPaid.Name = "ckbIsPaid";
            this.ckbIsPaid.Size = new System.Drawing.Size(22, 21);
            this.ckbIsPaid.TabIndex = 3;
            this.ckbIsPaid.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày trả lương";
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Location = new System.Drawing.Point(37, 215);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(300, 31);
            this.dtPaymentDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lương";
            // 
            // nudSalary
            // 
            this.nudSalary.Location = new System.Drawing.Point(37, 316);
            this.nudSalary.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(294, 31);
            this.nudSalary.TabIndex = 7;
            this.nudSalary.ThousandsSeparator = true;
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(119, 407);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(112, 34);
            this.btnUpsert.TabIndex = 8;
            this.btnUpsert.Text = "Xác nhận";
            this.btnUpsert.UseVisualStyleBackColor = true;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đã trả lương";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(37, 366);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 25);
            this.lblErrorMsg.TabIndex = 10;
            // 
            // CategoryDetailSalaryProcessUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbIsPaid);
            this.Controls.Add(this.dtTitle);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CategoryDetailSalaryProcessUpsert";
            this.Text = "Thông tin lương";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dtTitle;
        private CheckBox ckbIsPaid;
        private Label label2;
        private DateTimePicker dtPaymentDate;
        private Label label3;
        private NumericUpDown nudSalary;
        private Button btnUpsert;
        private Label label4;
        private Label lblErrorMsg;
    }
}