namespace librarySystem
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoanBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayFine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListOverdueBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPerformBookCA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMembers,
            this.mnuBooks,
            this.mnuLoans,
            this.mnuAdmin,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMainMenu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuMembers
            // 
            this.menuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuUpdateMember,
            this.mnuViewMember});
            this.menuMembers.Name = "menuMembers";
            this.menuMembers.Size = new System.Drawing.Size(69, 20);
            this.menuMembers.Text = "Members";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(160, 22);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(160, 22);
            this.mnuUpdateMember.Text = "Update Member";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuViewMember
            // 
            this.mnuViewMember.Name = "mnuViewMember";
            this.mnuViewMember.Size = new System.Drawing.Size(160, 22);
            this.mnuViewMember.Text = "View Member";
            this.mnuViewMember.Click += new System.EventHandler(this.mnuViewMember_Click);
            // 
            // mnuBooks
            // 
            this.mnuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuUpdateBook,
            this.mnuViewBook,
            this.mnuDeleteBook});
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Size = new System.Drawing.Size(51, 20);
            this.mnuBooks.Text = "Books";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(142, 22);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(142, 22);
            this.mnuUpdateBook.Text = "Update Book";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuViewBook
            // 
            this.mnuViewBook.Name = "mnuViewBook";
            this.mnuViewBook.Size = new System.Drawing.Size(142, 22);
            this.mnuViewBook.Text = "View Book";
            this.mnuViewBook.Click += new System.EventHandler(this.mnuViewBook_Click);
            // 
            // mnuDeleteBook
            // 
            this.mnuDeleteBook.Name = "mnuDeleteBook";
            this.mnuDeleteBook.Size = new System.Drawing.Size(142, 22);
            this.mnuDeleteBook.Text = "Delete Book";
            this.mnuDeleteBook.Click += new System.EventHandler(this.mnuDeleteBook_Click);
            // 
            // mnuLoans
            // 
            this.mnuLoans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoanBook,
            this.mnuReturnBook,
            this.mnuPayFine});
            this.mnuLoans.Name = "mnuLoans";
            this.mnuLoans.Size = new System.Drawing.Size(50, 20);
            this.mnuLoans.Text = "Loans";
            // 
            // mnuLoanBook
            // 
            this.mnuLoanBook.Name = "mnuLoanBook";
            this.mnuLoanBook.Size = new System.Drawing.Size(180, 22);
            this.mnuLoanBook.Text = "Loan Book";
            this.mnuLoanBook.Click += new System.EventHandler(this.mnuLoanBook_Click);
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(180, 22);
            this.mnuReturnBook.Text = "Return Book";
            this.mnuReturnBook.Click += new System.EventHandler(this.mnuReturnBook_Click);
            // 
            // mnuPayFine
            // 
            this.mnuPayFine.Name = "mnuPayFine";
            this.mnuPayFine.Size = new System.Drawing.Size(180, 22);
            this.mnuPayFine.Text = "Pay Fine";
            this.mnuPayFine.Click += new System.EventHandler(this.mnuPayFine_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListOverdueBooks,
            this.mnuPerformBookCA});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdmin_Click);
            // 
            // mnuListOverdueBooks
            // 
            this.mnuListOverdueBooks.Name = "mnuListOverdueBooks";
            this.mnuListOverdueBooks.Size = new System.Drawing.Size(198, 22);
            this.mnuListOverdueBooks.Text = "List Overdue Books";
            this.mnuListOverdueBooks.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // mnuPerformBookCA
            // 
            this.mnuPerformBookCA.Name = "mnuPerformBookCA";
            this.mnuPerformBookCA.Size = new System.Drawing.Size(198, 22);
            this.mnuPerformBookCA.Text = "Book Category Analysis";
            this.mnuPerformBookCA.Click += new System.EventHandler(this.mnuPerformBookCA_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuLoans;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMember;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuViewBook;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem mnuLoanBook;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem mnuPayFine;
        private System.Windows.Forms.ToolStripMenuItem mnuListOverdueBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuPerformBookCA;
    }
}

