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
    public partial class frmBookDelete : Form
    {
        frmMainMenu parent;

        public frmBookDelete(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmBookDelete_Load(object sender, EventArgs e)
        {
            this.grdBooksByAuthor.DefaultCellStyle.ForeColor = Color.Black;
           
        }

        private void mnuDelBook_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtAuthor.Text.Equals(""))
            {
                MessageBox.Show("Enter Author.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }

            //create instance of dataset
            grpByAuthor.Visible = true;
            DataSet ds = new DataSet();

            //loading books for the author in dataGrid2
            grdBooksByAuthor.DataSource = Book.getBookByAuthor(ds, txtAuthor.Text).Tables["bkAut"];

            //reset UI
            txtAuthor.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //error message if the book is already deleted 
            if (grdBooksByAuthor.CurrentRow.Cells["Status"].Value.Equals("R"))
            {
                MessageBox.Show("The book is already deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                grdBooksByAuthor.Rows.Clear();
                return;
            }
             
            //deleting the book otherwise (ie. status to 'R' removed)
            for (int i = 0; i < grdBooksByAuthor.SelectedRows.Count; i++)
            {
                DialogResult result;
              
                result = MessageBox.Show("Are you sure want to delete this book?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Book.delBook(Convert.ToInt32(grdBooksByAuthor.CurrentRow.Cells["BookId"].Value));
                    MessageBox.Show("Book deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            txtAuthor.Focus();

            //clear the grid - not working
            grdBooksByAuthor.DataSource = null;
            grdBooksByAuthor.Rows.Clear();

            //hide the group box - not working
            grpByAuthor.Visible = false;


        }

        

        private void grdBooksByAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
 }

