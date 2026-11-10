namespace LibraryFormProject.Admin
{
    partial class CategoryForm
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
            this.pnlAddCat = new System.Windows.Forms.Panel();
            this.btnCancel = new ReaLTaiizor.Controls.FoxButton();
            this.btnSaveCat = new ReaLTaiizor.Controls.FoxButton();
            this.txtCategoryDesc = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.txtCategoryName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.btnDelCate = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnEditcCate = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnAddBook = new ReaLTaiizor.Controls.Button();
            this.grdCate = new System.Windows.Forms.DataGridView();
            this.txtSearchCateMain = new ReaLTaiizor.Controls.BigTextBox();
            this.dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            this.panel1.SuspendLayout();
            this.pnlAddCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.foxLabel3);
            this.panel1.Controls.Add(this.pnlAddCat);
            this.panel1.Controls.Add(this.btnDelCate);
            this.panel1.Controls.Add(this.btnEditcCate);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.grdCate);
            this.panel1.Controls.Add(this.txtSearchCateMain);
            this.panel1.Controls.Add(this.dungeonHeaderLabel2);
            this.panel1.Controls.Add(this.dungeonHeaderLabel1);
            this.panel1.Location = new System.Drawing.Point(193, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 384);
            this.panel1.TabIndex = 12;
            // 
            // pnlAddCat
            // 
            this.pnlAddCat.Controls.Add(this.btnCancel);
            this.pnlAddCat.Controls.Add(this.btnSaveCat);
            this.pnlAddCat.Controls.Add(this.txtCategoryDesc);
            this.pnlAddCat.Controls.Add(this.txtCategoryName);
            this.pnlAddCat.Controls.Add(this.foxLabel2);
            this.pnlAddCat.Controls.Add(this.foxLabel1);
            this.pnlAddCat.Controls.Add(this.dungeonHeaderLabel3);
            this.pnlAddCat.Location = new System.Drawing.Point(79, 39);
            this.pnlAddCat.Name = "pnlAddCat";
            this.pnlAddCat.Size = new System.Drawing.Size(422, 345);
            this.pnlAddCat.TabIndex = 13;
            this.pnlAddCat.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnCancel.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.btnCancel.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCancel.EnabledCalc = true;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btnCancel.Location = new System.Drawing.Point(192, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancel.Size = new System.Drawing.Size(97, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.btnCancel_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSaveCat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnSaveCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCat.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSaveCat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnSaveCat.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.btnSaveCat.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSaveCat.EnabledCalc = true;
            this.btnSaveCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSaveCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btnSaveCat.Location = new System.Drawing.Point(295, 308);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSaveCat.Size = new System.Drawing.Size(97, 34);
            this.btnSaveCat.TabIndex = 5;
            this.btnSaveCat.Text = "Save";
            this.btnSaveCat.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.btnSaveCat_Click);
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.AnimateReadOnly = false;
            this.txtCategoryDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCategoryDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCategoryDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryDesc.Depth = 0;
            this.txtCategoryDesc.HideSelection = true;
            this.txtCategoryDesc.Location = new System.Drawing.Point(21, 169);
            this.txtCategoryDesc.MaxLength = 32767;
            this.txtCategoryDesc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.PasswordChar = '\0';
            this.txtCategoryDesc.ReadOnly = false;
            this.txtCategoryDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryDesc.SelectedText = "";
            this.txtCategoryDesc.SelectionLength = 0;
            this.txtCategoryDesc.SelectionStart = 0;
            this.txtCategoryDesc.ShortcutsEnabled = true;
            this.txtCategoryDesc.Size = new System.Drawing.Size(371, 140);
            this.txtCategoryDesc.TabIndex = 4;
            this.txtCategoryDesc.TabStop = false;
            this.txtCategoryDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategoryDesc.UseSystemPasswordChar = false;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCategoryName.EdgeColor = System.Drawing.Color.White;
            this.txtCategoryName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCategoryName.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategoryName.Location = new System.Drawing.Point(21, 77);
            this.txtCategoryName.MaxLength = 32767;
            this.txtCategoryName.Multiline = false;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = false;
            this.txtCategoryName.Size = new System.Drawing.Size(371, 28);
            this.txtCategoryName.TabIndex = 3;
            this.txtCategoryName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategoryName.UseSystemPasswordChar = false;
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(21, 144);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(114, 19);
            this.foxLabel2.TabIndex = 2;
            this.foxLabel2.Text = "Description";
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(21, 52);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(114, 19);
            this.foxLabel1.TabIndex = 1;
            this.foxLabel1.Text = "Category Name";
            // 
            // dungeonHeaderLabel3
            // 
            this.dungeonHeaderLabel3.AutoSize = true;
            this.dungeonHeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel3.Location = new System.Drawing.Point(17, 19);
            this.dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            this.dungeonHeaderLabel3.Size = new System.Drawing.Size(144, 20);
            this.dungeonHeaderLabel3.TabIndex = 0;
            this.dungeonHeaderLabel3.Text = "Add/Edit  Category";
            // 
            // btnDelCate
            // 
            this.btnDelCate.BackColor = System.Drawing.Color.Transparent;
            this.btnDelCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelCate.Image = null;
            this.btnDelCate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelCate.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnDelCate.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDelCate.Location = new System.Drawing.Point(311, 328);
            this.btnDelCate.Name = "btnDelCate";
            this.btnDelCate.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDelCate.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnDelCate.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnDelCate.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnDelCate.Size = new System.Drawing.Size(260, 40);
            this.btnDelCate.TabIndex = 15;
            this.btnDelCate.Text = "Delete Category";
            this.btnDelCate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelCate.Visible = false;
            this.btnDelCate.Click += new System.EventHandler(this.btnDelCate_Click);
            // 
            // btnEditcCate
            // 
            this.btnEditcCate.BackColor = System.Drawing.Color.Transparent;
            this.btnEditcCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditcCate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditcCate.Image = null;
            this.btnEditcCate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditcCate.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnEditcCate.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEditcCate.Location = new System.Drawing.Point(21, 328);
            this.btnEditcCate.Name = "btnEditcCate";
            this.btnEditcCate.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEditcCate.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnEditcCate.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnEditcCate.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnEditcCate.Size = new System.Drawing.Size(260, 40);
            this.btnEditcCate.TabIndex = 14;
            this.btnEditcCate.Text = "Edit Category";
            this.btnEditcCate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEditcCate.Visible = false;
            this.btnEditcCate.Click += new System.EventHandler(this.btnEditcCate_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAddBook.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddBook.Image = null;
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAddBook.Location = new System.Drawing.Point(468, 64);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAddBook.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAddBook.Size = new System.Drawing.Size(103, 40);
            this.btnAddBook.TabIndex = 13;
            this.btnAddBook.Text = "Add Category";
            this.btnAddBook.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // grdCate
            // 
            this.grdCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCate.Location = new System.Drawing.Point(21, 159);
            this.grdCate.Name = "grdCate";
            this.grdCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCate.Size = new System.Drawing.Size(550, 163);
            this.grdCate.TabIndex = 12;
            this.grdCate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCate_CellDoubleClick);
            // 
            // txtSearchCateMain
            // 
            this.txtSearchCateMain.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchCateMain.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSearchCateMain.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchCateMain.Image = null;
            this.txtSearchCateMain.Location = new System.Drawing.Point(21, 63);
            this.txtSearchCateMain.MaxLength = 32767;
            this.txtSearchCateMain.Multiline = false;
            this.txtSearchCateMain.Name = "txtSearchCateMain";
            this.txtSearchCateMain.ReadOnly = false;
            this.txtSearchCateMain.Size = new System.Drawing.Size(441, 41);
            this.txtSearchCateMain.TabIndex = 10;
            this.txtSearchCateMain.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchCateMain.UseSystemPasswordChar = false;
            this.txtSearchCateMain.TextChanged += new System.EventHandler(this.txtSearchCateMain_TextChanged);
            this.txtSearchCateMain.Click += new System.EventHandler(this.txtSearchCateMain_Click);
            this.txtSearchCateMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchCateMain_MouseClick);
            // 
            // dungeonHeaderLabel2
            // 
            this.dungeonHeaderLabel2.AutoSize = true;
            this.dungeonHeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel2.Location = new System.Drawing.Point(26, 126);
            this.dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            this.dungeonHeaderLabel2.Size = new System.Drawing.Size(102, 20);
            this.dungeonHeaderLabel2.TabIndex = 9;
            this.dungeonHeaderLabel2.Text = "Category List";
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(17, 20);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(83, 20);
            this.dungeonHeaderLabel1.TabIndex = 0;
            this.dungeonHeaderLabel1.Text = "Categories";
            // 
            // foxLabel3
            // 
            this.foxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel3.ForeColor = System.Drawing.Color.Silver;
            this.foxLabel3.Location = new System.Drawing.Point(21, 43);
            this.foxLabel3.Name = "foxLabel3";
            this.foxLabel3.Size = new System.Drawing.Size(107, 19);
            this.foxLabel3.TabIndex = 16;
            this.foxLabel3.Text = "Search Category";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 446);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAddCat.ResumeLayout(false);
            this.pnlAddCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ChatButtonLeft btnDelCate;
        private ReaLTaiizor.Controls.ChatButtonLeft btnEditcCate;
        private ReaLTaiizor.Controls.Button btnAddBook;
        private System.Windows.Forms.DataGridView grdCate;
        private ReaLTaiizor.Controls.BigTextBox txtSearchCateMain;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private System.Windows.Forms.Panel pnlAddCat;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private ReaLTaiizor.Controls.FoxButton btnCancel;
        private ReaLTaiizor.Controls.FoxButton btnSaveCat;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtCategoryDesc;
        private ReaLTaiizor.Controls.DungeonTextBox txtCategoryName;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
    }
}