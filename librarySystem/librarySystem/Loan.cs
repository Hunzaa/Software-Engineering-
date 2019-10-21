using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace librarySystem
{
    class Loan
    {
        //1 instance variables

        private int loanId;
        private int memId;
        private DateTime loanDate;
        private DateTime dueDate;

        //2 no argument constructor
        public Loan()
        {

            loanId = 0;
            memId = 0;
            loanDate = DateTime.Now;
            dueDate = DateTime.Now; 

        }

        public Loan(int LoanId, int MemId, DateTime LoanDate, DateTime DueDate)
        {

            loanId = LoanId;
            memId = MemId;
            loanDate = LoanDate;
            dueDate = DueDate;

        }

        //3 Define setters
        public void setLoanId(int LoanId) { this.loanId = LoanId; }
        public void setMemId(int MemId) { this.memId = MemId; }
        public void setLoanDate(DateTime LoanDate) { this.loanDate = LoanDate; }
        public void setDueDate(DateTime DueDate) { this.dueDate = DueDate; }

        //4 Define getters
        public int getLoanId() { return loanId; }
        public int getMemId() { return memId; }
        public DateTime getLoanDate() { return loanDate; }
        public DateTime getDueDate() { return dueDate; }

        //5 define a static method to get all data from Loan table
        public static DataSet getAllLoans(DataSet DS)
        {
            //5.1 create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //5.2 Define the SQL Query to retrieve the data
            String strSQL = "SELECT LoanId, MemId, LoanDate, DueDate FROM Loans ORDER BY LoanId";

            //5.3 Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //5.4 Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //5.5 Fill the DataSet DS with the query result
            da.Fill(DS, "lon");

            //5.6 close the DB Connection
            conn.Close();

            //5.7 Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }//5 end

        //6
        public void getLoan(int Mid)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get data for using LoanId
            String strSQL = "SELECT * FROM Loans WHERE MemId = " + Mid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first LoanId, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setLoanId(dr.GetInt32(0));
                setMemId(dr.GetInt32(1));
                setLoanDate(Convert.ToDateTime(dr.GetValue(2)));
                setDueDate(Convert.ToDateTime(dr.GetValue(3)));
            }
            //close DB connection
            myConn.Close();

        }//6 end

        //7  
        public static int nextLoanId()
        {
            //6.1 variable to hold value to be returned
            int intNextLoanId = 1;

            //6.2 Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //6.3 Define SQL query to get MAX loanId used
            String strSQL = "SELECT MAX(LoanId) FROM Loans";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //6.4 execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //6.5 read the first (only) value returned by query
            dr.Read();

            //6.6 An aggregate function always returns 1 row, even if it contains a NULL value

            if (!dr.IsDBNull(0))
                intNextLoanId = dr.GetInt32(0) + 1;

            //6.7 close DB connection
            myConn.Close();

            //6.8 return next StockNo
            return intNextLoanId;
        }//7 end



        // 8 adding new loan 
        public void addLoan()
        {
            //7.1 connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //7.2 Define SQL query to INSERT loan record

            String strSQL = "INSERT INTO Loans VALUES(" + this.loanId.ToString() + "," + this.memId.ToString() +
                            ",'" + this.loanDate.ToString("dd-MMM-yy") + "','" + this.dueDate.ToString("dd-MMM-yy") + "')";

            //7.3 Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //7.4 close DB connection
            myConn.Close();
        }//7 end


        //8
        public void updLoan()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to update/return loan
            String strSQL = "UPDATE Loans SET MemId = " + this.memId + ", LoanDate = " + this.loanDate +
                ", DueDate = " + this.dueDate + " WHERE LoanId = " + this.loanId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }// 8 end

        //9
        public void updLoan(int LnId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to update/return loan
            String strSQL = "UPDATE Loans SET Surname = " + this.memId + ", LoanDate = " + this.loanDate +
                ", DueDate = " + this.dueDate + " WHERE LoanId = "  + LnId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }// 9 end

        
    }
}
