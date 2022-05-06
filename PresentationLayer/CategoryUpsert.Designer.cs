namespace PresentationLayer
{
    partial class CategoryUpsert
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
            this.txbAliasCode = new System.Windows.Forms.TextBox();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.chkIsSystem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbAliasCode
            // 
            this.txbAliasCode.Location = new System.Drawing.Point(42, 74);
            this.txbAliasCode.Name = "txbAliasCode";
            this.txbAliasCode.Size = new System.Drawing.Size(294, 31);
            this.txbAliasCode.TabIndex = 0;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(42, 183);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(294, 31);
            this.txbDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại danh mục";
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(74, 323);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(225, 34);
            this.btnUpsert.TabIndex = 4;
            this.btnUpsert.Text = "Xác nhận";
            this.btnUpsert.UseVisualStyleBackColor = true;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(48, 286);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 25);
            this.lblErrorMsg.TabIndex = 5;
            // 
            // chkIsSystem
            // 
            this.chkIsSystem.AutoSize = true;
            this.chkIsSystem.Location = new System.Drawing.Point(42, 249);
            this.chkIsSystem.Name = "chkIsSystem";
            this.chkIsSystem.Size = new System.Drawing.Size(196, 29);
            this.chkIsSystem.TabIndex = 6;
            this.chkIsSystem.Text = "Danh mục hệ thống";
            this.chkIsSystem.UseVisualStyleBackColor = true;
            // 
            // CategoryUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 426);
            this.Controls.Add(this.chkIsSystem);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDisplayName);
            this.Controls.Add(this.txbAliasCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 482);
            this.Name = "CategoryUpsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại danh mục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbAliasCode;
        private TextBox txbDisplayName;
        private Label label1;
        private Label label2;
        private Button btnUpsert;
        private Label lblErrorMsg;
        private CheckBox chkIsSystem;
    }
}