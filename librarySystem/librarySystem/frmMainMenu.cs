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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        
        //1. Member Add
        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberAdd nextForm = new frmMemberAdd(this);
            nextForm.Show();
        }

        //2. Member Update
        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberUpdate nextForm = new frmMemberUpdate(this);
            nextForm.Show();
        }

        //3. Member View
        private void mnuViewMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberView nextForm = new frmMemberView(this);
            nextForm.Show();

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        //4. Book Add
        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookAdd nextForm = new frmBookAdd(this);
            nextForm.Show();
        }

        //5. Book Update
        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookUpdate nextForm = new frmBookUpdate(this);
            nextForm.Show();
        }
        
        //6. Book View
        private void mnuViewBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookView nextForm = new frmBookView(this);
            nextForm.Show();
        }

        //7. Book Delete
        private void mnuDeleteBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookDelete nextForm = new frmBookDelete(this);
            nextForm.Show();
        }

        //8. Loan Book
        private void mnuLoanBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoanBook nextForm = new frmLoanBook(this);
            nextForm.Show();
        }

        //9. Return Book
        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnBook nextForm = new frmReturnBook(this);
            nextForm.Show();
        }

        //10. Pay Fine
        private void mnuPayFine_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayFine nextForm = new frmPayFine(this);
            nextForm.Show();
        }

        //11. List Overdue Books
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListOverdueBooks nextForm = new frmListOverdueBooks(this);
            nextForm.Show();
        }

        //12. Perform Book Category Analysis
        private void mnuPerformBookCA_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategoryAnalysis nextForm = new frmCategoryAnalysis(this);
            nextForm.Show();
        }

        //13. Exit
        private void mnuExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
