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
    public partial class frmPayFine : Form
    {
        frmMainMenu parent;
        public frmPayFine(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmPayFine_Load(object sender, EventArgs e)
        {
            //assign paymentId
            txtPaymentId.Text = FinePayments.nextPayId().ToString("00000");

            //get all categories
            DataSet ds = new DataSet();
            ds = Gender.getAllGenders(ds);

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radPartial_CheckedChanged(object sender, EventArgs e)
        {
            lblAmount.Visible = true;
            txtAmount.Visible = true;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtMemId.Text.Equals(""))
            {
                MessageBox.Show("Enter Member Id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Focus();
                return;
            }

            Member member = new Member();
            member.getMember(Convert.ToInt32(txtMemId.Text));

            // load member details
            txtSurname.Text = member.getSurname();
            txtForename.Text = member.getForename();
            txtFine.Text = Convert.ToString(member.getFine());

            txtForename2.Text = member.getForename() + " " + member.getSurname();
            grpFineDetails.Visible = true;

            if (member.getFine() == 0)
            {
                MessageBox.Show("No Fine to pay.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Clear();
                grpFineDetails.Visible = false;
                txtMemId.Focus();
                return;
            }

            else 
                grpPayment.Visible = true;
           
        }

        private void grpPaymentDetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void radFull_CheckedChanged(object sender, EventArgs e)
        {
            lblAmount.Visible = false;
            txtAmount.Visible = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal amount = 0;

            if (radPartial.Checked == true)
            {
                amount = Convert.ToInt32(txtFine.Text) - Convert.ToDecimal(txtAmount.Text);
            }

            if (radFull.Checked == true)
            {
                amount = Convert.ToInt32(txtFine.Text) - Convert.ToInt32(txtFine.Text);
            }


            grpReceipt.Visible = true;
            Member.payFine(Convert.ToInt32(txtMemId.Text), amount);


            //adding payment detail to FinePayments 
            txtMemId2.Text = txtMemId.Text;
            txtPayAmount.Text = txtAmount.Text;
            int payid = Convert.ToInt32(txtPaymentId.Text);
            int memid = Convert.ToInt32(txtMemId2.Text);
            DateTime paydate = dtpPayDate.Value;
            decimal payamount = Convert.ToDecimal(txtPayAmount.Text);


            FinePayments newPayment = new FinePayments(payid, memid, paydate, payamount);
            newPayment.addFinePayment();

            MessageBox.Show("Fine paid succesfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMemId.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMemId.Clear();
            grpFineDetails.Visible = false;
            grpPayment.Visible = false;
            grpReceipt.Visible = false;
            txtMemId.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtMemId.Clear();
            grpFineDetails.Visible = false;
            grpPayment.Visible = false;
            grpReceipt.Visible = false;
            txtMemId.Focus();

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
    }
} 