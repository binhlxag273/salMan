namespace PresentationLayer
{
    partial class ChildFormCategory
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCategoryExtend = new FontAwesome.Sharp.IconButton();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.pnlCategoryContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnCategoryExtend);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 85);
            this.panel1.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(342, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 79);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Quyền danh mục";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnCategoryExtend
            // 
            this.btnCategoryExtend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryExtend.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.btnCategoryExtend.IconColor = System.Drawing.Color.Black;
            this.btnCategoryExtend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoryExtend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategoryExtend.Location = new System.Drawing.Point(171, 3);
            this.btnCategoryExtend.Name = "btnCategoryExtend";
            this.btnCategoryExtend.Size = new System.Drawing.Size(165, 79);
            this.btnCategoryExtend.TabIndex = 2;
            this.btnCategoryExtend.Text = "Danh mục khác";
            this.btnCategoryExtend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategoryExtend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategoryExtend.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.Affiliatetheme;
            this.btnCategory.IconColor = System.Drawing.Color.Black;
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategory.Location = new System.Drawing.Point(0, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(165, 79);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Danh mục";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // pnlCategoryContainer
            // 
            this.pnlCategoryContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategoryContainer.Location = new System.Drawing.Point(0, 86);
            this.pnlCategoryContainer.Name = "pnlCategoryContainer";
            this.pnlCategoryContainer.Size = new System.Drawing.Size(824, 377);
            this.pnlCategoryContainer.TabIndex = 3;
            // 
            // ChildFormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 465);
            this.Controls.Add(this.pnlCategoryContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFormCategory";
            this.Text = "ChildFormCategory";
            this.Load += new System.EventHandler(this.ChildFormCategory_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCategoryExtend;
        private FontAwesome.Sharp.IconButton btnCategory;
        private Panel pnlCategoryContainer;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}