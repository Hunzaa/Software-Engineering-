namespace librarySystem
{
    partial class frmMemberView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuViewMember = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpEnterSurname = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdAllMembers = new System.Windows.Forms.DataGridView();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.grpBySurname = new System.Windows.Forms.GroupBox();
            this.grdMemberBySurname = new System.Windows.Forms.DataGridView();
            this.mnuViewMember.SuspendLayout();
            this.grpEnterSurname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllMembers)).BeginInit();
            this.grpAll.SuspendLayout();
            this.grpBySurname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberBySurname)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuViewMember
            // 
            this.mnuViewMember.BackColor = System.Drawing.SystemColors.Control;
            this.mnuViewMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuViewMember.Location = new System.Drawing.Point(0, 0);
            this.mnuViewMember.Name = "mnuViewMember";
            this.mnuViewMember.Size = new System.Drawing.Size(1208, 24);
            this.mnuViewMember.TabIndex = 0;
            this.mnuViewMember.Text = "menuStrip1";
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
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpEnterSurname
            // 
            this.grpEnterSurname.BackColor = System.Drawing.SystemColors.Control;
            this.grpEnterSurname.Controls.Add(this.txtSurname);
            this.grpEnterSurname.Controls.Add(this.btnSearch);
            this.grpEnterSurname.ForeColor = System.Drawing.Color.Black;
            this.grpEnterSurname.Location = new System.Drawing.Point(420, 38);
            this.grpEnterSurname.Margin = new System.Windows.Forms.Padding(2);
            this.grpEnterSurname.Name = "grpEnterSurname";
            this.grpEnterSurname.Padding = new System.Windows.Forms.Padding(2);
            this.grpEnterSurname.Size = new System.Drawing.Size(351, 68);
            this.grpEnterSurname.TabIndex = 17;
            this.grpEnterSurname.TabStop = false;
            this.grpEnterSurname.Text = "Search By Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(54, 28);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(135, 20);
            this.txtSurname.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(209, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // grdAllMembers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAllMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAllMembers.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAllMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAllMembers.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdAllMembers.Location = new System.Drawing.Point(6, 19);
            this.grdAllMembers.Name = "grdAllMembers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAllMembers.Size = new System.Drawing.Size(1164, 149);
            this.grdAllMembers.TabIndex = 18;
            // 
            // grpAll
            // 
            this.grpAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpAll.Controls.Add(this.grdAllMembers);
            this.grpAll.Location = new System.Drawing.Point(15, 126);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(1176, 182);
            this.grpAll.TabIndex = 21;
            this.grpAll.TabStop = false;
            this.grpAll.Text = "All Members";
            // 
            // grpBySurname
            // 
            this.grpBySurname.Controls.Add(this.grdMemberBySurname);
            this.grpBySurname.Location = new System.Drawing.Point(15, 333);
            this.grpBySurname.Name = "grpBySurname";
            this.grpBySurname.Size = new System.Drawing.Size(1176, 105);
            this.grpBySurname.TabIndex = 22;
            this.grpBySurname.TabStop = false;
            this.grpBySurname.Text = "Members by Surname";
            // 
            // grdMemberBySurname
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grdMemberBySurname.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdMemberBySurname.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMemberBySurname.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMemberBySurname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMemberBySurname.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdMemberBySurname.Location = new System.Drawing.Point(6, 19);
            this.grdMemberBySurname.Name = "grdMemberBySurname";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMemberBySurname.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdMemberBySurname.Size = new System.Drawing.Size(1164, 71);
            this.grdMemberBySurname.TabIndex = 18;
            // 
            // frmMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1208, 451);
            this.Controls.Add(this.grpBySurname);
            this.Controls.Add(this.grpAll);
            this.Controls.Add(this.grpEnterSurname);
            this.Controls.Add(this.mnuViewMember);
            this.MainMenuStrip = this.mnuViewMember;
            this.Name = "frmMemberView";
            this.Text = "View Member";
            this.Load += new System.EventHandler(this.frmMemberView_Load);
            this.mnuViewMember.ResumeLayout(false);
            this.mnuViewMember.PerformLayout();
            this.grpEnterSurname.ResumeLayout(false);
            this.grpEnterSurname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllMembers)).EndInit();
            this.grpAll.ResumeLayout(false);
            this.grpBySurname.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberBySurname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewMember;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpEnterSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdAllMembers;
        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.GroupBox grpBySurname;
        private System.Windows.Forms.DataGridView grdMemberBySurname;
    }
}