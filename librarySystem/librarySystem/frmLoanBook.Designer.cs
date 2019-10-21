namespace librarySystem
{
    partial class frmLoanBook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpMemberId = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpBookId = new System.Windows.Forms.GroupBox();
            this.btmSubmit2 = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.txtBookId2 = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblLoanId = new System.Windows.Forms.Label();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.grpLoanId = new System.Windows.Forms.GroupBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpMemberId.SuspendLayout();
            this.grpBookId.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpBookDetails.SuspendLayout();
            this.grpLoanId.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpMemberId
            // 
            this.grpMemberId.BackColor = System.Drawing.SystemColors.Control;
            this.grpMemberId.Controls.Add(this.btnSubmit);
            this.grpMemberId.Controls.Add(this.txtMemId);
            this.grpMemberId.Location = new System.Drawing.Point(11, 177);
            this.grpMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Name = "grpMemberId";
            this.grpMemberId.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Size = new System.Drawing.Size(200, 53);
            this.grpMemberId.TabIndex = 2;
            this.grpMemberId.TabStop = false;
            this.grpMemberId.Text = "Enter Member Id";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(111, 17);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(59, 20);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(14, 17);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(81, 20);
            this.txtMemId.TabIndex = 1;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // grpBookId
            // 
            this.grpBookId.BackColor = System.Drawing.SystemColors.Control;
            this.grpBookId.Controls.Add(this.btmSubmit2);
            this.grpBookId.Controls.Add(this.txtBookId);
            this.grpBookId.Location = new System.Drawing.Point(11, 277);
            this.grpBookId.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookId.Name = "grpBookId";
            this.grpBookId.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookId.Size = new System.Drawing.Size(200, 52);
            this.grpBookId.TabIndex = 3;
            this.grpBookId.TabStop = false;
            this.grpBookId.Text = "Enter Book Id";
            this.grpBookId.Visible = false;
            this.grpBookId.Enter += new System.EventHandler(this.grpIsbn_Enter);
            // 
            // btmSubmit2
            // 
            this.btmSubmit2.Location = new System.Drawing.Point(111, 17);
            this.btmSubmit2.Margin = new System.Windows.Forms.Padding(2);
            this.btmSubmit2.Name = "btmSubmit2";
            this.btmSubmit2.Size = new System.Drawing.Size(59, 20);
            this.btmSubmit2.TabIndex = 2;
            this.btmSubmit2.Text = "Submit";
            this.btmSubmit2.UseVisualStyleBackColor = true;
            this.btmSubmit2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(14, 18);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(81, 20);
            this.txtBookId.TabIndex = 1;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtBookId_TextChanged);
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpMemberDetails.Controls.Add(this.txtAddress);
            this.grpMemberDetails.Controls.Add(this.txtForename);
            this.grpMemberDetails.Controls.Add(this.txtSurname);
            this.grpMemberDetails.Location = new System.Drawing.Point(306, 177);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(210, 66);
            this.grpMemberDetails.TabIndex = 5;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details";
            this.grpMemberDetails.Visible = false;
            this.grpMemberDetails.Enter += new System.EventHandler(this.grpMemberDetails_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(15, 40);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(178, 13);
            this.txtAddress.TabIndex = 2;
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(107, 18);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(86, 13);
            this.txtForename.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(15, 17);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(86, 13);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // grpBook
            // 
            this.grpBook.BackColor = System.Drawing.SystemColors.Control;
            this.grpBook.Controls.Add(this.btnDel);
            this.grpBook.Controls.Add(this.btnFinish);
            this.grpBook.Controls.Add(this.lstCart);
            this.grpBook.Controls.Add(this.txtTitle2);
            this.grpBook.Controls.Add(this.txtBookId2);
            this.grpBook.Controls.Add(this.btnAddToCart);
            this.grpBook.Location = new System.Drawing.Point(12, 372);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(518, 138);
            this.grpBook.TabIndex = 6;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Add Book ";
            this.grpBook.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(309, 94);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(54, 20);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(369, 94);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(60, 20);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(248, 32);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(256, 56);
            this.lstCart.TabIndex = 8;
            // 
            // txtTitle2
            // 
            this.txtTitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle2.Enabled = false;
            this.txtTitle2.Location = new System.Drawing.Point(72, 32);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(127, 13);
            this.txtTitle2.TabIndex = 7;
            // 
            // txtBookId2
            // 
            this.txtBookId2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookId2.Enabled = false;
            this.txtBookId2.Location = new System.Drawing.Point(13, 32);
            this.txtBookId2.Name = "txtBookId2";
            this.txtBookId2.Size = new System.Drawing.Size(45, 13);
            this.txtBookId2.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(24, 67);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(162, 21);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add Book to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click_1);
            // 
            // lblLoanId
            // 
            this.lblLoanId.AutoSize = true;
            this.lblLoanId.Location = new System.Drawing.Point(12, 37);
            this.lblLoanId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanId.Name = "lblLoanId";
            this.lblLoanId.Size = new System.Drawing.Size(46, 13);
            this.lblLoanId.TabIndex = 21;
            this.lblLoanId.Text = "Loan Id:";
            // 
            // txtLoanId
            // 
            this.txtLoanId.Enabled = false;
            this.txtLoanId.Location = new System.Drawing.Point(62, 34);
            this.txtLoanId.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.Size = new System.Drawing.Size(53, 20);
            this.txtLoanId.TabIndex = 20;
            this.txtLoanId.TextChanged += new System.EventHandler(this.txtLoanId_TextChanged);
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpBookDetails.Controls.Add(this.txtTitle);
            this.grpBookDetails.Controls.Add(this.txtAuthor);
            this.grpBookDetails.Location = new System.Drawing.Point(306, 277);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Size = new System.Drawing.Size(210, 66);
            this.grpBookDetails.TabIndex = 22;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "Book Details";
            this.grpBookDetails.Visible = false;
            this.grpBookDetails.Enter += new System.EventHandler(this.grpBookDetails_Enter);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(15, 40);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(178, 13);
            this.txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(15, 17);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(178, 13);
            this.txtAuthor.TabIndex = 0;
            // 
            // grpLoanId
            // 
            this.grpLoanId.BackColor = System.Drawing.SystemColors.Control;
            this.grpLoanId.Controls.Add(this.dtpDueDate);
            this.grpLoanId.Controls.Add(this.dtpLoanDate);
            this.grpLoanId.Controls.Add(this.lblLoanDate);
            this.grpLoanId.Controls.Add(this.lblDueDate);
            this.grpLoanId.Controls.Add(this.lblLoanId);
            this.grpLoanId.Controls.Add(this.txtLoanId);
            this.grpLoanId.Location = new System.Drawing.Point(10, 39);
            this.grpLoanId.Name = "grpLoanId";
            this.grpLoanId.Size = new System.Drawing.Size(520, 111);
            this.grpLoanId.TabIndex = 23;
            this.grpLoanId.TabStop = false;
            this.grpLoanId.Text = "Information";
            this.grpLoanId.Enter += new System.EventHandler(this.grpLoanId_Enter);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(315, 65);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(191, 20);
            this.dtpDueDate.TabIndex = 25;
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Location = new System.Drawing.Point(315, 28);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(191, 20);
            this.dtpLoanDate.TabIndex = 24;
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Location = new System.Drawing.Point(247, 34);
            this.lblLoanDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(63, 13);
            this.lblLoanDate.TabIndex = 23;
            this.lblLoanDate.Text = "Loan Date: ";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(247, 71);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 22;
            this.lblDueDate.Text = "Due Date:";
            // 
            // frmLoanBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(552, 526);
            this.Controls.Add(this.grpLoanId);
            this.Controls.Add(this.grpBookDetails);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.grpMemberDetails);
            this.Controls.Add(this.grpBookId);
            this.Controls.Add(this.grpMemberId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoanBook";
            this.Text = "Loan Book";
            this.Load += new System.EventHandler(this.frmLoanBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMemberId.ResumeLayout(false);
            this.grpMemberId.PerformLayout();
            this.grpBookId.ResumeLayout(false);
            this.grpBookId.PerformLayout();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpBookDetails.ResumeLayout(false);
            this.grpBookDetails.PerformLayout();
            this.grpLoanId.ResumeLayout(false);
            this.grpLoanId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpMemberId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpBookId;
        private System.Windows.Forms.Button btmSubmit2;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.TextBox txtBookId2;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblLoanId;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.GroupBox grpLoanId;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
    }
}