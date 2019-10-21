namespace librarySystem
{
    partial class frmBookUpdate
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
            this.mnuAddMem = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpBookId = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.mnuAddMem.SuspendLayout();
            this.grpBookDetails.SuspendLayout();
            this.grpBookId.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddMem
            // 
            this.mnuAddMem.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAddMem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAddMem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuAddMem.Location = new System.Drawing.Point(0, 0);
            this.mnuAddMem.Name = "mnuAddMem";
            this.mnuAddMem.Size = new System.Drawing.Size(337, 24);
            this.mnuAddMem.TabIndex = 2;
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
            // grpBookDetails
            // 
            this.grpBookDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpBookDetails.Controls.Add(this.lblStatus);
            this.grpBookDetails.Controls.Add(this.txtStatus);
            this.grpBookDetails.Controls.Add(this.lblIsbn);
            this.grpBookDetails.Controls.Add(this.txtIsbn);
            this.grpBookDetails.Controls.Add(this.cboCategory);
            this.grpBookDetails.Controls.Add(this.txtAuthor);
            this.grpBookDetails.Controls.Add(this.txtTitle);
            this.grpBookDetails.Controls.Add(this.btnUpdate);
            this.grpBookDetails.Controls.Add(this.lblTitle);
            this.grpBookDetails.Controls.Add(this.lblAuthor);
            this.grpBookDetails.Controls.Add(this.lblCategory);
            this.grpBookDetails.ForeColor = System.Drawing.Color.Black;
            this.grpBookDetails.Location = new System.Drawing.Point(11, 121);
            this.grpBookDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookDetails.Size = new System.Drawing.Size(311, 240);
            this.grpBookDetails.TabIndex = 11;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "Update Book Details";
            this.grpBookDetails.Visible = false;
            this.grpBookDetails.Enter += new System.EventHandler(this.grpBookDetails_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(53, 167);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(114, 164);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(135, 20);
            this.txtStatus.TabIndex = 24;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(58, 35);
            this.lblIsbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 23;
            this.lblIsbn.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(114, 32);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.MaxLength = 13;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(135, 20);
            this.txtIsbn.TabIndex = 1;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(114, 129);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(133, 21);
            this.cboCategory.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(114, 97);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(135, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(114, 65);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(135, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 204);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(63, 68);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(49, 100);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author: ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(41, 132);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // grpBookId
            // 
            this.grpBookId.BackColor = System.Drawing.SystemColors.Control;
            this.grpBookId.Controls.Add(this.btnSubmit);
            this.grpBookId.Controls.Add(this.txtBookId);
            this.grpBookId.Location = new System.Drawing.Point(69, 38);
            this.grpBookId.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookId.Name = "grpBookId";
            this.grpBookId.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookId.Size = new System.Drawing.Size(200, 63);
            this.grpBookId.TabIndex = 12;
            this.grpBookId.TabStop = false;
            this.grpBookId.Text = "Enter Book Id";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(112, 26);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(59, 20);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(17, 27);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(81, 20);
            this.txtBookId.TabIndex = 1;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtBookId_TextChanged);
            // 
            // frmBookUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(337, 386);
            this.Controls.Add(this.grpBookId);
            this.Controls.Add(this.grpBookDetails);
            this.Controls.Add(this.mnuAddMem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBookUpdate";
            this.Text = "Update Book";
            this.Load += new System.EventHandler(this.frmBookUpdate_Load);
            this.mnuAddMem.ResumeLayout(false);
            this.mnuAddMem.PerformLayout();
            this.grpBookDetails.ResumeLayout(false);
            this.grpBookDetails.PerformLayout();
            this.grpBookId.ResumeLayout(false);
            this.grpBookId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddMem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.GroupBox grpBookId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}