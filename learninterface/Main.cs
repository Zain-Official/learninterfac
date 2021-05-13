using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace learninterface
{
    class Main
    {


        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N43NUMQ\ZAIN_SINDHI;Initial Catalog=Practice;User Security=true");
            return conn;

        }
    }
}
