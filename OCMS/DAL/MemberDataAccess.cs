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
        
    }
}
