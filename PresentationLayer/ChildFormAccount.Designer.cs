namespace PresentationLayer
{
    partial class ChildFormAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountAll = new FontAwesome.Sharp.IconButton();
            this.pnlAccountContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnAccountAll);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnAccountAll
            // 
            this.btnAccountAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountAll.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.btnAccountAll.IconColor = System.Drawing.Color.Black;
            this.btnAccountAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccountAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccountAll.Location = new System.Drawing.Point(0, 0);
            this.btnAccountAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccountAll.Name = "btnAccountAll";
            this.btnAccountAll.Size = new System.Drawing.Size(132, 63);
            this.btnAccountAll.TabIndex = 1;
            this.btnAccountAll.Text = "Tất cả tài khoản";
            this.btnAccountAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccountAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccountAll.UseVisualStyleBackColor = true;
            this.btnAccountAll.Click += new System.EventHandler(this.btnAccountAll_Click);
            // 
            // pnlAccountContainer
            // 
            this.pnlAccountContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccountContainer.Location = new System.Drawing.Point(2, 66);
            this.pnlAccountContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAccountContainer.Name = "pnlAccountContainer";
            this.pnlAccountContainer.Size = new System.Drawing.Size(754, 367);
            this.pnlAccountContainer.TabIndex = 1;
            // 
            // ChildFormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 443);
            this.Controls.Add(this.pnlAccountContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChildFormAccount";
            this.Text = "ChildFormAccount";
            this.Load += new System.EventHandler(this.ChildFormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAccountAll;
        private Panel pnlAccountContainer;
    }
}