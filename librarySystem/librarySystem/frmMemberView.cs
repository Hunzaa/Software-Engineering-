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
    public partial class frmMemberView : Form
    {
        frmMainMenu parent;

        public frmMemberView(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;

        }

        private void frmMemberView_Load(object sender, EventArgs e)
        {
            this.grdAllMembers.DefaultCellStyle.ForeColor = Color.Black;
            this.grdMemberBySurname.DefaultCellStyle.ForeColor = Color.Black;

            // create instance of data set
            DataSet ds = new DataSet();

            //loading all the book in datagrid2
            grdAllMembers.DataSource = Member.getAllMember(ds).Tables["mmb"];

            grpBySurname.Visible = false;
        }
   

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            grpBySurname.Visible = true;

            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Enter Surname.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            //create instance of dataset
            DataSet ds = new DataSet();

            //loading books for the author in dataGrid2
            grdMemberBySurname.DataSource = Member.getMemberBySurname(ds, txtSurname.Text).Tables["mmbS"];

            //reset UI
            txtSurname.Clear();

        }
    }
}
