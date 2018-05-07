using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using System.Data;
using System.Data.OleDb;

namespace OCMS.DAL
{

    public class MemberDataAccess
    {

        public List<MemberModel> GetMemberExcel(string FilePath, string FileName)
        {
            try
            {
                List<MemberModel> listModel = new List<MemberModel>();
        
                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                          FilePath + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection OleDb = new OleDbConnection(constr);
                OleDb.Open();

                DataTable dt = new DataTable();
                OleDbDataAdapter OleDa = new OleDbDataAdapter(string.Format("select * from [{0}$]", "Sheet1"), constr);
                OleDa.Fill(dt);

                IList<MemberModel> items = dt.AsEnumerable().Select(row =>
                new MemberModel
                {

                    EmpID = row.Field<string>("EMP_NO") ?? " ",
                    CompanyName = row.Field<string>("ACCOUNT_NAME") ?? " ",
                    MemberCode = row.Field<string>("MEMBERCODE") ?? " ",
                    LName = row.Field<string>("LAST_NAME") ?? " ",
                    FName = row.Field<string>("FIRST_NAME") ?? " ",
                    MName = row.Field<string>("MIDDLE_NAME") ?? " ",
                    BDate = row.Field<string>("MEM_BDAY") ?? " ",
                    Age = row.Field<string>("Age") ?? " ",
                    Gender = row.Field<string>("gender").ToUpper() ?? " "

                }).ToList();
                
                return items.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<MemberModel> GetMember()
        {
            try
            {
                DBResource newConnection = new DBResource();
               
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

                            memberModel.EmpID = dr["EMP_NO"].ToString();
                            memberModel.CompanyName = dr["ACCOUNT_NAME"].ToString();
                            memberModel.MemberCode = dr["MemberCode"].ToString();
                            memberModel.LName = dr["lastname"].ToString();
                            memberModel.FName = dr["firstname"].ToString();
                            memberModel.MName = dr["middle_name"].ToString();
                            memberModel.BDate = Convert.ToDateTime(dr["MEM_BDAY"]).ToString("dd/MM/yyyy");
                            //memberModel.Age = dr.GetInt32(dr.GetOrdinal("Age"));
                            memberModel.Gender = dr["gender"].ToString();

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
