using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace learninterface
{
    class Transition
    {
        public void save(string cusId, string Ref, int amtdeposit, int amtcredit)
        {
            string SQL = @" insert into Transition
 (TRA_Customer_Id,TRA_Account_Ref,TRA_Amount_Deposit,TRA_Amount_Credit)
 values( '" + cusId + "' ,'" + Ref + "','" + amtdeposit + "','" + amtcredit + "')";
            SqlConnection con = Main.GetDBConnection();
            DataTable consultanttable = new DataTable();
            SqlDataAdapter Consultantdataadapter = new SqlDataAdapter(SQL, con);
            Consultantdataadapter.Fill(consultanttable);
        }
    }
}
