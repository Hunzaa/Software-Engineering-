namespace librarySystem
{
    partial class frmBookDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuDelBook = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpByAuthor = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.grdBooksByAuthor = new System.Windows.Forms.DataGridView();
            this.grpEnterAuthor = new System.Windows.Forms.GroupBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuDelBook.SuspendLayout();
            this.grpByAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooksByAuthor)).BeginInit();
            this.grpEnterAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDelBook
            // 
            this.mnuDelBook.BackColor = System.Drawing.SystemColors.Control;
            this.mnuDelBook.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuDelBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuDelBook.Location = new System.Drawing.Point(0, 0);
            this.mnuDelBook.Name = "mnuDelBook";
            this.mnuDelBook.Size = new System.Drawing.Size(709, 24);
            this.mnuDelBook.TabIndex = 2;
            this.mnuDelBook.Text = "menuStrip1";
            this.mnuDelBook.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuDelBook_ItemClicked);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            // 
            // grpByAuthor
            // 
            this.grpByAuthor.Controls.Add(this.btnDel);
            this.grpByAuthor.Controls.Add(this.grdBooksByAuthor);
            this.grpByAuthor.Location = new System.Drawing.Point(12, 127);
            this.grpByAuthor.Name = "grpByAuthor";
            this.grpByAuthor.Size = new System.Drawing.Size(679, 172);
            this.grpByAuthor.TabIndex = 25;
            this.grpByAuthor.TabStop = false;
            this.grpByAuthor.Text = "Books by Author";
            this.grpByAuthor.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(297, 144);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(54, 20);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // grdBooksByAuthor
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBooksByAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdBooksByAuthor.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooksByAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdBooksByAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBooksByAuthor.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdBooksByAuthor.Location = new System.Drawing.Point(6, 19);
            this.grdBooksByAuthor.Name = "grdBooksByAuthor";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooksByAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdBooksByAuthor.Size = new System.Drawing.Size(667, 119);
            this.grdBooksByAuthor.TabIndex = 18;
            this.grdBooksByAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooksByAuthor_CellContentClick);
            // 
            // grpEnterAuthor
            // 
            this.grpEnterAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.grpEnterAuthor.Controls.Add(this.txtAuthor);
            this.grpEnterAuthor.Controls.Add(this.btnSearch);
            this.grpEnterAuthor.ForeColor = System.Drawing.Color.Black;
            this.grpEnterAuthor.Location = new System.Drawing.Point(174, 42);
            this.grpEnterAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.grpEnterAuthor.Name = "grpEnterAuthor";
            this.grpEnterAuthor.Padding = new System.Windows.Forms.Padding(2);
            this.grpEnterAuthor.Size = new System.Drawing.Size(351, 68);
            this.grpEnterAuthor.TabIndex = 19;
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
            // frmBookDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 319);
            this.Controls.Add(this.grpEnterAuthor);
            this.Controls.Add(this.grpByAuthor);
            this.Controls.Add(this.mnuDelBook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBookDelete";
            this.Text = "Delete Book";
            this.Load += new System.EventHandler(this.frmBookDelete_Load);
            this.mnuDelBook.ResumeLayout(false);
            this.mnuDelBook.PerformLayout();
            this.grpByAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooksByAuthor)).EndInit();
            this.grpEnterAuthor.ResumeLayout(false);
            this.grpEnterAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDelBook;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpByAuthor;
        private System.Windows.Forms.DataGridView grdBooksByAuthor;
        private System.Windows.Forms.GroupBox grpEnterAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
    }
}