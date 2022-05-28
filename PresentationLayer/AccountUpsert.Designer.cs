namespace PresentationLayer
{
    partial class AccountUpsert
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
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.cbxAccountType = new System.Windows.Forms.ComboBox();
            this.cbxGroupType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.chkValidated = new System.Windows.Forms.CheckBox();
            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(28, 59);
            this.txbAccountName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(492, 27);
            this.txbAccountName.TabIndex = 0;
            // 
            // cbxAccountType
            // 
            this.cbxAccountType.FormattingEnabled = true;
            this.cbxAccountType.Location = new System.Drawing.Point(28, 137);
            this.cbxAccountType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxAccountType.Name = "cbxAccountType";
            this.cbxAccountType.Size = new System.Drawing.Size(231, 28);
            this.cbxAccountType.TabIndex = 2;
            // 
            // cbxGroupType
            // 
            this.cbxGroupType.FormattingEnabled = true;
            this.cbxGroupType.Location = new System.Drawing.Point(289, 137);
            this.cbxGroupType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxGroupType.Name = "cbxGroupType";
            this.cbxGroupType.Size = new System.Drawing.Size(231, 28);
            this.cbxGroupType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhóm tài khoản";
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(28, 256);
            this.btnUpsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(230, 27);
            this.btnUpsert.TabIndex = 10;
            this.btnUpsert.Text = "Thêm";
            this.btnUpsert.UseVisualStyleBackColor = true;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 256);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(230, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorMsg.Location = new System.Drawing.Point(28, 214);
            this.lblErrorMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMsg.TabIndex = 12;
            // 
            // chkValidated
            // 
            this.chkValidated.AutoSize = true;
            this.chkValidated.Location = new System.Drawing.Point(28, 187);
            this.chkValidated.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkValidated.Name = "chkValidated";
            this.chkValidated.Size = new System.Drawing.Size(173, 24);
            this.chkValidated.TabIndex = 13;
            this.chkValidated.Text = "Tài khoản đã xác thực";
            this.chkValidated.UseVisualStyleBackColor = true;
            // 
            // chkBlocked
            // 
            this.chkBlocked.AutoSize = true;
            this.chkBlocked.Location = new System.Drawing.Point(289, 187);
            this.chkBlocked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBlocked.Name = "chkBlocked";
            this.chkBlocked.Size = new System.Drawing.Size(146, 24);
            this.chkBlocked.TabIndex = 14;
            this.chkBlocked.Text = "Tài khoản bị khóa";
            this.chkBlocked.UseVisualStyleBackColor = true;
            // 
            // AccountUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 307);
            this.Controls.Add(this.chkBlocked);
            this.Controls.Add(this.chkValidated);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGroupType);
            this.Controls.Add(this.cbxAccountType);
            this.Controls.Add(this.txbAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AccountUpsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbAccountName;
        private ComboBox cbxAccountType;
        private ComboBox cbxGroupType;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnUpsert;
        private Button btnCancel;
        private Label lblErrorMsg;
        private CheckBox chkValidated;
        private CheckBox chkBlocked;
    }
}