namespace LibraryFormProject.Admin
{
    partial class BookForm
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
            this.grdBook = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlExtraSmall = new System.Windows.Forms.Panel();
            this.cmBookName = new System.Windows.Forms.ComboBox();
            this.btnSmallSave = new ReaLTaiizor.Controls.AirButton();
            this.btnSmallClose = new ReaLTaiizor.Controls.AirButton();
            this.poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lblExtraSmall = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtExtraSmall = new ReaLTaiizor.Controls.DungeonTextBox();
            this.lblNameSmall = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtNameSmall = new ReaLTaiizor.Controls.DungeonTextBox();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDel = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnBookEdit = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnBookAdd = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAutDel = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnAutEdit = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnAutAdd = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.grdAuthors = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPubDel = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnPubEdit = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnPubAdd = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.grdPub = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCopyDel = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnCopyEdit = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.btnCopyAdd = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.grdCopy = new System.Windows.Forms.DataGridView();
            this.txtSearchBook = new ReaLTaiizor.Controls.BigTextBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.pnlEditDelBooks = new System.Windows.Forms.Panel();
            this.poisonLabel7 = new ReaLTaiizor.Controls.PoisonLabel();
            this.btnBookSave = new ReaLTaiizor.Controls.AirButton();
            this.clAut = new System.Windows.Forms.CheckedListBox();
            this.cmPublisher = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmCategory = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtDesc = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.btnClose = new ReaLTaiizor.Controls.AirButton();
            this.btnPnlClose = new ReaLTaiizor.Controls.Button();
            this.poisonLabel9 = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtProfit = new ReaLTaiizor.Controls.DungeonTextBox();
            this.poisonLabel10 = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtStatus = new ReaLTaiizor.Controls.DungeonTextBox();
            this.poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtPage = new ReaLTaiizor.Controls.DungeonTextBox();
            this.poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtLanguage = new ReaLTaiizor.Controls.DungeonTextBox();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtBookName = new ReaLTaiizor.Controls.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlExtraSmall.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthors)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPub)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCopy)).BeginInit();
            this.pnlEditDelBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBook
            // 
            this.grdBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBook.Location = new System.Drawing.Point(0, 0);
            this.grdBook.Name = "grdBook";
            this.grdBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBook.Size = new System.Drawing.Size(543, 164);
            this.grdBook.TabIndex = 12;
            this.grdBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBook_CellContentClick);
            this.grdBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBook_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlExtraSmall);
            this.panel1.Controls.Add(this.foreverLabel1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.txtSearchBook);
            this.panel1.Controls.Add(this.dungeonHeaderLabel1);
            this.panel1.Location = new System.Drawing.Point(190, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 384);
            this.panel1.TabIndex = 11;
            // 
            // pnlExtraSmall
            // 
            this.pnlExtraSmall.Controls.Add(this.cmBookName);
            this.pnlExtraSmall.Controls.Add(this.btnSmallSave);
            this.pnlExtraSmall.Controls.Add(this.btnSmallClose);
            this.pnlExtraSmall.Controls.Add(this.poisonLabel5);
            this.pnlExtraSmall.Controls.Add(this.lblExtraSmall);
            this.pnlExtraSmall.Controls.Add(this.txtExtraSmall);
            this.pnlExtraSmall.Controls.Add(this.lblNameSmall);
            this.pnlExtraSmall.Controls.Add(this.txtNameSmall);
            this.pnlExtraSmall.Location = new System.Drawing.Point(178, 10);
            this.pnlExtraSmall.Name = "pnlExtraSmall";
            this.pnlExtraSmall.Size = new System.Drawing.Size(229, 303);
            this.pnlExtraSmall.TabIndex = 20;
            this.pnlExtraSmall.Visible = false;
            // 
            // cmBookName
            // 
            this.cmBookName.FormattingEnabled = true;
            this.cmBookName.Location = new System.Drawing.Point(105, 75);
            this.cmBookName.Name = "cmBookName";
            this.cmBookName.Size = new System.Drawing.Size(121, 21);
            this.cmBookName.TabIndex = 38;
            this.cmBookName.Visible = false;
            // 
            // btnSmallSave
            // 
            this.btnSmallSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmallSave.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnSmallSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSmallSave.Image = null;
            this.btnSmallSave.Location = new System.Drawing.Point(140, 230);
            this.btnSmallSave.Name = "btnSmallSave";
            this.btnSmallSave.NoRounding = false;
            this.btnSmallSave.Size = new System.Drawing.Size(83, 42);
            this.btnSmallSave.TabIndex = 37;
            this.btnSmallSave.Text = "Save";
            this.btnSmallSave.Transparent = false;
            this.btnSmallSave.Click += new System.EventHandler(this.btnSmallSave_Click);
            // 
            // btnSmallClose
            // 
            this.btnSmallClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmallClose.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnSmallClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSmallClose.Image = null;
            this.btnSmallClose.Location = new System.Drawing.Point(8, 230);
            this.btnSmallClose.Name = "btnSmallClose";
            this.btnSmallClose.NoRounding = false;
            this.btnSmallClose.Size = new System.Drawing.Size(79, 42);
            this.btnSmallClose.TabIndex = 36;
            this.btnSmallClose.Text = "Close";
            this.btnSmallClose.Transparent = false;
            this.btnSmallClose.Click += new System.EventHandler(this.btnSmallClose_Click);
            // 
            // poisonLabel5
            // 
            this.poisonLabel5.AutoSize = true;
            this.poisonLabel5.Location = new System.Drawing.Point(8, 13);
            this.poisonLabel5.Name = "poisonLabel5";
            this.poisonLabel5.Size = new System.Drawing.Size(65, 19);
            this.poisonLabel5.TabIndex = 20;
            this.poisonLabel5.Text = "Add/Edit ";
            // 
            // lblExtraSmall
            // 
            this.lblExtraSmall.AutoSize = true;
            this.lblExtraSmall.Location = new System.Drawing.Point(8, 121);
            this.lblExtraSmall.Name = "lblExtraSmall";
            this.lblExtraSmall.Size = new System.Drawing.Size(66, 19);
            this.lblExtraSmall.TabIndex = 19;
            this.lblExtraSmall.Text = "Language";
            // 
            // txtExtraSmall
            // 
            this.txtExtraSmall.BackColor = System.Drawing.Color.Transparent;
            this.txtExtraSmall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtExtraSmall.EdgeColor = System.Drawing.Color.White;
            this.txtExtraSmall.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtExtraSmall.ForeColor = System.Drawing.Color.DimGray;
            this.txtExtraSmall.Location = new System.Drawing.Point(121, 112);
            this.txtExtraSmall.MaxLength = 32767;
            this.txtExtraSmall.Multiline = false;
            this.txtExtraSmall.Name = "txtExtraSmall";
            this.txtExtraSmall.ReadOnly = false;
            this.txtExtraSmall.Size = new System.Drawing.Size(95, 28);
            this.txtExtraSmall.TabIndex = 18;
            this.txtExtraSmall.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtExtraSmall.UseSystemPasswordChar = false;
            // 
            // lblNameSmall
            // 
            this.lblNameSmall.AutoSize = true;
            this.lblNameSmall.Location = new System.Drawing.Point(8, 77);
            this.lblNameSmall.Name = "lblNameSmall";
            this.lblNameSmall.Size = new System.Drawing.Size(79, 19);
            this.lblNameSmall.TabIndex = 17;
            this.lblNameSmall.Text = "Book Name";
            // 
            // txtNameSmall
            // 
            this.txtNameSmall.BackColor = System.Drawing.Color.Transparent;
            this.txtNameSmall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNameSmall.EdgeColor = System.Drawing.Color.White;
            this.txtNameSmall.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNameSmall.ForeColor = System.Drawing.Color.DimGray;
            this.txtNameSmall.Location = new System.Drawing.Point(121, 68);
            this.txtNameSmall.MaxLength = 32767;
            this.txtNameSmall.Multiline = false;
            this.txtNameSmall.Name = "txtNameSmall";
            this.txtNameSmall.ReadOnly = false;
            this.txtNameSmall.Size = new System.Drawing.Size(95, 28);
            this.txtNameSmall.TabIndex = 16;
            this.txtNameSmall.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNameSmall.UseSystemPasswordChar = false;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel1.Location = new System.Drawing.Point(22, 47);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(61, 13);
            this.foreverLabel1.TabIndex = 21;
            this.foreverLabel1.Text = "Search Bar";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(21, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 255);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.btnBookEdit);
            this.tabPage1.Controls.Add(this.btnBookAdd);
            this.tabPage1.Controls.Add(this.grdBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDel.Image = null;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnDel.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDel.Location = new System.Drawing.Point(386, 176);
            this.btnDel.Name = "btnDel";
            this.btnDel.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDel.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnDel.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnDel.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnDel.Size = new System.Drawing.Size(144, 40);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Delete ";
            this.btnDel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnBookEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBookEdit.Image = null;
            this.btnBookEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookEdit.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnBookEdit.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnBookEdit.Location = new System.Drawing.Point(200, 176);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnBookEdit.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnBookEdit.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnBookEdit.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnBookEdit.Size = new System.Drawing.Size(144, 40);
            this.btnBookEdit.TabIndex = 18;
            this.btnBookEdit.Text = "Edit";
            this.btnBookEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBookEdit.Visible = false;
            this.btnBookEdit.Click += new System.EventHandler(this.btnBookEdit_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnBookAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBookAdd.Image = null;
            this.btnBookAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookAdd.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnBookAdd.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnBookAdd.Location = new System.Drawing.Point(16, 176);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnBookAdd.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnBookAdd.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnBookAdd.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnBookAdd.Size = new System.Drawing.Size(144, 40);
            this.btnBookAdd.TabIndex = 17;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAutDel);
            this.tabPage2.Controls.Add(this.btnAutEdit);
            this.tabPage2.Controls.Add(this.btnAutAdd);
            this.tabPage2.Controls.Add(this.grdAuthors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAutDel
            // 
            this.btnAutDel.BackColor = System.Drawing.Color.Transparent;
            this.btnAutDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAutDel.Image = null;
            this.btnAutDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutDel.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnAutDel.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAutDel.Location = new System.Drawing.Point(386, 173);
            this.btnAutDel.Name = "btnAutDel";
            this.btnAutDel.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAutDel.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnAutDel.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnAutDel.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnAutDel.Size = new System.Drawing.Size(144, 40);
            this.btnAutDel.TabIndex = 22;
            this.btnAutDel.Text = "Delete ";
            this.btnAutDel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAutDel.Visible = false;
            this.btnAutDel.Click += new System.EventHandler(this.btnAutDel_Click);
            // 
            // btnAutEdit
            // 
            this.btnAutEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnAutEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAutEdit.Image = null;
            this.btnAutEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutEdit.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnAutEdit.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAutEdit.Location = new System.Drawing.Point(200, 173);
            this.btnAutEdit.Name = "btnAutEdit";
            this.btnAutEdit.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAutEdit.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnAutEdit.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnAutEdit.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnAutEdit.Size = new System.Drawing.Size(144, 40);
            this.btnAutEdit.TabIndex = 21;
            this.btnAutEdit.Text = "Edit";
            this.btnAutEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAutEdit.Visible = false;
            this.btnAutEdit.Click += new System.EventHandler(this.btnAutEdit_Click);
            // 
            // btnAutAdd
            // 
            this.btnAutAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAutAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAutAdd.Image = null;
            this.btnAutAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutAdd.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnAutAdd.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAutAdd.Location = new System.Drawing.Point(16, 173);
            this.btnAutAdd.Name = "btnAutAdd";
            this.btnAutAdd.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAutAdd.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnAutAdd.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnAutAdd.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnAutAdd.Size = new System.Drawing.Size(144, 40);
            this.btnAutAdd.TabIndex = 20;
            this.btnAutAdd.Text = "Add";
            this.btnAutAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAutAdd.Click += new System.EventHandler(this.btnAutAdd_Click);
            // 
            // grdAuthors
            // 
            this.grdAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAuthors.Location = new System.Drawing.Point(0, 3);
            this.grdAuthors.Name = "grdAuthors";
            this.grdAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAuthors.Size = new System.Drawing.Size(543, 164);
            this.grdAuthors.TabIndex = 13;
            this.grdAuthors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAuthors_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPubDel);
            this.tabPage3.Controls.Add(this.btnPubEdit);
            this.tabPage3.Controls.Add(this.btnPubAdd);
            this.tabPage3.Controls.Add(this.grdPub);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(542, 229);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Publishers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPubDel
            // 
            this.btnPubDel.BackColor = System.Drawing.Color.Transparent;
            this.btnPubDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPubDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPubDel.Image = null;
            this.btnPubDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPubDel.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPubDel.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPubDel.Location = new System.Drawing.Point(384, 173);
            this.btnPubDel.Name = "btnPubDel";
            this.btnPubDel.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnPubDel.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnPubDel.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnPubDel.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnPubDel.Size = new System.Drawing.Size(144, 40);
            this.btnPubDel.TabIndex = 22;
            this.btnPubDel.Text = "Delete ";
            this.btnPubDel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPubDel.Visible = false;
            this.btnPubDel.Click += new System.EventHandler(this.btnPubDel_Click);
            // 
            // btnPubEdit
            // 
            this.btnPubEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnPubEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPubEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPubEdit.Image = null;
            this.btnPubEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPubEdit.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPubEdit.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPubEdit.Location = new System.Drawing.Point(198, 173);
            this.btnPubEdit.Name = "btnPubEdit";
            this.btnPubEdit.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnPubEdit.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnPubEdit.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnPubEdit.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnPubEdit.Size = new System.Drawing.Size(144, 40);
            this.btnPubEdit.TabIndex = 21;
            this.btnPubEdit.Text = "Edit";
            this.btnPubEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPubEdit.Visible = false;
            this.btnPubEdit.Click += new System.EventHandler(this.btnPubEdit_Click);
            // 
            // btnPubAdd
            // 
            this.btnPubAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnPubAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPubAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPubAdd.Image = null;
            this.btnPubAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPubAdd.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPubAdd.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPubAdd.Location = new System.Drawing.Point(14, 173);
            this.btnPubAdd.Name = "btnPubAdd";
            this.btnPubAdd.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnPubAdd.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnPubAdd.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnPubAdd.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnPubAdd.Size = new System.Drawing.Size(144, 40);
            this.btnPubAdd.TabIndex = 20;
            this.btnPubAdd.Text = "Add";
            this.btnPubAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPubAdd.Click += new System.EventHandler(this.btnPubAdd_Click);
            // 
            // grdPub
            // 
            this.grdPub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPub.Location = new System.Drawing.Point(0, 3);
            this.grdPub.Name = "grdPub";
            this.grdPub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPub.Size = new System.Drawing.Size(543, 164);
            this.grdPub.TabIndex = 13;
            this.grdPub.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPub_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCopyDel);
            this.tabPage4.Controls.Add(this.btnCopyEdit);
            this.tabPage4.Controls.Add(this.btnCopyAdd);
            this.tabPage4.Controls.Add(this.grdCopy);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(542, 229);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Copies";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCopyDel
            // 
            this.btnCopyDel.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCopyDel.Image = null;
            this.btnCopyDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyDel.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnCopyDel.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCopyDel.Location = new System.Drawing.Point(381, 173);
            this.btnCopyDel.Name = "btnCopyDel";
            this.btnCopyDel.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCopyDel.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnCopyDel.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnCopyDel.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnCopyDel.Size = new System.Drawing.Size(144, 40);
            this.btnCopyDel.TabIndex = 22;
            this.btnCopyDel.Text = "Delete ";
            this.btnCopyDel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCopyDel.Visible = false;
            this.btnCopyDel.Click += new System.EventHandler(this.btnCopyDel_Click);
            // 
            // btnCopyEdit
            // 
            this.btnCopyEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCopyEdit.Image = null;
            this.btnCopyEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyEdit.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnCopyEdit.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCopyEdit.Location = new System.Drawing.Point(195, 173);
            this.btnCopyEdit.Name = "btnCopyEdit";
            this.btnCopyEdit.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCopyEdit.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnCopyEdit.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnCopyEdit.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnCopyEdit.Size = new System.Drawing.Size(144, 40);
            this.btnCopyEdit.TabIndex = 21;
            this.btnCopyEdit.Text = "Edit";
            this.btnCopyEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCopyEdit.Visible = false;
            this.btnCopyEdit.Click += new System.EventHandler(this.btnCopyEdit_Click);
            // 
            // btnCopyAdd
            // 
            this.btnCopyAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCopyAdd.Image = null;
            this.btnCopyAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyAdd.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnCopyAdd.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCopyAdd.Location = new System.Drawing.Point(11, 173);
            this.btnCopyAdd.Name = "btnCopyAdd";
            this.btnCopyAdd.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCopyAdd.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnCopyAdd.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnCopyAdd.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnCopyAdd.Size = new System.Drawing.Size(144, 40);
            this.btnCopyAdd.TabIndex = 20;
            this.btnCopyAdd.Text = "Add";
            this.btnCopyAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCopyAdd.Click += new System.EventHandler(this.btnCopyAdd_Click);
            // 
            // grdCopy
            // 
            this.grdCopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCopy.Location = new System.Drawing.Point(0, 3);
            this.grdCopy.Name = "grdCopy";
            this.grdCopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCopy.Size = new System.Drawing.Size(543, 164);
            this.grdCopy.TabIndex = 13;
            this.grdCopy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCopy_CellContentClick);
            this.grdCopy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCopy_CellDoubleClick);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchBook.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSearchBook.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBook.Image = null;
            this.txtSearchBook.Location = new System.Drawing.Point(21, 63);
            this.txtSearchBook.MaxLength = 32767;
            this.txtSearchBook.Multiline = false;
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.ReadOnly = false;
            this.txtSearchBook.Size = new System.Drawing.Size(546, 41);
            this.txtSearchBook.TabIndex = 10;
            this.txtSearchBook.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchBook.UseSystemPasswordChar = false;
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtSearchBook_TextChanged);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(17, 20);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(52, 20);
            this.dungeonHeaderLabel1.TabIndex = 0;
            this.dungeonHeaderLabel1.Text = "Books";
            // 
            // pnlEditDelBooks
            // 
            this.pnlEditDelBooks.BackColor = System.Drawing.Color.White;
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel7);
            this.pnlEditDelBooks.Controls.Add(this.btnBookSave);
            this.pnlEditDelBooks.Controls.Add(this.clAut);
            this.pnlEditDelBooks.Controls.Add(this.cmPublisher);
            this.pnlEditDelBooks.Controls.Add(this.cmCategory);
            this.pnlEditDelBooks.Controls.Add(this.txtDesc);
            this.pnlEditDelBooks.Controls.Add(this.btnClose);
            this.pnlEditDelBooks.Controls.Add(this.btnPnlClose);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel9);
            this.pnlEditDelBooks.Controls.Add(this.txtProfit);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel10);
            this.pnlEditDelBooks.Controls.Add(this.txtStatus);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel6);
            this.pnlEditDelBooks.Controls.Add(this.txtPage);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel8);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel3);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel4);
            this.pnlEditDelBooks.Controls.Add(this.txtLanguage);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel2);
            this.pnlEditDelBooks.Controls.Add(this.poisonLabel1);
            this.pnlEditDelBooks.Controls.Add(this.txtBookName);
            this.pnlEditDelBooks.Location = new System.Drawing.Point(350, 12);
            this.pnlEditDelBooks.Name = "pnlEditDelBooks";
            this.pnlEditDelBooks.Size = new System.Drawing.Size(280, 452);
            this.pnlEditDelBooks.TabIndex = 19;
            this.pnlEditDelBooks.Visible = false;
            // 
            // poisonLabel7
            // 
            this.poisonLabel7.AutoSize = true;
            this.poisonLabel7.Location = new System.Drawing.Point(18, 225);
            this.poisonLabel7.Name = "poisonLabel7";
            this.poisonLabel7.Size = new System.Drawing.Size(54, 19);
            this.poisonLabel7.TabIndex = 36;
            this.poisonLabel7.Text = "Authors";
            // 
            // btnBookSave
            // 
            this.btnBookSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookSave.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnBookSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBookSave.Image = null;
            this.btnBookSave.Location = new System.Drawing.Point(179, 388);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.NoRounding = false;
            this.btnBookSave.Size = new System.Drawing.Size(87, 42);
            this.btnBookSave.TabIndex = 35;
            this.btnBookSave.Text = "Save";
            this.btnBookSave.Transparent = false;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // clAut
            // 
            this.clAut.FormattingEnabled = true;
            this.clAut.Location = new System.Drawing.Point(113, 225);
            this.clAut.Name = "clAut";
            this.clAut.Size = new System.Drawing.Size(153, 49);
            this.clAut.TabIndex = 21;
            // 
            // cmPublisher
            // 
            this.cmPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmPublisher.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmPublisher.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmPublisher.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmPublisher.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmPublisher.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmPublisher.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmPublisher.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmPublisher.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmPublisher.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmPublisher.DropDownHeight = 100;
            this.cmPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmPublisher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmPublisher.FormattingEnabled = true;
            this.cmPublisher.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmPublisher.IntegralHeight = false;
            this.cmPublisher.ItemHeight = 20;
            this.cmPublisher.Location = new System.Drawing.Point(131, 142);
            this.cmPublisher.Name = "cmPublisher";
            this.cmPublisher.Size = new System.Drawing.Size(135, 26);
            this.cmPublisher.StartIndex = 0;
            this.cmPublisher.TabIndex = 34;
            // 
            // cmCategory
            // 
            this.cmCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmCategory.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmCategory.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmCategory.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmCategory.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmCategory.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmCategory.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmCategory.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmCategory.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmCategory.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmCategory.DropDownHeight = 100;
            this.cmCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmCategory.FormattingEnabled = true;
            this.cmCategory.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmCategory.IntegralHeight = false;
            this.cmCategory.ItemHeight = 20;
            this.cmCategory.Location = new System.Drawing.Point(131, 98);
            this.cmCategory.Name = "cmCategory";
            this.cmCategory.Size = new System.Drawing.Size(135, 26);
            this.cmCategory.StartIndex = 0;
            this.cmCategory.TabIndex = 33;
            this.cmCategory.SelectedIndexChanged += new System.EventHandler(this.cmCategory_SelectedIndexChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.AnimateReadOnly = false;
            this.txtDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.Depth = 0;
            this.txtDesc.HideSelection = true;
            this.txtDesc.Location = new System.Drawing.Point(16, 297);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ReadOnly = false;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(250, 85);
            this.txtDesc.TabIndex = 32;
            this.txtDesc.TabStop = false;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(16, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.NoRounding = false;
            this.btnClose.Size = new System.Drawing.Size(87, 42);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.Transparent = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPnlClose
            // 
            this.btnPnlClose.BackColor = System.Drawing.Color.Transparent;
            this.btnPnlClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPnlClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPnlClose.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnPnlClose.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPnlClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPnlClose.Image = null;
            this.btnPnlClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPnlClose.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPnlClose.Location = new System.Drawing.Point(295, 110);
            this.btnPnlClose.Name = "btnPnlClose";
            this.btnPnlClose.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnPnlClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnPnlClose.Size = new System.Drawing.Size(120, 40);
            this.btnPnlClose.TabIndex = 30;
            this.btnPnlClose.Text = "Close";
            this.btnPnlClose.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // poisonLabel9
            // 
            this.poisonLabel9.AutoSize = true;
            this.poisonLabel9.Location = new System.Drawing.Point(295, 63);
            this.poisonLabel9.Name = "poisonLabel9";
            this.poisonLabel9.Size = new System.Drawing.Size(41, 19);
            this.poisonLabel9.TabIndex = 29;
            this.poisonLabel9.Text = "Profit";
            // 
            // txtProfit
            // 
            this.txtProfit.BackColor = System.Drawing.Color.Transparent;
            this.txtProfit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtProfit.EdgeColor = System.Drawing.Color.White;
            this.txtProfit.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtProfit.ForeColor = System.Drawing.Color.DimGray;
            this.txtProfit.Location = new System.Drawing.Point(408, 54);
            this.txtProfit.MaxLength = 32767;
            this.txtProfit.Multiline = false;
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = false;
            this.txtProfit.Size = new System.Drawing.Size(135, 28);
            this.txtProfit.TabIndex = 28;
            this.txtProfit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProfit.UseSystemPasswordChar = false;
            // 
            // poisonLabel10
            // 
            this.poisonLabel10.AutoSize = true;
            this.poisonLabel10.Location = new System.Drawing.Point(295, 21);
            this.poisonLabel10.Name = "poisonLabel10";
            this.poisonLabel10.Size = new System.Drawing.Size(43, 19);
            this.poisonLabel10.TabIndex = 27;
            this.poisonLabel10.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtStatus.EdgeColor = System.Drawing.Color.White;
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtStatus.ForeColor = System.Drawing.Color.DimGray;
            this.txtStatus.Location = new System.Drawing.Point(408, 12);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Multiline = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = false;
            this.txtStatus.Size = new System.Drawing.Size(135, 28);
            this.txtStatus.TabIndex = 26;
            this.txtStatus.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStatus.UseSystemPasswordChar = false;
            // 
            // poisonLabel6
            // 
            this.poisonLabel6.AutoSize = true;
            this.poisonLabel6.Location = new System.Drawing.Point(18, 191);
            this.poisonLabel6.Name = "poisonLabel6";
            this.poisonLabel6.Size = new System.Drawing.Size(91, 19);
            this.poisonLabel6.TabIndex = 23;
            this.poisonLabel6.Text = "Page Number";
            // 
            // txtPage
            // 
            this.txtPage.BackColor = System.Drawing.Color.Transparent;
            this.txtPage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPage.EdgeColor = System.Drawing.Color.White;
            this.txtPage.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPage.ForeColor = System.Drawing.Color.DimGray;
            this.txtPage.Location = new System.Drawing.Point(131, 182);
            this.txtPage.MaxLength = 32767;
            this.txtPage.Multiline = false;
            this.txtPage.Name = "txtPage";
            this.txtPage.ReadOnly = false;
            this.txtPage.Size = new System.Drawing.Size(135, 28);
            this.txtPage.TabIndex = 20;
            this.txtPage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPage.UseSystemPasswordChar = false;
            // 
            // poisonLabel8
            // 
            this.poisonLabel8.AutoSize = true;
            this.poisonLabel8.Location = new System.Drawing.Point(18, 149);
            this.poisonLabel8.Name = "poisonLabel8";
            this.poisonLabel8.Size = new System.Drawing.Size(62, 19);
            this.poisonLabel8.TabIndex = 19;
            this.poisonLabel8.Text = "Publisher";
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.Location = new System.Drawing.Point(18, 105);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(64, 19);
            this.poisonLabel3.TabIndex = 17;
            this.poisonLabel3.Text = "Category";
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.Location = new System.Drawing.Point(18, 63);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(66, 19);
            this.poisonLabel4.TabIndex = 15;
            this.poisonLabel4.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.BackColor = System.Drawing.Color.Transparent;
            this.txtLanguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtLanguage.EdgeColor = System.Drawing.Color.White;
            this.txtLanguage.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtLanguage.ForeColor = System.Drawing.Color.DimGray;
            this.txtLanguage.Location = new System.Drawing.Point(131, 54);
            this.txtLanguage.MaxLength = 32767;
            this.txtLanguage.Multiline = false;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = false;
            this.txtLanguage.Size = new System.Drawing.Size(135, 28);
            this.txtLanguage.TabIndex = 14;
            this.txtLanguage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLanguage.UseSystemPasswordChar = false;
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(18, 275);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(74, 19);
            this.poisonLabel2.TabIndex = 13;
            this.poisonLabel2.Text = "Description";
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(18, 21);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(79, 19);
            this.poisonLabel1.TabIndex = 11;
            this.poisonLabel1.Text = "Book Name";
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.Transparent;
            this.txtBookName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtBookName.EdgeColor = System.Drawing.Color.White;
            this.txtBookName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBookName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBookName.Location = new System.Drawing.Point(131, 12);
            this.txtBookName.MaxLength = 32767;
            this.txtBookName.Multiline = false;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = false;
            this.txtBookName.Size = new System.Drawing.Size(135, 28);
            this.txtBookName.TabIndex = 10;
            this.txtBookName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBookName.UseSystemPasswordChar = false;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 459);
            this.Controls.Add(this.pnlEditDelBooks);
            this.Controls.Add(this.panel1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlEditDelBooks, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlExtraSmall.ResumeLayout(false);
            this.pnlExtraSmall.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthors)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPub)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCopy)).EndInit();
            this.pnlEditDelBooks.ResumeLayout(false);
            this.pnlEditDelBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBook;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtSearchBook;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView grdAuthors;
        private System.Windows.Forms.DataGridView grdPub;
        private System.Windows.Forms.DataGridView grdCopy;
        private ReaLTaiizor.Controls.ChatButtonLeft btnDel;
        private ReaLTaiizor.Controls.ChatButtonLeft btnBookEdit;
        private ReaLTaiizor.Controls.ChatButtonLeft btnBookAdd;
        private ReaLTaiizor.Controls.ChatButtonLeft btnAutDel;
        private ReaLTaiizor.Controls.ChatButtonLeft btnAutEdit;
        private ReaLTaiizor.Controls.ChatButtonLeft btnAutAdd;
        private ReaLTaiizor.Controls.ChatButtonLeft btnPubDel;
        private ReaLTaiizor.Controls.ChatButtonLeft btnPubEdit;
        private ReaLTaiizor.Controls.ChatButtonLeft btnPubAdd;
        private ReaLTaiizor.Controls.ChatButtonLeft btnCopyDel;
        private ReaLTaiizor.Controls.ChatButtonLeft btnCopyEdit;
        private ReaLTaiizor.Controls.ChatButtonLeft btnCopyAdd;
        private System.Windows.Forms.Panel pnlEditDelBooks;
        private ReaLTaiizor.Controls.AirButton btnClose;
        private ReaLTaiizor.Controls.Button btnPnlClose;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel9;
        private ReaLTaiizor.Controls.DungeonTextBox txtProfit;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel10;
        private ReaLTaiizor.Controls.DungeonTextBox txtStatus;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel6;
        private ReaLTaiizor.Controls.DungeonTextBox txtPage;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel8;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.DungeonTextBox txtLanguage;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtBookName;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDesc;
        private ReaLTaiizor.Controls.DungeonComboBox cmPublisher;
        private ReaLTaiizor.Controls.DungeonComboBox cmCategory;
        private System.Windows.Forms.Panel pnlExtraSmall;
        private ReaLTaiizor.Controls.PoisonLabel lblExtraSmall;
        private ReaLTaiizor.Controls.DungeonTextBox txtExtraSmall;
        private ReaLTaiizor.Controls.PoisonLabel lblNameSmall;
        private ReaLTaiizor.Controls.DungeonTextBox txtNameSmall;
        private ReaLTaiizor.Controls.AirButton btnSmallSave;
        private ReaLTaiizor.Controls.AirButton btnSmallClose;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel5;
        private ReaLTaiizor.Controls.AirButton btnBookSave;
        private System.Windows.Forms.ComboBox cmBookName;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel7;
        private System.Windows.Forms.CheckedListBox clAut;
    }
}