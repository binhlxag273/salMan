namespace PresentationLayer
{
    partial class CategoryDetailDateOffUpsert
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
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.dtCode = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(53, 248);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 25);
            this.lblErrorMsg.TabIndex = 18;
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(79, 285);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(225, 34);
            this.btnUpsert.TabIndex = 17;
            this.btnUpsert.Text = "Xác nhận";
            this.btnUpsert.UseVisualStyleBackColor = true;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngảy nghỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên ngày nghỉ";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(51, 192);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(294, 31);
            this.txbName.TabIndex = 14;
            // 
            // dtCode
            // 
            this.dtCode.Location = new System.Drawing.Point(51, 87);
            this.dtCode.Name = "dtCode";
            this.dtCode.Size = new System.Drawing.Size(300, 31);
            this.dtCode.TabIndex = 19;
            // 
            // CategoryDetailDateOffUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 369);
            this.Controls.Add(this.dtCode);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbName);
            this.Name = "CategoryDetailDateOffUpsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngày nghỉ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblErrorMsg;
        private Button btnUpsert;
        private Label label1;
        private Label label2;
        private TextBox txbName;
        private DateTimePicker dtCode;
    }
}