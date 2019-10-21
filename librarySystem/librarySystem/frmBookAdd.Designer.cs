namespace librarySystem
{
    partial class frmBookAdd
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.mnuAddMem = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBook.SuspendLayout();
            this.mnuAddMem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.BackColor = System.Drawing.SystemColors.Control;
            this.grpBook.Controls.Add(this.btnClear);
            this.grpBook.Controls.Add(this.lblIsbn);
            this.grpBook.Controls.Add(this.txtIsbn);
            this.grpBook.Controls.Add(this.cboCategory);
            this.grpBook.Controls.Add(this.lblBookId);
            this.grpBook.Controls.Add(this.txtBookId);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Controls.Add(this.txtTitle);
            this.grpBook.Controls.Add(this.btnAdd);
            this.grpBook.Controls.Add(this.lblTitle);
            this.grpBook.Controls.Add(this.lblAuthor);
            this.grpBook.Controls.Add(this.lblCategory);
            this.grpBook.ForeColor = System.Drawing.Color.Black;
            this.grpBook.Location = new System.Drawing.Point(11, 37);
            this.grpBook.Margin = new System.Windows.Forms.Padding(2);
            this.grpBook.Name = "grpBook";
            this.grpBook.Padding = new System.Windows.Forms.Padding(2);
            this.grpBook.Size = new System.Drawing.Size(359, 270);
            this.grpBook.TabIndex = 10;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Enter Book Details";
            this.grpBook.Enter += new System.EventHandler(this.grpBook_Enter);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(64, 80);
            this.lblIsbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 22;
            this.lblIsbn.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(112, 77);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.MaxLength = 13;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(135, 20);
            this.txtIsbn.TabIndex = 1;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(112, 178);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(133, 21);
            this.cboCategory.TabIndex = 4;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(52, 37);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(47, 13);
            this.lblBookId.TabIndex = 19;
            this.lblBookId.Text = "Book Id:";
            this.lblBookId.Click += new System.EventHandler(this.lblBookId_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(112, 34);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(61, 20);
            this.txtBookId.TabIndex = 16;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtBookId_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(112, 146);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.MaxLength = 20;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(191, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(112, 111);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(191, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 228);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(69, 114);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(55, 149);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author: ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(47, 181);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // mnuAddMem
            // 
            this.mnuAddMem.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAddMem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAddMem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuAddMem.Location = new System.Drawing.Point(0, 0);
            this.mnuAddMem.Name = "mnuAddMem";
            this.mnuAddMem.Size = new System.Drawing.Size(383, 24);
            this.mnuAddMem.TabIndex = 11;
            this.mnuAddMem.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(175, 228);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(383, 319);
            this.Controls.Add(this.mnuAddMem);
            this.Controls.Add(this.grpBook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBookAdd";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.frmBookAdd_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.mnuAddMem.ResumeLayout(false);
            this.mnuAddMem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.MenuStrip mnuAddMem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Button btnClear;
    }
}