namespace PresentationLayer
{
    partial class AccountUpsertConfirm
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
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.lblErrorResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận mật khẩu";
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Location = new System.Drawing.Point(85, 74);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.PasswordChar = '*';
            this.txbConfirmPassword.Size = new System.Drawing.Size(407, 31);
            this.txbConfirmPassword.TabIndex = 1;
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.Location = new System.Drawing.Point(219, 151);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(112, 34);
            this.btnConfirmPassword.TabIndex = 2;
            this.btnConfirmPassword.Text = "Xác nhận";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPassword_Click);
            // 
            // lblErrorResponse
            // 
            this.lblErrorResponse.AutoSize = true;
            this.lblErrorResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblErrorResponse.ForeColor = System.Drawing.Color.Red;
            this.lblErrorResponse.Location = new System.Drawing.Point(90, 117);
            this.lblErrorResponse.Name = "lblErrorResponse";
            this.lblErrorResponse.Size = new System.Drawing.Size(0, 28);
            this.lblErrorResponse.TabIndex = 3;
            // 
            // AccountUpsertConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 220);
            this.Controls.Add(this.lblErrorResponse);
            this.Controls.Add(this.btnConfirmPassword);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.label1);
            this.Name = "AccountUpsertConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbConfirmPassword;
        private Button btnConfirmPassword;
        private Label lblErrorResponse;
    }
}