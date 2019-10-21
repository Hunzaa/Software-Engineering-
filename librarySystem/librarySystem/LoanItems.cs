using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace librarySystem
{
    class LoanItems
    {
        //1 instance variables
        private int loanId;
        private int bookId;
        private DateTime returnDate;

        //2 no argument constructor
        public LoanItems()
        {

            loanId = 0;
            bookId = 0;
            returnDate = DateTime.Now;
        }

        public LoanItems(int LoanId, int BookId, DateTime ReturnDate)
        {

            loanId = LoanId;
            bookId = BookId;
            returnDate = ReturnDate;
        }

        //3 Define setters
        public void setLoanId(int LoanId) { this.loanId = LoanId; }
        public void setBookId(int BookId) { this.bookId = BookId; }
        public void setReturnDate(DateTime ReturnDate) { this.returnDate = ReturnDate; }

        //4 Define getters
        public int getLoanId() { return loanId; }
        public int getBookId() { return bookId; }
        public DateTime getReturnDate() { return returnDate; }




        //5 define a static method to get all data from LoanItems
        public static DataSet getAllLoansItems(DataSet DS)
        {
            //5.1 create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //5.2 Define the SQL Query to retrieve the data
            String strSQL = "SELECT * FROM LoanItems ORDER BY LoanId";

            //5.3 Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //5.4 Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //5.5 Fill the DataSet DS with the query result
            da.Fill(DS, "lonItm");

            //5.6 close the DB Connection
            conn.Close();

            //5.7 Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }//5 end




        //6 method to get all data from LoanItems using LoanId
        public void getLoanItems(int Lid)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get data for using LoanId
            String strSQL = "SELECT * FROM LoanItems WHERE LoanId   = " + Lid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first LoanId, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setLoanId(dr.GetInt32(0));
                setBookId(dr.GetInt32(1));
                setReturnDate(Convert.ToDateTime(dr.GetValue(2)));
            }
            //close DB connection
            myConn.Close();

        }//6 end




        //7 adding loanItems
        public void addLoanItem()
        {
            //7.1 connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //7.2 Define SQL query to INSERT loan record

            String strSQL = "INSERT INTO LoanItems (LoanId, BookId) VALUES(" + this.loanId + "," + this.bookId + ")";
                           
            // ",'" + this.returnDate.ToString("dd-MMM-yy") + "')";

            //7.3 Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //7.4 close DB connection
            myConn.Close();
        }//7 end

        public static DataSet getDueLoanItems(DataSet DS)
        {
            //5.1 create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //5.2 Define the SQL Query to retrieve the data
            String strSQL = "SELECT LoanItems.LoanId, Loans.MemId, Book.Title AS Book, Loans.DueDate, LoanItems.Return_Date " +
                            "FROM LoanItems " +
                            "INNER JOIN Loans ON Loans.LOANID = LoanItems.LOANID " +
                            "INNER JOIN Book ON LoanItems.BOOKID = Book.BOOKID " +
                            "WHERE LoanItems.Return_Date > Loans.DueDate"; 

            //5.3 Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //5.4 Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //5.5 Fill the DataSet DS with the query result
            da.Fill(DS, "dueItm");

            //5.6 close the DB Connection
            conn.Close();

            //5.7 Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }//5 end




    }
}
