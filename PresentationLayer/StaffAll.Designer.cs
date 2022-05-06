namespace PresentationLayer
{
    partial class StaffAll
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
            this.btnAccentSensitive = new FontAwesome.Sharp.IconButton();
            this.btnClearSearch = new FontAwesome.Sharp.IconButton();
            this.btnSearchAdvance = new System.Windows.Forms.Button();
            this.btnSearchCaseSensitive = new FontAwesome.Sharp.IconButton();
            this.txbSearchBar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnTimeKeeping = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFront = new System.Windows.Forms.Button();
            this.dgStaffes = new System.Windows.Forms.DataGridView();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAccentSensitive);
            this.panel1.Controls.Add(this.btnClearSearch);
            this.panel1.Controls.Add(this.btnSearchAdvance);
            this.panel1.Controls.Add(this.btnSearchCaseSensitive);
            this.panel1.Controls.Add(this.txbSearchBar);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 48);
            this.panel1.TabIndex = 5;
            // 
            // btnAccentSensitive
            // 
            this.btnAccentSensitive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccentSensitive.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccentSensitive.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAccentSensitive.IconColor = System.Drawing.Color.Black;
            this.btnAccentSensitive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccentSensitive.Location = new System.Drawing.Point(666, 16);
            this.btnAccentSensitive.Name = "btnAccentSensitive";
            this.btnAccentSensitive.Size = new System.Drawing.Size(45, 24);
            this.btnAccentSensitive.TabIndex = 11;
            this.btnAccentSensitive.Text = "a͟b͟";
            this.tooltip.SetToolTip(this.btnAccentSensitive, "Có dấu, không dấu");
            this.btnAccentSensitive.UseVisualStyleBackColor = true;
            this.btnAccentSensitive.Click += new System.EventHandler(this.btnAccentSensitive_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.White;
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearSearch.IconColor = System.Drawing.Color.Black;
            this.btnClearSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearSearch.Location = new System.Drawing.Point(971, 8);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(39, 34);
            this.btnClearSearch.TabIndex = 10;
            this.btnClearSearch.Text = "✓";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearchAdvance
            // 
            this.btnSearchAdvance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAdvance.Location = new System.Drawing.Point(768, 8);
            this.btnSearchAdvance.Name = "btnSearchAdvance";
            this.btnSearchAdvance.Size = new System.Drawing.Size(197, 34);
            this.btnSearchAdvance.TabIndex = 9;
            this.btnSearchAdvance.Text = "Tìm kiếm nâng cao";
            this.btnSearchAdvance.UseVisualStyleBackColor = true;
            this.btnSearchAdvance.Click += new System.EventHandler(this.btnSearchAdvance_Click);
            // 
            // btnSearchCaseSensitive
            // 
            this.btnSearchCaseSensitive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCaseSensitive.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCaseSensitive.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchCaseSensitive.IconColor = System.Drawing.Color.Black;
            this.btnSearchCaseSensitive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCaseSensitive.Location = new System.Drawing.Point(717, 15);
            this.btnSearchCaseSensitive.Name = "btnSearchCaseSensitive";
            this.btnSearchCaseSensitive.Size = new System.Drawing.Size(45, 24);
            this.btnSearchCaseSensitive.TabIndex = 8;
            this.btnSearchCaseSensitive.Text = "Aa";
            this.tooltip.SetToolTip(this.btnSearchCaseSensitive, "Chữ hoa, thường");
            this.btnSearchCaseSensitive.UseVisualStyleBackColor = true;
            this.btnSearchCaseSensitive.Click += new System.EventHandler(this.btnSearchCaseSensitive_Click);
            // 
            // txbSearchBar
            // 
            this.txbSearchBar.Location = new System.Drawing.Point(285, 10);
            this.txbSearchBar.Name = "txbSearchBar";
            this.txbSearchBar.PlaceholderText = "Tìm kiếm";
            this.txbSearchBar.Size = new System.Drawing.Size(373, 31);
            this.txbSearchBar.TabIndex = 6;
            this.txbSearchBar.TextChanged += new System.EventHandler(this.txbSearchBar_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimeKeeping, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 48);
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
            this.btnAdd.Size = new System.Drawing.Size(51, 42);
            this.btnAdd.TabIndex = 0;
            this.tooltip.SetToolTip(this.btnAdd, "Thêm tài khoản");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 35;
            this.btnEdit.Location = new System.Drawing.Point(60, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 42);
            this.btnEdit.TabIndex = 1;
            this.tooltip.SetToolTip(this.btnEdit, "Sửa tài khoản");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 28;
            this.btnDelete.Location = new System.Drawing.Point(117, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 42);
            this.btnDelete.TabIndex = 2;
            this.tooltip.SetToolTip(this.btnDelete, "Xóa tài khoản");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTimeKeeping
            // 
            this.btnTimeKeeping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeKeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeKeeping.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnTimeKeeping.IconColor = System.Drawing.Color.Black;
            this.btnTimeKeeping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimeKeeping.IconSize = 30;
            this.btnTimeKeeping.Location = new System.Drawing.Point(174, 3);
            this.btnTimeKeeping.Name = "btnTimeKeeping";
            this.btnTimeKeeping.Size = new System.Drawing.Size(53, 42);
            this.btnTimeKeeping.TabIndex = 3;
            this.tooltip.SetToolTip(this.btnTimeKeeping, "Chấm công");
            this.btnTimeKeeping.UseVisualStyleBackColor = true;
            this.btnTimeKeeping.Click += new System.EventHandler(this.btnTimeKeeping_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1056, 0);
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
            // dgStaffes
            // 
            this.dgStaffes.AllowUserToAddRows = false;
            this.dgStaffes.AllowUserToDeleteRows = false;
            this.dgStaffes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStaffes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStaffes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgStaffes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStaffes.Location = new System.Drawing.Point(2, 56);
            this.dgStaffes.Name = "dgStaffes";
            this.dgStaffes.ReadOnly = true;
            this.dgStaffes.RowHeadersWidth = 62;
            this.dgStaffes.RowTemplate.Height = 33;
            this.dgStaffes.Size = new System.Drawing.Size(1362, 523);
            this.dgStaffes.TabIndex = 4;
            this.dgStaffes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStaffes_CellDoubleClick);
            // 
            // StaffAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgStaffes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffAll";
            this.Text = "StaffAll";
            this.Load += new System.EventHandler(this.StaffAll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnAdd;
        private ToolTip tooltip;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown numericUpDown1;
        private Button btnEnd;
        private Button btnNext;
        private Button btnBack;
        private Button btnFront;
        private DataGridView dgStaffes;
        private TextBox txbSearchBar;
        private FontAwesome.Sharp.IconButton btnSearchCaseSensitive;
        private Button btnSearchAdvance;
        private FontAwesome.Sharp.IconButton btnClearSearch;
        private FontAwesome.Sharp.IconButton btnAccentSensitive;
        private FontAwesome.Sharp.IconButton btnTimeKeeping;
    }
}