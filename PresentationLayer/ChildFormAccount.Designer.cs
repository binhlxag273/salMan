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
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnAccountAll = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.btnAccountAll);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 82);
            this.panel1.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.Location = new System.Drawing.Point(171, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(165, 79);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Tất cả tài khoản";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnAccountAll
            // 
            this.btnAccountAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountAll.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.btnAccountAll.IconColor = System.Drawing.Color.Black;
            this.btnAccountAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccountAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccountAll.Location = new System.Drawing.Point(0, 0);
            this.btnAccountAll.Name = "btnAccountAll";
            this.btnAccountAll.Size = new System.Drawing.Size(165, 79);
            this.btnAccountAll.TabIndex = 1;
            this.btnAccountAll.Text = "Tất cả tài khoản";
            this.btnAccountAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccountAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccountAll.UseVisualStyleBackColor = true;
            this.btnAccountAll.Click += new System.EventHandler(this.btnAccountAll_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(342, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 79);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Tài khoản của bạn";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pnlAccountContainer
            // 
            this.pnlAccountContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccountContainer.Location = new System.Drawing.Point(2, 83);
            this.pnlAccountContainer.Name = "pnlAccountContainer";
            this.pnlAccountContainer.Size = new System.Drawing.Size(942, 459);
            this.pnlAccountContainer.TabIndex = 1;
            // 
            // ChildFormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 554);
            this.Controls.Add(this.pnlAccountContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFormAccount";
            this.Text = "ChildFormAccount";
            this.Load += new System.EventHandler(this.ChildFormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnAccountAll;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel pnlAccountContainer;
    }
}