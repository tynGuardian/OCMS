using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.Class;
using System.Configuration;


namespace OCMS
{
    class DBResource
    {
        public static SqlConnection conn = null;
        //public string connectionString = clsUtility.Decrypt((ConfigurationManager.AppSettings["ConnectionString"].ToString()));
        //Server=devteamsvr001;Database=OCMS;Integrated Security = false; User ID = mpiuser; Password=itdbtw3n+y12
        //Server=devteamsvr001;Database=OCMS;Integrated Security = false; User ID = mpiuser; Password= itdbtw3n+y12
        public string connectionString = "Server=" + Properties.Settings.Default.ServerName + ";Database=" + Properties.Settings.Default.DatabaseName + ";Integrated Security = false; User ID = " + Properties.Settings.Default.User + ";Password="+ Properties.Settings.Default.Password + ";Column Encryption Setting=disabled" + "";
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

        public bool IsAvailable(string connection)
        {
            try
            {
                conn = new SqlConnection(connection);

                conn.Open();
                conn.Close();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

    }
}
