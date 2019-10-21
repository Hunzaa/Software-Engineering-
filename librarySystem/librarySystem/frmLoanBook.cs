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
    public partial class frmLoanBook : Form
    {
        frmMainMenu parent;
        int noItems = 0;

        public frmLoanBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoanBook_Load(object sender, EventArgs e)
        {
            //assign LoanId
            txtLoanId.Text = Loan.nextLoanId().ToString("00000");

            //loan Date
            dtpLoanDate.Value = DateTime.Today;

            //due Date
            dtpDueDate.Value = DateTime.Today.AddDays(+7);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpIsbn_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtMemId.Text.Equals(""))
            {
                MessageBox.Show("Enter Member Id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Focus();
                return;
            }

            Member member = new Member();
            member.getMember(Convert.ToInt32(txtMemId.Text));


            // load member details onto form
            txtSurname.Text = member.getSurname();
            txtForename.Text = member.getForename();
            txtAddress.Text = member.getStreet() + ", " + member.getTown() + ", " + member.getCounty();

            if (txtMemId.Text.Equals(""))
            {
                MessageBox.Show("Enter Member Id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Focus();
                return;

                
            }

            grpMemberDetails.Visible = true;
            grpBookId.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBookId.Text.Equals(""))
            {
                MessageBox.Show("Enter Book Id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookId.Focus();
                return;
            }

            Book myBook = new Book();
            myBook.getBook(Convert.ToInt32(txtBookId.Text));


            /*if (txtBookId.Text == lstCart.Text.Substring(0, 5))
            {
                MessageBox.Show("The book is already in cart.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookId.Focus();
                return;
            }*/

            //if then in UNAVAILAIBLE 
            if (myBook.getStatus().Equals("U"))
            {
                MessageBox.Show("The book is not availaible." , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookId.Focus();
                return;
            }


            // load member details onto form 'Book Details'
            txtAuthor.Text = myBook.getAuthor();
            txtTitle.Text = myBook.getTitle();

            // load book details onto form 'Add Book'
            txtBookId2.Text = myBook.getBookId().ToString("00000") + "   ";
            txtTitle2.Text = myBook.getTitle();

            grpBookDetails.Visible = true;
            grpBook.Visible = true;
            
        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            if (noItems == 3)
            {
                MessageBox.Show("Already 3 items in cart - Max allowed 3.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
     
                return;
            }

            noItems++;
            
            lstCart.Items.Add(txtBookId2.Text.ToString() + txtTitle2.Text.ToString() );
            txtBookId.Clear();
            txtAuthor.Clear();
            grpBookDetails.Visible = false;
            txtBookId2.Clear();
            txtTitle2.Clear();
            txtTitle.Clear();
            txtBookId.Focus();

        }

        //save details to database tables
        private void btnFinish_Click(object sender, EventArgs e)
        {      
            //add data to Loan table
            Loan newLoan = new Loan(Convert.ToInt32(txtLoanId.Text), Convert.ToInt32(txtMemId.Text), dtpLoanDate.Value, dtpDueDate.Value);
            newLoan.addLoan();

            //for each book in the book cart
            LoanItems booksRented = new LoanItems();

            for(int i=0; i<=lstCart.Items.Count-1; i++)
            {
                lstCart.SelectedIndex = i;
                //adding books to loanItems file
                booksRented.setBookId(Convert.ToInt32(lstCart.Text.Substring(0, 5)));
                booksRented.setLoanId(Convert.ToInt32(txtLoanId.Text));
                booksRented.addLoanItem();


                //updating the book status to U 
                //String statusU = "U";
                Book.newStatus(Convert.ToInt32(lstCart.Text.Substring(0, 5)));

            }
            

            //display confirmation message
            MessageBox.Show("Loan: " + txtLoanId.Text + " Successfull.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //assign loanId
            txtLoanId.Text = Loan.nextLoanId().ToString("00000");

            //reset UI
            txtMemId.Clear();
            grpMemberDetails.Visible = false;

            txtBookId.Clear();
            grpBookDetails.Visible = false;

            txtBookId2.Clear();
            txtTitle2.Clear();
            grpBookId.Visible = false;

            lstCart.Items.Clear();
            grpBook.Visible = false;
            txtMemId.Focus();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lstCart.Items.Remove(lstCart.SelectedItem);
            noItems--;
        }

        private void txtMemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpLoanId_Enter(object sender, EventArgs e)
        {

        }

        private void grpBookDetails_Enter(object sender, EventArgs e)
        {

        }

        private void txtLoanId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpMemberDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
