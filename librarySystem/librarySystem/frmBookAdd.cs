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
    public partial class frmBookAdd : Form
    {
        frmMainMenu parent;

        public frmBookAdd()
        {
            InitializeComponent();
        }

        public frmBookAdd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        //1. get categoris, load them into combo box / assign nextBookId
        private void frmBookAdd_Load(object sender, EventArgs e)
        {
            //get all categories
            DataSet ds = new DataSet();
            ds = Category.getAllCategories(ds);

            //load categories into combo box
            for (int i = 0; i < ds.Tables["ctg"].Rows.Count; i++)
                cboCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());

            //assign BookId
            txtBookId.Text = Book.nextBookId().ToString("00000");
        }
     

        //2. add button 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtTitle.Text.Equals("")) //title
            {
                MessageBox.Show("Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            if (txtIsbn.Text.Equals("")) //isbn
            {
                MessageBox.Show("ISBN must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIsbn.Focus();
                return;
            }

            if (cboCategory.Text.Equals("")) //category
            {
                MessageBox.Show("Choose a Category", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCategory.Focus();
                return;

            }


            //add data to Book table
            if (!validIsbn(txtIsbn.Text))
            {
                MessageBox.Show("Bad Isbn!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIsbn.Focus();
                return;
            }

            Book newBook = new Book(Convert.ToInt32(txtBookId.Text),txtIsbn.Text,txtTitle.Text,txtAuthor.Text,cboCategory.Text.Substring(0,3), "A");
            newBook.regBook();


            //display confirmation message
            MessageBox.Show("Book: " + txtTitle.Text.ToUpper() + " Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            //assign BookId
            txtBookId.Text = Book.nextBookId().ToString("00000");

            //reset UI
            txtIsbn.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
           
            txtIsbn.Focus();

        }//btnAdd_Click end

        //Clear button
        private void button1_Click(object sender, EventArgs e)
        {
            txtIsbn.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();

            txtIsbn.Focus();

        }

        public bool validIsbn(String isbn)
        {
            Regex pattern = new Regex("^[A-Z][A-Z0-9]{3,16}[A-Z]$");

            if (pattern.IsMatch(isbn)) 
                { return true; }
            else { return false; }
        }

        private void grpBook_Enter(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBookId_Click(object sender, EventArgs e)
        {

        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        


    }
    }