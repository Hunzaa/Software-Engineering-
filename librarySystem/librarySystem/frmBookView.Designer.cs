namespace librarySystem
{
    partial class frmBookView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuAddMem = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpEnterAuthor = new System.Windows.Forms.GroupBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBySurname = new System.Windows.Forms.GroupBox();
            this.grdBooksByAuthor = new System.Windows.Forms.DataGridView();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.grdAllBooks = new System.Windows.Forms.DataGridView();
            this.mnuAddMem.SuspendLayout();
            this.grpEnterAuthor.SuspendLayout();
            this.grpBySurname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooksByAuthor)).BeginInit();
            this.grpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllBooks)).BeginInit();
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
            this.mnuAddMem.Size = new System.Drawing.Size(729, 24);
            this.mnuAddMem.TabIndex = 3;
            this.mnuAddMem.Text = "menuStrip1";
            this.mnuAddMem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAddMem_ItemClicked);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            // 
            // grpEnterAuthor
            // 
            this.grpEnterAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.grpEnterAuthor.Controls.Add(this.txtAuthor);
            this.grpEnterAuthor.Controls.Add(this.btnSearch);
            this.grpEnterAuthor.ForeColor = System.Drawing.Color.Black;
            this.grpEnterAuthor.Location = new System.Drawing.Point(189, 43);
            this.grpEnterAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.grpEnterAuthor.Name = "grpEnterAuthor";
            this.grpEnterAuthor.Padding = new System.Windows.Forms.Padding(2);
            this.grpEnterAuthor.Size = new System.Drawing.Size(351, 68);
            this.grpEnterAuthor.TabIndex = 12;
            this.grpEnterAuthor.TabStop = false;
            this.grpEnterAuthor.Text = "Enter Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(54, 28);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(135, 20);
            this.txtAuthor.TabIndex = 13;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpBySurname
            // 
            this.grpBySurname.Controls.Add(this.grdBooksByAuthor);
            this.grpBySurname.Location = new System.Drawing.Point(26, 332);
            this.grpBySurname.Name = "grpBySurname";
            this.grpBySurname.Size = new System.Drawing.Size(679, 105);
            this.grpBySurname.TabIndex = 24;
            this.grpBySurname.TabStop = false;
            this.grpBySurname.Text = "Books by Author";
            // 
            // grdBooksByAuthor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBooksByAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBooksByAuthor.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooksByAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBooksByAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBooksByAuthor.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdBooksByAuthor.Location = new System.Drawing.Point(6, 19);
            this.grdBooksByAuthor.Name = "grdBooksByAuthor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooksByAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdBooksByAuthor.Size = new System.Drawing.Size(667, 71);
            this.grdBooksByAuthor.TabIndex = 18;
            // 
            // grpAll
            // 
            this.grpAll.Controls.Add(this.grdAllBooks);
            this.grpAll.Location = new System.Drawing.Point(26, 134);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(679, 182);
            this.grpAll.TabIndex = 23;
            this.grpAll.TabStop = false;
            this.grpAll.Text = "All Books";
            // 
            // grdAllBooks
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAllBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdAllBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAllBooks.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdAllBooks.Location = new System.Drawing.Point(6, 19);
            this.grdAllBooks.Name = "grdAllBooks";
            this.grdAllBooks.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdAllBooks.Size = new System.Drawing.Size(667, 149);
            this.grdAllBooks.TabIndex = 18;
            // 
            // frmBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(729, 460);
            this.Controls.Add(this.grpBySurname);
            this.Controls.Add(this.grpAll);
            this.Controls.Add(this.grpEnterAuthor);
            this.Controls.Add(this.mnuAddMem);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBookView";
            this.Text = "View Books";
            this.Load += new System.EventHandler(this.frmBookView_Load);
            this.mnuAddMem.ResumeLayout(false);
            this.mnuAddMem.PerformLayout();
            this.grpEnterAuthor.ResumeLayout(false);
            this.grpEnterAuthor.PerformLayout();
            this.grpBySurname.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooksByAuthor)).EndInit();
            this.grpAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddMem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpEnterAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBySurname;
        private System.Windows.Forms.DataGridView grdBooksByAuthor;
        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.DataGridView grdAllBooks;
    }
}