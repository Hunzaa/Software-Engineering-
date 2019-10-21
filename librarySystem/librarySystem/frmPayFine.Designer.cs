namespace librarySystem
{
    partial class frmPayFine
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
            this.grpMemberId = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.grpPaymentType = new System.Windows.Forms.GroupBox();
            this.radFull = new System.Windows.Forms.RadioButton();
            this.radPartial = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpFineDetails = new System.Windows.Forms.GroupBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.grpReceipt = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMemId2 = new System.Windows.Forms.Label();
            this.txtMemId2 = new System.Windows.Forms.TextBox();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.txtForename2 = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mnuAddMem.SuspendLayout();
            this.grpMemberId.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpPaymentType.SuspendLayout();
            this.grpFineDetails.SuspendLayout();
            this.grpReceipt.SuspendLayout();
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
            this.mnuAddMem.Size = new System.Drawing.Size(598, 24);
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
            // grpMemberId
            // 
            this.grpMemberId.BackColor = System.Drawing.SystemColors.Control;
            this.grpMemberId.Controls.Add(this.btnSubmit);
            this.grpMemberId.Controls.Add(this.txtMemId);
            this.grpMemberId.Location = new System.Drawing.Point(26, 50);
            this.grpMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Name = "grpMemberId";
            this.grpMemberId.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Size = new System.Drawing.Size(207, 49);
            this.grpMemberId.TabIndex = 3;
            this.grpMemberId.TabStop = false;
            this.grpMemberId.Text = "Enter Member Id";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 17);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(59, 20);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(20, 18);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(81, 20);
            this.txtMemId.TabIndex = 1;
            // 
            // grpPayment
            // 
            this.grpPayment.BackColor = System.Drawing.SystemColors.Control;
            this.grpPayment.Controls.Add(this.grpPaymentType);
            this.grpPayment.Controls.Add(this.lblAmount);
            this.grpPayment.Controls.Add(this.btnPay);
            this.grpPayment.Controls.Add(this.txtAmount);
            this.grpPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpPayment.Location = new System.Drawing.Point(26, 174);
            this.grpPayment.Margin = new System.Windows.Forms.Padding(2);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Padding = new System.Windows.Forms.Padding(2);
            this.grpPayment.Size = new System.Drawing.Size(207, 175);
            this.grpPayment.TabIndex = 7;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment:";
            this.grpPayment.Visible = false;
            this.grpPayment.Enter += new System.EventHandler(this.grpPaymentDetails_Enter);
            // 
            // grpPaymentType
            // 
            this.grpPaymentType.Controls.Add(this.radFull);
            this.grpPaymentType.Controls.Add(this.radPartial);
            this.grpPaymentType.Location = new System.Drawing.Point(12, 37);
            this.grpPaymentType.Name = "grpPaymentType";
            this.grpPaymentType.Size = new System.Drawing.Size(167, 45);
            this.grpPaymentType.TabIndex = 13;
            this.grpPaymentType.TabStop = false;
            this.grpPaymentType.Text = "Select an option: ";
            // 
            // radFull
            // 
            this.radFull.AutoSize = true;
            this.radFull.Checked = true;
            this.radFull.Location = new System.Drawing.Point(23, 19);
            this.radFull.Name = "radFull";
            this.radFull.Size = new System.Drawing.Size(41, 17);
            this.radFull.TabIndex = 10;
            this.radFull.TabStop = true;
            this.radFull.Text = "Full";
            this.radFull.UseVisualStyleBackColor = true;
            this.radFull.CheckedChanged += new System.EventHandler(this.radFull_CheckedChanged);
            // 
            // radPartial
            // 
            this.radPartial.AutoSize = true;
            this.radPartial.Location = new System.Drawing.Point(98, 17);
            this.radPartial.Name = "radPartial";
            this.radPartial.Size = new System.Drawing.Size(54, 17);
            this.radPartial.TabIndex = 9;
            this.radPartial.Text = "Partial";
            this.radPartial.UseVisualStyleBackColor = true;
            this.radPartial.CheckedChanged += new System.EventHandler(this.radPartial_CheckedChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(32, 100);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 13);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount €: ";
            this.lblAmount.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(74, 143);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(59, 20);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(94, 97);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(39, 20);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Visible = false;
            this.txtAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpFineDetails
            // 
            this.grpFineDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpFineDetails.Controls.Add(this.lblFine);
            this.grpFineDetails.Controls.Add(this.txtFine);
            this.grpFineDetails.Controls.Add(this.txtForename);
            this.grpFineDetails.Controls.Add(this.txtSurname);
            this.grpFineDetails.Location = new System.Drawing.Point(284, 50);
            this.grpFineDetails.Name = "grpFineDetails";
            this.grpFineDetails.Size = new System.Drawing.Size(207, 74);
            this.grpFineDetails.TabIndex = 8;
            this.grpFineDetails.TabStop = false;
            this.grpFineDetails.Text = "Member Details";
            this.grpFineDetails.Visible = false;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.BackColor = System.Drawing.SystemColors.Control;
            this.lblFine.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFine.Location = new System.Drawing.Point(12, 45);
            this.lblFine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(69, 13);
            this.lblFine.TabIndex = 23;
            this.lblFine.Text = "Total Fine €: ";
            // 
            // txtFine
            // 
            this.txtFine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFine.Enabled = false;
            this.txtFine.Location = new System.Drawing.Point(86, 45);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(40, 13);
            this.txtFine.TabIndex = 23;
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(107, 18);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(86, 13);
            this.txtForename.TabIndex = 22;
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(15, 17);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(86, 13);
            this.txtSurname.TabIndex = 21;
            // 
            // grpReceipt
            // 
            this.grpReceipt.BackColor = System.Drawing.SystemColors.Control;
            this.grpReceipt.Controls.Add(this.btnPrint);
            this.grpReceipt.Controls.Add(this.button1);
            this.grpReceipt.Controls.Add(this.lblMemId2);
            this.grpReceipt.Controls.Add(this.txtMemId2);
            this.grpReceipt.Controls.Add(this.dtpPayDate);
            this.grpReceipt.Controls.Add(this.lblDate);
            this.grpReceipt.Controls.Add(this.label1);
            this.grpReceipt.Controls.Add(this.lblPaymentId);
            this.grpReceipt.Controls.Add(this.txtPaymentId);
            this.grpReceipt.Controls.Add(this.lblAmountPaid);
            this.grpReceipt.Controls.Add(this.txtPayAmount);
            this.grpReceipt.Controls.Add(this.txtForename2);
            this.grpReceipt.Location = new System.Drawing.Point(284, 174);
            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Size = new System.Drawing.Size(288, 202);
            this.grpReceipt.TabIndex = 9;
            this.grpReceipt.TabStop = false;
            this.grpReceipt.Text = "Receipt";
            this.grpReceipt.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 20);
            this.button1.TabIndex = 32;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblMemId2
            // 
            this.lblMemId2.AutoSize = true;
            this.lblMemId2.BackColor = System.Drawing.SystemColors.Control;
            this.lblMemId2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMemId2.Location = new System.Drawing.Point(28, 54);
            this.lblMemId2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemId2.Name = "lblMemId2";
            this.lblMemId2.Size = new System.Drawing.Size(60, 13);
            this.lblMemId2.TabIndex = 30;
            this.lblMemId2.Text = "Member Id:";
            // 
            // txtMemId2
            // 
            this.txtMemId2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemId2.Enabled = false;
            this.txtMemId2.Location = new System.Drawing.Point(96, 54);
            this.txtMemId2.Name = "txtMemId2";
            this.txtMemId2.Size = new System.Drawing.Size(86, 13);
            this.txtMemId2.TabIndex = 6;
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Location = new System.Drawing.Point(96, 107);
            this.dtpPayDate.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(179, 20);
            this.dtpPayDate.TabIndex = 27;
            this.dtpPayDate.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 113);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 13);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Payment Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Member Name:";
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.BackColor = System.Drawing.SystemColors.Control;
            this.lblPaymentId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPaymentId.Location = new System.Drawing.Point(28, 28);
            this.lblPaymentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(63, 13);
            this.lblPaymentId.TabIndex = 25;
            this.lblPaymentId.Text = "Payment Id:";
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaymentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaymentId.Enabled = false;
            this.txtPaymentId.Location = new System.Drawing.Point(96, 28);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.ReadOnly = true;
            this.txtPaymentId.Size = new System.Drawing.Size(86, 13);
            this.txtPaymentId.TabIndex = 24;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmountPaid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAmountPaid.Location = new System.Drawing.Point(9, 143);
            this.lblAmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(82, 13);
            this.lblAmountPaid.TabIndex = 23;
            this.lblAmountPaid.Text = "Amount Paid €: ";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayAmount.Enabled = false;
            this.txtPayAmount.Location = new System.Drawing.Point(96, 143);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(40, 13);
            this.txtPayAmount.TabIndex = 8;
            // 
            // txtForename2
            // 
            this.txtForename2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForename2.Enabled = false;
            this.txtForename2.Location = new System.Drawing.Point(96, 82);
            this.txtForename2.Name = "txtForename2";
            this.txtForename2.Size = new System.Drawing.Size(86, 13);
            this.txtForename2.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(77, 176);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 20);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(598, 394);
            this.Controls.Add(this.grpReceipt);
            this.Controls.Add(this.grpFineDetails);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpMemberId);
            this.Controls.Add(this.mnuAddMem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayFine";
            this.Text = "Pay Fine";
            this.Load += new System.EventHandler(this.frmPayFine_Load);
            this.mnuAddMem.ResumeLayout(false);
            this.mnuAddMem.PerformLayout();
            this.grpMemberId.ResumeLayout(false);
            this.grpMemberId.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpPaymentType.ResumeLayout(false);
            this.grpPaymentType.PerformLayout();
            this.grpFineDetails.ResumeLayout(false);
            this.grpFineDetails.PerformLayout();
            this.grpReceipt.ResumeLayout(false);
            this.grpReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddMem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpMemberId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtAmount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radFull;
        private System.Windows.Forms.RadioButton radPartial;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox grpFineDetails;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.GroupBox grpPaymentType;
        private System.Windows.Forms.GroupBox grpReceipt;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.TextBox txtForename2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMemId2;
        private System.Windows.Forms.TextBox txtMemId2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
    }
}