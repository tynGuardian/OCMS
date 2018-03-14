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

        public List<MemberModel> GetMember()
        {
            try
            {
                DBResource newConnection = new DBResource();
                //newConnection.DBOpen();

                List<MemberModel> listModel = new List<MemberModel>();
                MemberModel memberModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetMembersPerAccount";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            memberModel = new MemberModel();
                            memberModel.memberCode = dr["MemberCode"].ToString();
                            memberModel.Name = dr["NAME"].ToString();
                            memberModel.Age = dr.GetInt32(dr.GetOrdinal("age"));
                            memberModel.Gender = dr["gender"].ToString();
                            memberModel.CompanyName = dr["ACCOUNT_NAME"].ToString();
                            listModel.Add(memberModel);

                        }
                        myConnection.Close();
                    }
                }
                return listModel;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
