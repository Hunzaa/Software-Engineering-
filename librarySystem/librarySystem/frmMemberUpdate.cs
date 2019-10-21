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
        public partial class frmMemberUpdate : Form
    {
            frmMainMenu parent;

            public frmMemberUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmMemberUpdate_Load(object sender, EventArgs e)
        {

        }

        private void mnuUpdateMember_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtStreet.Text.Equals("") || txtCounty.Text.Equals("") || txtPhone.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }


            /*if (!validPhone(txtPhone.Text))
            {

                MessageBox.Show("Bad Phone number!");
                txtPhone.Focus();
                return;
            }*/

            //display confirmation message

            MessageBox.Show("Member: " + txtSurname.Text.ToUpper() + " Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSurname.Clear();
            txtForename.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtPhone.Clear();

            txtSurname.Focus();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

         public bool validPhone(String phone)
        {
            Regex pattern = new Regex("^{15}[0-9]$");

            if (pattern.IsMatch(phone)) { return true; } else { return false; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtMemId.Text.Equals(""))
            {
                MessageBox.Show("Enter Member Id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Focus();
                return;
            }

            Member aMember = new Member();
            aMember.getMember(Convert.ToInt32(txtMemId.Text));

            dtpDOB.MaxDate = DateTime.Today.AddYears(-18);

            // load member details onto form
            txtForename.Text = aMember.getForename();
            txtSurname.Text = aMember.getSurname();
            txtStreet.Text = aMember.getStreet();
            txtTown.Text = aMember.getTown();
            txtCounty.Text = aMember.getCounty();
            dtpDOB.Value = Convert.ToDateTime(aMember.getDob());
            txtPhone.Text = aMember.getPhone();
            txtStatus.Text = aMember.getStatus();
            txtFine.Text = Convert.ToString(aMember.getFine());

            //load genders into combo box
            //get all genders
            DataSet ds = new DataSet();
            ds = Gender.getAllGenders(ds);

            //load genders into combo box
            int cboGenderIndex = 0;
            for (int i = 0; i < ds.Tables["gnd"].Rows.Count; i++)
            {
                cboGender.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
                if (ds.Tables[0].Rows[i][0].ToString().Equals(aMember.getGender()))
                    cboGenderIndex = i;
            }
            cboGender.SelectedIndex = cboGenderIndex;



            grpBookDetails.Visible = true;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            if (txtCounty.Text.Equals(""))
            {
                MessageBox.Show("County must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("Street must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            if (txtTown.Text.Equals(""))
            {
                MessageBox.Show("Town must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }


            if (cboGender.Text.Equals(""))
            {
                MessageBox.Show("Category must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGender.Focus();
                return;

            }

            if (!ValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Bad Phone number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear();
                txtPhone.Focus();
                return;
            }

            //Update MEmber
            Member updateMember = new Member(Convert.ToInt32(txtMemId.Text), txtSurname.Text, txtForename.Text, txtStreet.Text, txtTown.Text, txtCounty.Text, Convert.ToDateTime(dtpDOB.Value),
                                                      cboGender.Text.Substring(0,1), txtPhone.Text, txtStatus.Text, Convert.ToDecimal(txtFine.Text));
            updateMember.updMember();
            //updateMember.updMember(Convert.ToInt32(txtMemId.Text));

            //display confirmation message
            MessageBox.Show("Member: " + txtSurname.Text + " Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpBookDetails.Visible = false;
            txtMemId.Clear();

            cboGender.SelectedIndex = -1;
        }

        public bool ValidPhone(String phone)
        {
            Regex pattern = new Regex("^[0][0-9]{10,15}$");

            if (pattern.IsMatch(phone))
            { return true; }
            else { return false; }
        }

        private void grpBookDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
