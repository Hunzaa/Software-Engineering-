using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace librarySystem
{
    public partial class frmBookUpdate : Form
    {
        frmMainMenu parent;

        public frmBookUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
                this.Close();
                parent.Visible = true;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            if (cboCategory.Text.Equals(""))
            {
                MessageBox.Show("Category must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCategory.Focus();
                return;

            }

            if (!validIsbn(txtIsbn.Text))
            {
                MessageBox.Show("Bad Isbn!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIsbn.Focus();
                return;
            }

            Book newBook = new Book(Convert.ToInt32(txtBookId.Text), txtIsbn.Text.ToString(), txtTitle.Text.ToString(), txtAuthor.Text, cboCategory.Text.Substring(0, 3), txtStatus.Text);
            newBook.updBook();

            MessageBox.Show("Book: " + txtTitle.Text.ToUpper() + " updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtStatus.Clear();
            grpBookDetails.Visible = false;

            cboCategory.SelectedIndex = -1;

        }//btnUpdate_Click end


        public bool validIsbn(String isbn)
        {
            Regex pattern = new Regex("^[A-Z][A-Z0-9]{3,16}[A-Z]$");

            if (pattern.IsMatch(isbn))
            { return true; }
            else { return false; }
        }
        private void grpBookDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtBookId.Text.Equals(""))
            {
                MessageBox.Show("Enter Book Id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookId.Focus();
                return;
            }

            Book myBook = new Book();
            myBook.getBook(Convert.ToInt32(txtBookId.Text));

            // load book details onto form
            txtIsbn.Text = myBook.getIsbn();
            txtTitle.Text = myBook.getTitle();
            txtAuthor.Text = myBook.getAuthor();
            txtStatus.Text = myBook.getStatus();

            //load categories into combo box
            //get all categories
            DataSet ds = new DataSet();
            ds = Category.getAllCategories(ds);

            //load categories into combo box
            int cboCategoryIndex = 0;
            for (int i = 0; i < ds.Tables["ctg"].Rows.Count; i++)
            {
                cboCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
                if (ds.Tables[0].Rows[i][0].ToString().Equals(myBook.getCategory()))
                    cboCategoryIndex = i;
            }
            cboCategory.SelectedIndex = cboCategoryIndex;

         
            grpBookDetails.Visible = true;


        }

        private void frmBookUpdate_Load(object sender, EventArgs e)
        {

        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {

        }

    }
}