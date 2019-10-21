using Oracle.ManagedDataAccess.Client;
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
    public partial class frmCategoryAnalysis : Form
    {
        frmMainMenu parent;
        public frmCategoryAnalysis()
        {
            InitializeComponent();
        }

        public frmCategoryAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //Back Menu
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
  
        private void frmCategoryAnalysis_Load(object sender, EventArgs e)
        {
            String strSQL = "SELECT Cat_Code AS Category, COUNT(BookId) AS Book FROM Book GROUP BY Cat_Code ORDER BY Cat_Code";
            DataTable dt = new DataTable();

            OracleConnection myConn = new OracleConnection(DBConnect.oradb); OracleCommand cmd = new OracleCommand(strSQL, myConn); OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt); myConn.Close();

            //DataSet ds = new DataSet();
            //ds = Book.getAllBook(ds);

            string[] N = new string[dt.Rows.Count];
            int[] M = new int[dt.Rows.Count];

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                N[i] = dt.Rows[i][0].ToString();
               
                M[i] = Convert.ToInt32(dt.Rows[i][1]);
               
            }

            //order the arrays N and M 
            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Books per Category";
            chtData.Series[0].Points.DataBindXY(N, M);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX";             
            chtData.Series[0].Label = "#VALY"; 
            chtData.Titles.Add("Overall");
            chtData.Visible = true;
        }

       


    }
} 

       
