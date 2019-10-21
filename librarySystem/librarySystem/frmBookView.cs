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
    public partial class frmBookView : Form
    {
        frmMainMenu parent;

        public frmBookView()
        {
            InitializeComponent();
        }
        public frmBookView(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void mnuAddMem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmBookView_Load(object sender, EventArgs e)
        {
            this.grdAllBooks.DefaultCellStyle.ForeColor = Color.Black;
            this.grdBooksByAuthor.DefaultCellStyle.ForeColor = Color.Black;

            // create instance of data set
            DataSet ds = new DataSet();

            //loading all the books in datagrid1
            grdAllBooks.DataSource = Book.getAllBook(ds).Tables["bk"];

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text.Equals(""))
            {
                MessageBox.Show("Enter Author.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }
           
            //create instance of dataset
            DataSet ds = new DataSet();

            //loading books for the author in dataGrid2
            grdBooksByAuthor.DataSource = Book.getBookByAuthor(ds, txtAuthor.Text).Tables["bkAut"];


            //reset UI
            txtAuthor.Clear();
        }

        //grdBooksByAuthor
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //grdAllTheBooks
        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
