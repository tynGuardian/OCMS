using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace OCMS
{
    class DBResource
    {
        public static SqlConnection conn = null;
        public string connectionString = "Data Source=LAPTOP110\\DEVOPS;Initial Catalog=OCMS;User ID=sa;" +
                "Password=KGkristineguardian";

        public void DBOpen()
        {

            conn = new SqlConnection(connectionString);

            conn.Open();
        }

        public void DBClose()
        {

            conn = new SqlConnection(connectionString);

            conn.Close();
        }
    }
}
