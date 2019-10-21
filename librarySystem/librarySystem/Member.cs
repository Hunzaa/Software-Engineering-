using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace librarySystem
{
    class Member
    {
        //1 instance variables

        private int memberId;
        private String surname;
        private string forename;
        private string street;
        private string town;
        private string county;
        private DateTime dob;
        private String gender;
        private string phone;
        private string status;
        private decimal fine;

        //2 no argument constructor
        public Member()
        {

            memberId = 0;
            surname = "";
            forename = "";
            street = "";
            town = "";
            county = "";
            dob = DateTime.Now;
            gender = "";
            phone = "";
            status = "";
            fine = 0;
        }

        public Member(int MemberId, String Surname, String Forename, String Street, String Town, String County, DateTime Dob, String Gender, String Phone, String Status, decimal Fine)
        {

            memberId = MemberId;
            surname = Surname;
            forename = Forename;
            street = Street;
            town = Town;
            county = County;
            dob = Dob;
            gender = Gender;
            phone = Phone;
            status = Status;
            fine = Fine;
        }

        //3 Define setters
        public void setMemberId(int MemberId) { this.memberId = MemberId; }
        public void setForename(String Forename) { this.forename = Forename; }
        public void setSurname(String Surname) { this.surname = Surname; }
        public void setStreet(String Street) { this.street = Street; }
        public void setTown(String Town) { this.town = Town; }
        public void setCounty(String County) { this.county = County; }
        public void setDob(DateTime Dob) { this.dob = Dob; }
        public void setGender(String Gender) { this.gender = Gender; }
        public void setPhone(String Phone) { this.phone = Phone; }
        public void setStatus(String Status) { this.status = Status; }
        public void setFine(decimal Fine) { this.fine = Fine; }

        //4 Define getters
        public int getMemberId() { return memberId; }
        public String getForename() { return forename; }
        public String getSurname() { return surname; }
        public String getStreet() { return street; }
        public String getTown() { return town; }
        public String getCounty() { return county; }
        public DateTime getDob() { return dob; }
        public String getGender() { return gender; }
        public String getPhone() { return phone; }
        public String getStatus() { return status; }
        public decimal getFine() { return fine; }




        //5 define a static method to get all data from Member table
        public static DataSet getAllMember(DataSet DS)
        {
            //5.1 create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //5.2 Define the SQL Query to retrieve the data
            String strSQL = "SELECT * FROM Member ORDER BY MemId";

            //5.3 Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //5.4 Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //5.5 Fill the DataSet DS with the query result
            da.Fill(DS, "mmb");

            //5.6 close the DB Connection
            conn.Close();

            //5.7 Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }//5 end

        public static DataSet getMemberBySurname(DataSet DS, String Surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Member WHERE Surname like '%" + Surname + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "mmbS");

            conn.Close();

            return DS;
        }

        public void getMember(int MId)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT * FROM Member WHERE memid = " + MId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first memid, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setMemberId(dr.GetInt32(0));
                setSurname(dr.GetString(1));
                setForename(dr.GetString(2));
                setStreet(dr.GetString(3));
                setTown(dr.GetString(4));
                setCounty(dr.GetString(5));
                setDob(Convert.ToDateTime(dr.GetValue(6)));
                setGender(dr.GetString(7));
                setPhone(dr.GetString(8));
                setStatus(dr.GetString(9));
                setFine(dr.GetInt32(10));

            }
            //close DB connection
            myConn.Close();
        }

        //6 
        public static int nextMemberId()
        {
            //6.1 variable to hold value to be returned
            int intNextMemberId = 1;

            //6.2 Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //6.3 Define SQL query to get MAX bookId used
            String strSQL = "SELECT MAX(memId) FROM Member";

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
                intNextMemberId = dr.GetInt32(0) + 1;

            //6.7 close DB connection
            myConn.Close();

            //6.8 return next StockNo
            return intNextMemberId;
        }//6 end



        // 7 adding new book 
        public void regMember()
        {
            //7.1 connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //7.2 Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Member VALUES(" + this.memberId.ToString() + ",'" + this.surname.ToUpper() +
                            "','" + this.forename.ToUpper() + "','" + this.street.ToUpper() + "','" + this.town.ToUpper() + "','" + this.county.ToUpper() +
                            "','" + this.dob.ToString("dd-MMM-yy")+ "','" + this.gender.ToUpper() + "','" + this.phone.ToUpper() +
                            "','" + this.status.ToUpper() + "','" + this.fine.ToString() + "')";

            //7.3 Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //7.4 close DB connection
            myConn.Close();
        }//7 end


        public void updMember()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Member SET MemId = " + this.memberId.ToString() + ", Surname = '" + this.surname.ToUpper() + "', Forename = '" + this.forename +
                            "', Street = '" + this.street + "', Town = '" + this.town + "', County = '" + this.county +
                            "', Gender_Code = '" + this.gender + "', Phone = '" + this.phone + "', Status = '" + this.status + "', Fine = " + this.fine + " WHERE MemId = " + this.memberId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();  

            //close DB connection
            myConn.Close();
        }

        public void updMember(int MId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Member SET MemId = " + this.memberId.ToString() + ", Surname = '" + this.surname.ToUpper() + "', Forename = " + this.forename +
                ", Street = " + this.street + ", Town = " + this.town + ", County = " + this.county +
                ", Gender_Code = " + this.gender + "', Phone = " + this.phone + ", Status = " + this.status + ", Fine = " + this.fine + " WHERE MemId = " + MId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static void payFine(int MemId, Decimal Amount)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to update/return loan
            String strSQL = "UPDATE Member SET Fine =" + Amount + " WHERE MemId = " + MemId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }// 8 end

        public static void returnFine(int MemId, Decimal Amount)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to update/return loan
            String strSQL = "UPDATE Member SET Fine = Fine + " + Amount + " WHERE MemId = " + MemId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }// 8 end
    }
}
