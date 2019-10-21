using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace librarySystem
{
    class Book
    {
        //1 instance variables
    
        private int bookId;
        private String isbn;
        private string title;
        private string author;
        private string category;   
        private string status;

        //2 no argument constructor
        public Book()
        {
    
            bookId = 0;
            isbn = "";
            title = "";
            author = "";
            category = "";           
            status = "";
        }

        public Book(int BookId, String Isbn, String Title, String Author, String Category, String Status)
        {
      
            bookId = BookId;
            isbn = Isbn;
            title = Title;
            author = Author;
            category = Category;        
            status = Status;
        }

        //3 Define setters
        
        public void setBookId(int BookId) { this.bookId = BookId; }
        public void setIsbn(String Isbn) { this.isbn = Isbn; }
        public void setTitle(String Title) { this.title = Title; }
        public void setAuthor(String Author) { this.author = Author; }
        public void setCategory(String Category) { this.category = Category; }
        public void setStatus(String Status) { this.status = Status; }

        //4 Define getters
        public int getBookId() { return bookId; }
        public String getIsbn() { return isbn; }
        public String getTitle() { return title; }
        public String getAuthor() { return author; }
        public String getCategory() { return category; }
        public String getStatus() { return status; }





        //5 define a static method to get all data from Book table
        public static DataSet getAllBook(DataSet DS)
        {
            //5.1 create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //5.2 Define the SQL Query to retrieve the data
            String strSQL = "SELECT BookId, Isbn, Title, Author, Cat_Code, Status FROM Book ORDER BY BookId";

            //5.3 Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //5.4 Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //5.5 Fill the DataSet DS with the query result
            da.Fill(DS, "bk");

            //5.6 close the DB Connection
            conn.Close();

            //5.7 Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }//5 end


        public static DataSet getBookByAuthor(DataSet DS, String Auth)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Book WHERE Author like '%" + Auth + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "bkAut");

            conn.Close();

            return DS;
        }

        /*public void delBook(int BId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to DELETE book record
            String strSQL = "DELETE * FROM Book WHERE BookId = " + BId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }*/

        public void getBook(int BId)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT * FROM Book WHERE BookId = " + BId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setBookId(dr.GetInt32(0));
                setIsbn(dr.GetString(1));
                setTitle(dr.GetString(2));
                setAuthor(dr.GetString(3));
                setCategory(dr.GetString(4));
                setStatus(dr.GetString(5));
                

            }
            //close DB connection
            myConn.Close();
        }

        //6 
        public static int nextBookId()
        {
            //6.1 variable to hold value to be returned
            int intNextBookId = 1;

            //6.2 Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //6.3 Define SQL query to get MAX bookId used
            String strSQL = "SELECT MAX(bookId) FROM Book";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //6.4 execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //6.5 read the first (only) value returned by query
            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //6.6 An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no StockNo's in the Stock File - start at 1
            //Otherwise add 1 to the value read

            if (!dr.IsDBNull(0))
                //intNextBookId = Convert.ToInt32(dr.GetValue(0)) + 1;
                intNextBookId = dr.GetInt32(0) + 1;

            //6.7 close DB connection
            myConn.Close();

            //6.8 return next StockNo
            return intNextBookId;
        }//6 end



        // 7 adding new book 
        public void regBook()
        {
            //7.1 connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //7.2 Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Book VALUES(" + this.bookId.ToString() + ",'" + this.isbn.ToUpper() +
                            "','" + this.title.ToUpper() + "','" + this.author.ToUpper() + "','" + this.category.ToUpper() + 
                            "','" + this.status.ToUpper() + "')";

            //7.3 Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //7.4 close DB connection
            myConn.Close();
        }//7 end


        public void updBook()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Book SET BookId = " + this.bookId.ToString() + ", Title = '" + this.title.ToUpper() + "', Author = '" + this.author +
                "', Cat_Code = '" + this.category + "', Status = '" + this.status + "' WHERE BookId = " + this.bookId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void updBook(int BId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Book SET BookId = " + this.bookId.ToString() + ", Title = '" + this.title.ToUpper() + "', Author = '" + this.author +
                "', Cat_Code = '" + this.category + "', Status = '" + this.status + "' WHERE BookId = " + BId ;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


        public static void newStatus(int BookId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to set status to unavailaible (ie. it is rented)
            String strSQL = "UPDATE Book SET Status = 'U' WHERE BookId = " + BookId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }// 8 end

        public static void newStatusA(int BookId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to set status to unavailaible (ie. it is rented)
            String strSQL = "UPDATE Book SET Status = 'A' WHERE BookId = " + BookId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }// 8 end


        public static void delBook(int BookId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to set status to unavailaible (ie. it is rented)
            String strSQL = "UPDATE Book SET Status = 'R' WHERE BookId = " + BookId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }// 8 end



    }
}
