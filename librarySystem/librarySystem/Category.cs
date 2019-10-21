using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace librarySystem
{
    class Category
    {
        String Cat_Code;
        String Description;

        public Category()
        {
            Cat_Code = "";
            Description = "";
        }

        public Category(String catCode, String description)
        {

            Cat_Code = catCode;
            Description = description;
        }

        //3 Define setters
        public void setCatCode(String catCode) { this.Cat_Code = catCode; }
        public void setDescription(String description) { this.Description = description; }
   

        //4 Define getters
        public String getCatCode() { return Cat_Code; }
        public String getDescription() { return Description; }
   

        //5 get all categories
        public static DataSet getAllCategories(DataSet DS)
            {
                //8.1 create an OracleConnection object using the connection string defined in static class DBConnect
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //8.2 Define the SQL Query to retrieve the data
                String strSQL = "SELECT Cat_Code, Description FROM Category ORDER BY Description";

                //8.3 Create an OracleCommand object and instantiate it
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //8.4 Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //8.5 Fill the DataSet DS with the query result
                da.Fill(DS, "ctg");

                //8.6 close the DB Connection
                conn.Close();

                //8.7 Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }//8 end
    }
}
