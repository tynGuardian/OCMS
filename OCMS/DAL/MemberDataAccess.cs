using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using System.Data;

namespace OCMS.DAL
{

    public class MemberDataAccess
    {

        public MemberModel GetMember()
        {
            try
            {
                DBResource newConnection = new DBResource();
                //newConnection.DBOpen();

                MemberModel model = new MemberModel();

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {
                   
                    string query = "dbo.GetMembersPerAccount";
                    SqlCommand cmd = new SqlCommand(query,myConnection);
                    myConnection.Open();


                    //using (SqlDataReader dr = cmd.ExecuteReader())
                    //{
                    //    while (dr.Read())
                    //    {
                    //        model.memberCode = dr["MemberCode"].ToString();
                    //        model.Name = dr["NAME"].ToString();
                    //        model.Age = dr.GetInt32(dr.GetOrdinal("age"));
                    //        model.Gender = dr["gender"].ToString();
                    //        model.CompanyName = dr["ACCOUNT_NAME"].ToString();
                    //    }
                    //    myConnection.Close();
                    //}
                }
                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
