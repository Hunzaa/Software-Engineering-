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
 

    public partial class frmReturnBook : Form
    {
        frmMainMenu parent;

        public frmReturnBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void grpMember_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirmReturn_Click_1(object sender, EventArgs e)
        {
            dtpReturnDate.Value = DateTime.Today;

            if(dtpReturnDate.Value > dtpDueDate.Value)
            {
                DateTime d2 = dtpReturnDate.Value.Date;
                DateTime d1 = dtpDueDate.Value.Date;

                double daysDiff = ((TimeSpan)(d2 - d1)).Days;

                double fine = daysDiff * 0.50;
                txtFine.Text = Convert.ToString(fine);

                grpFineDetails.Visible = true;

                //updating fine in members file
                Member.returnFine(Convert.ToInt32(txtMemId.Text), Convert.ToDecimal(txtFine.Text));

                //upadting book status to Availaible 
                //Book.newStatusA();

                MessageBox.Show("Book overdue " + daysDiff + " days. \nFine of  € " +fine + " added for the Member.", "Late!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Book.newStatus(Convert.ToInt32(txtB));





            //grpLoanDetails.Visible = false;
            //grpReturnDate.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMemId.Text.Equals(""))
            {
                MessageBox.Show("Enter Member Id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Focus();
                return;
            }

            Loan loan = new Loan();
            loan.getLoan(Convert.ToInt32(txtMemId.Text));

            // load loan Id
            txtLoanId.Text = Convert.ToString(loan.getLoanId());

            if (txtLoanId.Text.Equals("0"))
            {
                MessageBox.Show("No ongoing loan for the Member.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMemId.Clear();
                txtMemId.Focus();
                return;
            }

            // load bookId's from loanItems
            LoanItems items = new LoanItems();

            /*while (txtLoanId.Text.Equals(Convert.ToString(loan.getLoanId())))
            {
                lstLoanItems.Text = Convert.ToString(items.getBookId());
            }

            for (int i = ; i <= lstLoanItems.Items.Count - 1; i++)
            {
                lstLoanItems.SelectedIndex = i;
                lstLoanItems.Items.Add(items.getBookId().ToString);

                //loading books to lstLoanItems
                //lstLoanItems.Items.Add =  items.getBookId().ToString;
            }*/



            // load dueDate from loan
            dtpDueDate.Value = Convert.ToDateTime(loan.getDueDate());

            grpLoanDetails.Visible = true;
            grpReturnDate.Visible = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpReturnDate_Enter(object sender, EventArgs e)
        {

        }

        private void txtFine_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemId.Clear();
            txtMemId.Focus();

            txtLoanId.Clear();
            txtFine.Clear();

            grpFineDetails.Visible = false;
            grpLoanDetails.Visible = false;
            grpReturnDate.Visible = false;

        }

        private void txtFine_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}