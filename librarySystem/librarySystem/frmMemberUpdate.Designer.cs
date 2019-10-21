namespace librarySystem
{
    partial class frmMemberUpdate
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
            this.mnuUpdateMember = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpMemberId = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mnuUpdateMember.SuspendLayout();
            this.grpMemberId.SuspendLayout();
            this.grpBookDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.BackColor = System.Drawing.SystemColors.Control;
            this.mnuUpdateMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUpdateMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuUpdateMember.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(394, 24);
            this.mnuUpdateMember.TabIndex = 0;
            this.mnuUpdateMember.Text = "menuStrip1";
            this.mnuUpdateMember.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuUpdateMember_ItemClicked);
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
            this.grpMemberId.Location = new System.Drawing.Point(92, 35);
            this.grpMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Name = "grpMemberId";
            this.grpMemberId.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberId.Size = new System.Drawing.Size(200, 63);
            this.grpMemberId.TabIndex = 13;
            this.grpMemberId.TabStop = false;
            this.grpMemberId.Text = "Enter Member Id";
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
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(17, 27);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemId.MaxLength = 5;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(81, 20);
            this.txtMemId.TabIndex = 1;
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpBookDetails.Controls.Add(this.dtpDOB);
            this.grpBookDetails.Controls.Add(this.label1);
            this.grpBookDetails.Controls.Add(this.txtStreet);
            this.grpBookDetails.Controls.Add(this.txtTown);
            this.grpBookDetails.Controls.Add(this.txtCounty);
            this.grpBookDetails.Controls.Add(this.lblCounty);
            this.grpBookDetails.Controls.Add(this.lblStreet);
            this.grpBookDetails.Controls.Add(this.lblTown);
            this.grpBookDetails.Controls.Add(this.cboGender);
            this.grpBookDetails.Controls.Add(this.lblFine);
            this.grpBookDetails.Controls.Add(this.txtFine);
            this.grpBookDetails.Controls.Add(this.lblGender);
            this.grpBookDetails.Controls.Add(this.lblStatus);
            this.grpBookDetails.Controls.Add(this.txtStatus);
            this.grpBookDetails.Controls.Add(this.txtForename);
            this.grpBookDetails.Controls.Add(this.txtPhone);
            this.grpBookDetails.Controls.Add(this.txtSurname);
            this.grpBookDetails.Controls.Add(this.btnAdd);
            this.grpBookDetails.Controls.Add(this.label2);
            this.grpBookDetails.Controls.Add(this.label3);
            this.grpBookDetails.Controls.Add(this.label4);
            this.grpBookDetails.Controls.Add(this.btnUpdate);
            this.grpBookDetails.ForeColor = System.Drawing.Color.Black;
            this.grpBookDetails.Location = new System.Drawing.Point(14, 120);
            this.grpBookDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookDetails.Size = new System.Drawing.Size(362, 416);
            this.grpBookDetails.TabIndex = 14;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "Update Member Details";
            this.grpBookDetails.Visible = false;
            this.grpBookDetails.Enter += new System.EventHandler(this.grpBookDetails_Enter);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(141, 205);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(171, 20);
            this.dtpDOB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "DOB:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(141, 103);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(135, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(140, 171);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(135, 20);
            this.txtTown.TabIndex = 5;
            // 
            // txtCounty
            // 
            this.txtCounty.AccessibleDescription = "";
            this.txtCounty.Location = new System.Drawing.Point(141, 139);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.MaxLength = 15;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(135, 20);
            this.txtCounty.TabIndex = 4;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(70, 174);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 54;
            this.lblCounty.Text = "County:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(75, 106);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 53;
            this.lblStreet.Text = "Street:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(78, 141);
            this.lblTown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 52;
            this.lblTown.Text = "Town:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(141, 236);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(108, 21);
            this.cboGender.TabIndex = 7;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(83, 335);
            this.lblFine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(30, 13);
            this.lblFine.TabIndex = 50;
            this.lblFine.Text = "Fine:";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(141, 332);
            this.txtFine.Margin = new System.Windows.Forms.Padding(2);
            this.txtFine.MaxLength = 15;
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(60, 20);
            this.txtFine.TabIndex = 10;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(68, 239);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "Gender:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(74, 304);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(141, 301);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.MaxLength = 15;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(60, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(141, 70);
            this.txtForename.Margin = new System.Windows.Forms.Padding(2);
            this.txtForename.MaxLength = 15;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(135, 20);
            this.txtForename.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(140, 269);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(141, 38);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.MaxLength = 15;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(135, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(478, 417);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Forename:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 369);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // frmMemberUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(394, 549);
            this.Controls.Add(this.grpBookDetails);
            this.Controls.Add(this.grpMemberId);
            this.Controls.Add(this.mnuUpdateMember);
            this.MainMenuStrip = this.mnuUpdateMember;
            this.Name = "frmMemberUpdate";
            this.Text = "Update Member";
            this.Load += new System.EventHandler(this.frmMemberUpdate_Load);
            this.mnuUpdateMember.ResumeLayout(false);
            this.mnuUpdateMember.PerformLayout();
            this.grpMemberId.ResumeLayout(false);
            this.grpMemberId.PerformLayout();
            this.grpBookDetails.ResumeLayout(false);
            this.grpBookDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpMemberId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label1;
    }
}