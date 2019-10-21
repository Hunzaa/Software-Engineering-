using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace librarySystem
{
    class FinePayments
    {
        //1 instance variables

        private int payId;
        private int memId;
        private DateTime payDate;
        private decimal amountPaid;

        //2 no argument constructor
        public FinePayments()
        {

            payId = 0;
            memId = 0;
            payDate = DateTime.Now;
            amountPaid = 0;

        }

        public FinePayments(int PayId, int MemId, DateTime PayDate, decimal AmountPaid)
        {

            payId = PayId;
            memId = MemId;
            payDate = PayDate;
            amountPaid = AmountPaid;

        }

        //3 Define setters
        public void setPayId(int PayId) { this.payId = PayId; }
        public void setMemId(int MemId) { this.memId = MemId; }
        public void setPayDate(DateTime PayDate) { this.payDate = PayDate; }
        public void setAmountPaid(decimal AmountPaid) { this.amountPaid = AmountPaid; }

        //4 Define getters
        public int getPayId() { return payId; }
        public int getMemId() { return memId; }
        public DateTime getPayDate() { return payDate; }
        public decimal getAmountPaid() { return amountPaid; }
        

        //7  
        public static int nextPayId()
        {
            //6.1 variable to hold value to be returned
            int intNextPayId = 1;

            //6.2 Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //6.3 Define SQL query to get MAX payId used
            String strSQL = "SELECT MAX(PayId) FROM FinePayments";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //6.4 execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //6.5 read the first (only) value returned by query
            dr.Read();

            //6.6 An aggregate function always returns 1 row, even if it contains a NULL value

            if (!dr.IsDBNull(0))
                intNextPayId = dr.GetInt32(0) + 1;

            //6.7 close DB connection
            myConn.Close();

            //6.8 return next StockNo
            return intNextPayId;
        }//7 end



        // 8 adding new Payment 
        public void addFinePayment()
        {
            //7.1 connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //7.2 Define SQL query to INSERT loan record

            String strSQL = "INSERT INTO FinePayments VALUES(" + this.payId.ToString() + "," + this.memId.ToString() +
                            ",'" + this.payDate.ToString("dd-MMM-yy") + "','" + this.amountPaid.ToString() + "')";

            //7.3 Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //7.4 close DB connection
            myConn.Close();
        }//7 end





    }
}
