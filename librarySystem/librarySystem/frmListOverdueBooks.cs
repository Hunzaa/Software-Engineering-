using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarySystem
{
    public partial class frmListOverdueBooks : Form
    {
        frmMainMenu parent;
        public frmListOverdueBooks()
        {
            InitializeComponent();
        }

        public frmListOverdueBooks(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmListOverdueBooks_Load(object sender, EventArgs e)
        {
            this.grdOverdue.DefaultCellStyle.ForeColor = Color.Black;
            // create instance of data set
            DataSet ds = new DataSet();

            //loading all the books in datagrid1
            grdOverdue.DataSource = LoanItems.getDueLoanItems(ds).Tables["dueItm"];
        }

        //Back Menu
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure want to print?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {         
                MessageBox.Show("Now Printing", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void grdOverdue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
