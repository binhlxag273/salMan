namespace PresentationLayer
{
    partial class ChildFormStaff
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
            this.pnlStaffContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaffAll = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStaffContainer
            // 
            this.pnlStaffContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStaffContainer.Location = new System.Drawing.Point(5, 91);
            this.pnlStaffContainer.Name = "pnlStaffContainer";
            this.pnlStaffContainer.Size = new System.Drawing.Size(1034, 488);
            this.pnlStaffContainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnStaffAll);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 82);
            this.panel1.TabIndex = 2;
            // 
            // btnStaffAll
            // 
            this.btnStaffAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffAll.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.btnStaffAll.IconColor = System.Drawing.Color.Black;
            this.btnStaffAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaffAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffAll.Location = new System.Drawing.Point(0, 0);
            this.btnStaffAll.Name = "btnStaffAll";
            this.btnStaffAll.Size = new System.Drawing.Size(165, 79);
            this.btnStaffAll.TabIndex = 1;
            this.btnStaffAll.Text = "Tất cả nhân viên";
            this.btnStaffAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStaffAll.UseVisualStyleBackColor = true;
            this.btnStaffAll.Click += new System.EventHandler(this.btnStaffAll_Click);
            // 
            // ChildFormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 591);
            this.Controls.Add(this.pnlStaffContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFormStaff";
            this.Text = "ChildFormStaff";
            this.Load += new System.EventHandler(this.ChildFormStaff_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlStaffContainer;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnStaffAll;
    }
}