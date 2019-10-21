namespace librarySystem
{
    partial class frmReturnBook
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
            this.grpMemberId = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpLoanDetails = new System.Windows.Forms.GroupBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblLoanItems = new System.Windows.Forms.Label();
            this.lblLoanId = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lstLoanItems = new System.Windows.Forms.ListBox();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.grpReturnDate = new System.Windows.Forms.GroupBox();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.mnuAddMem = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFineDetails = new System.Windows.Forms.GroupBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpMemberId.SuspendLayout();
            this.grpLoanDetails.SuspendLayout();
            this.grpReturnDate.SuspendLayout();
            this.mnuAddMem.SuspendLayout();
            this.grpFineDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMemberId
            // 
            this.grpMemberId.BackColor = System.Drawing.SystemColors.Control;
            this.grpMemberId.Controls.Add(this.btnSubmit);
            this.grpMemberId.Controls.Add(this.txtMemId);
            this.grpMemberId.Location = new System.Drawing.Point(23, 58);
            this.grpMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Name = "grpMemberId";
            this.grpMemberId.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Size = new System.Drawing.Size(202, 65);
            this.grpMemberId.TabIndex = 3;
            this.grpMemberId.TabStop = false;
            this.grpMemberId.Text = "Enter Member Id";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(111, 22);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(59, 20);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(14, 22);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(81, 20);
            this.txtMemId.TabIndex = 1;
            // 
            // grpLoanDetails
            // 
            this.grpLoanDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpLoanDetails.Controls.Add(this.lblDueDate);
            this.grpLoanDetails.Controls.Add(this.lblLoanItems);
            this.grpLoanDetails.Controls.Add(this.lblLoanId);
            this.grpLoanDetails.Controls.Add(this.dtpDueDate);
            this.grpLoanDetails.Controls.Add(this.lstLoanItems);
            this.grpLoanDetails.Controls.Add(this.txtLoanId);
            this.grpLoanDetails.Location = new System.Drawing.Point(287, 58);
            this.grpLoanDetails.Name = "grpLoanDetails";
            this.grpLoanDetails.Size = new System.Drawing.Size(261, 162);
            this.grpLoanDetails.TabIndex = 6;
            this.grpLoanDetails.TabStop = false;
            this.grpLoanDetails.Text = "Loan Details";
            this.grpLoanDetails.Visible = false;
            this.grpLoanDetails.Enter += new System.EventHandler(this.grpMember_Enter);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(12, 129);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 9;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblLoanItems
            // 
            this.lblLoanItems.AutoSize = true;
            this.lblLoanItems.Location = new System.Drawing.Point(6, 52);
            this.lblLoanItems.Name = "lblLoanItems";
            this.lblLoanItems.Size = new System.Drawing.Size(62, 13);
            this.lblLoanItems.TabIndex = 8;
            this.lblLoanItems.Text = "Loan Items:";
            // 
            // lblLoanId
            // 
            this.lblLoanId.AutoSize = true;
            this.lblLoanId.Location = new System.Drawing.Point(22, 22);
            this.lblLoanId.Name = "lblLoanId";
            this.lblLoanId.Size = new System.Drawing.Size(46, 13);
            this.lblLoanId.TabIndex = 7;
            this.lblLoanId.Text = "Loan Id:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(81, 123);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(174, 20);
            this.dtpDueDate.TabIndex = 6;
            // 
            // lstLoanItems
            // 
            this.lstLoanItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLoanItems.FormattingEnabled = true;
            this.lstLoanItems.Location = new System.Drawing.Point(81, 48);
            this.lstLoanItems.Name = "lstLoanItems";
            this.lstLoanItems.Size = new System.Drawing.Size(174, 65);
            this.lstLoanItems.TabIndex = 5;
            // 
            // txtLoanId
            // 
            this.txtLoanId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoanId.Enabled = false;
            this.txtLoanId.Location = new System.Drawing.Point(81, 22);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.Size = new System.Drawing.Size(85, 13);
            this.txtLoanId.TabIndex = 0;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(14, 19);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(182, 20);
            this.dtpReturnDate.TabIndex = 3;
            // 
            // grpReturnDate
            // 
            this.grpReturnDate.BackColor = System.Drawing.SystemColors.Control;
            this.grpReturnDate.Controls.Add(this.btnConfirmReturn);
            this.grpReturnDate.Controls.Add(this.dtpReturnDate);
            this.grpReturnDate.Location = new System.Drawing.Point(23, 259);
            this.grpReturnDate.Name = "grpReturnDate";
            this.grpReturnDate.Size = new System.Drawing.Size(202, 81);
            this.grpReturnDate.TabIndex = 7;
            this.grpReturnDate.TabStop = false;
            this.grpReturnDate.Text = "Return Date";
            this.grpReturnDate.Visible = false;
            this.grpReturnDate.Enter += new System.EventHandler(this.grpReturnDate_Enter);
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.Location = new System.Drawing.Point(46, 50);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(91, 21);
            this.btnConfirmReturn.TabIndex = 6;
            this.btnConfirmReturn.Text = "Confirm Return";
            this.btnConfirmReturn.UseVisualStyleBackColor = true;
            this.btnConfirmReturn.Click += new System.EventHandler(this.btnConfirmReturn_Click_1);
            // 
            // mnuAddMem
            // 
            this.mnuAddMem.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAddMem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAddMem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuAddMem.Location = new System.Drawing.Point(0, 0);
            this.mnuAddMem.Name = "mnuAddMem";
            this.mnuAddMem.Size = new System.Drawing.Size(570, 24);
            this.mnuAddMem.TabIndex = 8;
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
            // grpFineDetails
            // 
            this.grpFineDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpFineDetails.Controls.Add(this.lblFine);
            this.grpFineDetails.Controls.Add(this.txtFine);
            this.grpFineDetails.Controls.Add(this.btnClear);
            this.grpFineDetails.Controls.Add(this.label3);
            this.grpFineDetails.Location = new System.Drawing.Point(287, 259);
            this.grpFineDetails.Name = "grpFineDetails";
            this.grpFineDetails.Size = new System.Drawing.Size(261, 81);
            this.grpFineDetails.TabIndex = 9;
            this.grpFineDetails.TabStop = false;
            this.grpFineDetails.Text = "Fine Details";
            this.grpFineDetails.Visible = false;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(22, 50);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(79, 13);
            this.lblFine.TabIndex = 11;
            this.lblFine.Text = "Estimated Fine:";
            // 
            // txtFine
            // 
            this.txtFine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFine.Enabled = false;
            this.txtFine.Location = new System.Drawing.Point(107, 51);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(51, 13);
            this.txtFine.TabIndex = 10;
            this.txtFine.TextChanged += new System.EventHandler(this.txtFine_TextChanged_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 51);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 20);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Done";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fine of €0.50 per day is added for late return.";
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(570, 373);
            this.Controls.Add(this.grpFineDetails);
            this.Controls.Add(this.mnuAddMem);
            this.Controls.Add(this.grpReturnDate);
            this.Controls.Add(this.grpLoanDetails);
            this.Controls.Add(this.grpMemberId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReturnBook";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            this.grpMemberId.ResumeLayout(false);
            this.grpMemberId.PerformLayout();
            this.grpLoanDetails.ResumeLayout(false);
            this.grpLoanDetails.PerformLayout();
            this.grpReturnDate.ResumeLayout(false);
            this.mnuAddMem.ResumeLayout(false);
            this.mnuAddMem.PerformLayout();
            this.grpFineDetails.ResumeLayout(false);
            this.grpFineDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemberId;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpLoanDetails;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.GroupBox grpReturnDate;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.MenuStrip mnuAddMem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ListBox lstLoanItems;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblLoanItems;
        private System.Windows.Forms.Label lblLoanId;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.GroupBox grpFineDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
    }
}