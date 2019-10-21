namespace librarySystem
{
    partial class frmMemberAdd
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuAddMem.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
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
            this.mnuAddMem.Size = new System.Drawing.Size(404, 24);
            this.mnuAddMem.TabIndex = 1;
            this.mnuAddMem.Text = "menuStrip1";
            this.mnuAddMem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.bACKToolStripMenuItem_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(75, 85);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            this.lblSurname.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(94, 254);
            this.lblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(33, 13);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "DOB:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(70, 117);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 6;
            this.lblForename.Text = "Forename:";
            this.lblForename.Click += new System.EventHandler(this.lblForename_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(86, 319);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone:";
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpMemberDetails.Controls.Add(this.btnClear);
            this.grpMemberDetails.Controls.Add(this.txtStreet);
            this.grpMemberDetails.Controls.Add(this.txtTown);
            this.grpMemberDetails.Controls.Add(this.txtCounty);
            this.grpMemberDetails.Controls.Add(this.lblCounty);
            this.grpMemberDetails.Controls.Add(this.lblStreet);
            this.grpMemberDetails.Controls.Add(this.lblTown);
            this.grpMemberDetails.Controls.Add(this.cboGender);
            this.grpMemberDetails.Controls.Add(this.lblGender);
            this.grpMemberDetails.Controls.Add(this.lblMemberId);
            this.grpMemberDetails.Controls.Add(this.txtMemberId);
            this.grpMemberDetails.Controls.Add(this.dtpDob);
            this.grpMemberDetails.Controls.Add(this.txtForename);
            this.grpMemberDetails.Controls.Add(this.txtPhone);
            this.grpMemberDetails.Controls.Add(this.txtSurname);
            this.grpMemberDetails.Controls.Add(this.btnAdd);
            this.grpMemberDetails.Controls.Add(this.lblDob);
            this.grpMemberDetails.Controls.Add(this.lblPhone);
            this.grpMemberDetails.Controls.Add(this.lblSurname);
            this.grpMemberDetails.Controls.Add(this.lblForename);
            this.grpMemberDetails.ForeColor = System.Drawing.Color.Black;
            this.grpMemberDetails.Location = new System.Drawing.Point(11, 39);
            this.grpMemberDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberDetails.Size = new System.Drawing.Size(379, 404);
            this.grpMemberDetails.TabIndex = 7;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Enter Member Details";
            this.grpMemberDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(228, 364);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 23);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(155, 147);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.MaxLength = 15;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(135, 20);
            this.txtStreet.TabIndex = 2;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(155, 180);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTown.MaxLength = 15;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(135, 20);
            this.txtTown.TabIndex = 3;
            // 
            // txtCounty
            // 
            this.txtCounty.AccessibleDescription = "";
            this.txtCounty.Location = new System.Drawing.Point(155, 213);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.MaxLength = 15;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(135, 20);
            this.txtCounty.TabIndex = 4;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(84, 183);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 33;
            this.lblCounty.Text = "County:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(89, 150);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 32;
            this.lblStreet.Text = "Street:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(90, 216);
            this.lblTown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 31;
            this.lblTown.Text = "Town:";
            this.lblTown.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(157, 282);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(133, 21);
            this.cboGender.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(87, 285);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender:";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(67, 43);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(60, 13);
            this.lblMemberId.TabIndex = 20;
            this.lblMemberId.Text = "Member Id:";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Enabled = false;
            this.txtMemberId.Location = new System.Drawing.Point(155, 40);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(60, 20);
            this.txtMemberId.TabIndex = 17;
            this.txtMemberId.TextChanged += new System.EventHandler(this.txtMemberId_TextChanged);
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(155, 248);
            this.dtpDob.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(179, 20);
            this.dtpDob.TabIndex = 5;
            this.dtpDob.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(155, 114);
            this.txtForename.Margin = new System.Windows.Forms.Padding(2);
            this.txtForename.MaxLength = 15;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(135, 20);
            this.txtForename.TabIndex = 1;
            this.txtForename.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(155, 316);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 20);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(155, 82);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.MaxLength = 15;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(135, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 364);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMemberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(404, 456);
            this.Controls.Add(this.grpMemberDetails);
            this.Controls.Add(this.mnuAddMem);
            this.MainMenuStrip = this.mnuAddMem;
            this.Name = "frmMemberAdd";
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.frmMemberAdd_Load);
            this.mnuAddMem.ResumeLayout(false);
            this.mnuAddMem.PerformLayout();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuAddMem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Button btnClear;
    }
}