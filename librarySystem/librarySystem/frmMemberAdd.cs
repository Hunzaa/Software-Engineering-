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
    public partial class frmMemberAdd : Form
    {
        frmMainMenu parent;

        public frmMemberAdd()
        {
            InitializeComponent();
        }

        public frmMemberAdd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //Back Menu
        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;

        }

        
        //Frame
        private void frmMemberAdd_Load(object sender, EventArgs e)
        {
            //assign memberId
            txtMemberId.Text = Member.nextMemberId().ToString("00000");

            //get all categories
            DataSet ds = new DataSet();
            ds = Gender.getAllGenders(ds);

            //load categories into combo box
            for (int i = 0; i < ds.Tables["gnd"].Rows.Count; i++)
                cboGender.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());

        }

        
        //Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtPhone.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            
            //validate Dob
            dtpDob.MaxDate = DateTime.Today.AddYears(-18);

            int memid = Convert.ToInt32(txtMemberId.Text);
            String sname = txtSurname.Text.ToString();
            String fname = txtForename.Text.ToString();
            String street = txtStreet.Text.ToString();
            String town = txtTown.Text.ToString();
            String county = txtCounty.Text.ToString();
            DateTime dob = dtpDob.Value;
            String gender = cboGender.Text.Substring(0, 1);
            String phone = txtPhone.Text.ToString();
            if (!validPhone(txtPhone.Text))
            {
                MessageBox.Show("Bad Phone number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear();
                txtPhone.Focus();
                return;
            }
            String status = "A";
            decimal fine = 0 ;


            Member newMember = new Member(memid, sname, fname, street, town, county, dob, gender, phone, status, fine);
            newMember.regMember();

            //assign memberId
            txtMemberId.Text = Member.nextMemberId().ToString("00000");

            //display confirmation message
            MessageBox.Show("Member: " + txtSurname.Text.ToUpper() + " Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                txtSurname.Clear();
                txtForename.Clear();
                txtStreet.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                dtpDob.Value = DateTime.Today.AddYears(-18); 
                txtPhone.Clear();

                txtSurname.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSurname.Clear();
            txtForename.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            dtpDob.Value = DateTime.Today.AddYears(-18);
            txtPhone.Clear();

            txtSurname.Focus();

        }

        public bool validPhone(String phone)
        {
            Regex pattern = new Regex("^[0][0-9]{10,15}$");

            if (pattern.IsMatch(phone))
            { return true; }
            else { return false; }
        }


        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMemberId_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //Surname Label
        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        //Forename Label
        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        //Group Box
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Surname Text
        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
        //Forename Text
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //Phone Text
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
