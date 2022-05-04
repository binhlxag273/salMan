namespace PresentationLayer
{
    partial class CategoryAll
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnImport = new FontAwesome.Sharp.IconButton();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFront = new System.Windows.Forms.Button();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpenDetail = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 48);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.iconButton3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnImport, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExport, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOpenDetail, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 48);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 35;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 42);
            this.btnAdd.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnAdd, "Thêm danh mục");
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 35;
            this.btnEdit.Location = new System.Drawing.Point(51, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 42);
            this.btnEdit.TabIndex = 1;
            this.tooltip.SetToolTip(this.btnEdit, "Sửa danh mục");
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 28;
            this.iconButton3.Location = new System.Drawing.Point(99, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(39, 42);
            this.iconButton3.TabIndex = 2;
            this.tooltip.SetToolTip(this.iconButton3, "Xóa danh mục");
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnImport.IconColor = System.Drawing.Color.Black;
            this.btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImport.IconSize = 30;
            this.btnImport.Location = new System.Drawing.Point(144, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(42, 42);
            this.btnImport.TabIndex = 3;
            this.tooltip.SetToolTip(this.btnImport, "Import");
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnExport.IconColor = System.Drawing.Color.Black;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 30;
            this.btnExport.Location = new System.Drawing.Point(192, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(39, 42);
            this.btnExport.TabIndex = 4;
            this.tooltip.SetToolTip(this.btnExport, "Export");
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEnd, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFront, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(849, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 48);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(113, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 39);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnd
            // 
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnd.Location = new System.Drawing.Point(253, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(50, 42);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = ">>";
            this.tooltip.SetToolTip(this.btnEnd, "Trang cuối");
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(198, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 42);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.tooltip.SetToolTip(this.btnNext, "Trang tiếp");
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Location = new System.Drawing.Point(58, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.tooltip.SetToolTip(this.btnBack, "Trang trước");
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnFront
            // 
            this.btnFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFront.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFront.Location = new System.Drawing.Point(3, 3);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(49, 42);
            this.btnFront.TabIndex = 0;
            this.btnFront.Text = "<<";
            this.tooltip.SetToolTip(this.btnFront, "Đầu trang");
            this.btnFront.UseVisualStyleBackColor = true;
            // 
            // dgCategories
            // 
            this.dgCategories.AllowUserToAddRows = false;
            this.dgCategories.AllowUserToDeleteRows = false;
            this.dgCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategories.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Location = new System.Drawing.Point(0, 55);
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.ReadOnly = true;
            this.dgCategories.RowHeadersWidth = 62;
            this.dgCategories.RowTemplate.Height = 33;
            this.dgCategories.Size = new System.Drawing.Size(1155, 549);
            this.dgCategories.TabIndex = 2;
            // 
            // btnOpenDetail
            // 
            this.btnOpenDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenDetail.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.btnOpenDetail.IconColor = System.Drawing.Color.Black;
            this.btnOpenDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenDetail.IconSize = 30;
            this.btnOpenDetail.Location = new System.Drawing.Point(237, 3);
            this.btnOpenDetail.Name = "btnOpenDetail";
            this.btnOpenDetail.Size = new System.Drawing.Size(46, 42);
            this.btnOpenDetail.TabIndex = 5;
            this.tooltip.SetToolTip(this.btnOpenDetail, "Mở danh mục chi tiết");
            this.btnOpenDetail.UseVisualStyleBackColor = true;
            // 
            // CategoryAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryAll";
            this.Text = "CategoryAll";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnAdd;
        private ToolTip tooltip;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnImport;
        private FontAwesome.Sharp.IconButton btnExport;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown numericUpDown1;
        private Button btnEnd;
        private Button btnNext;
        private Button btnBack;
        private Button btnFront;
        private DataGridView dgCategories;
        private FontAwesome.Sharp.IconButton btnOpenDetail;
    }
}