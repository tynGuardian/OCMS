using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OCMS.DAL
{
    public class EmployeeDataAccess
    {
        int EmployeeCount;
        public List<EmployeeModel> listMemModel;
        public List<EmployeeModel> GetEmployeeExcel(string FilePath, string FileName)
        {
            try
            {
                List<EmployeeModel> listEmployeeModel = new List<EmployeeModel>();

                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                          FilePath + ";Extended Properties='Excel 12.0 XML;HDR=YES;IMEX=2;';";

                OleDbConnection OleDb = new OleDbConnection(constr);
                OleDb.Open();

                DataTable dt = new DataTable();
                OleDbDataAdapter OleDa = new OleDbDataAdapter(string.Format("select * from [{0}$] where [GEID #] in (select [GEID #] from [{0}$] where [Member Type] = 'P' group by [GEID #] having count(*) = 1) and [Member Type] = 'P'", "Sheet1"), constr);
                OleDa.Fill(dt);

                IList<EmployeeModel> items = dt.AsEnumerable().Select(row =>
                new EmployeeModel
                {

                    GEID = row.Field<string>("GEID #") ?? " ",
                    CostCenter = row.Field<string>("Cost Center #") ?? " ",
                    LegalVehicle = row.Field<string>("Legal Vehicle") ?? " ",
                    MemberType = row.Field<string>("Member Type") ?? " ",
                    Membercode = row.Field<string>("Medicard #") ?? " ",
                    EmployeeName = row.Field<string>("Name") ?? " ",
                    Sex = row.Field<string>("Sex") ?? " ",
                    CS = row.Field<string>("CS") ?? " ",
                    BirthDate = row.Field<string>("Birthday"),
                    EffectiveDate = row.Field<DateTime>("Effective Date"),
                    ValidityDate = row.Field<DateTime>("Validity Date"),
                    Relation = row.Field<string>("Relation") ?? " ",
                    PlanDescription = row.Field<string>("Plan Description") ?? " ",
                    Area = row.Field<string>("Area") ?? " "

                    

                }).ToList();
                EmployeeCount = items.Count;
                listMemModel = items.ToList();
                return items.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool SaveEmployeeExcel()
        {
            try
            {
                DBResource newConnection = new DBResource();

                VIEW.frmProgress obj = new VIEW.frmProgress();
                obj.Show();
                for (int i = 0; i <= EmployeeCount - 1; i++)
                {
                    Application.DoEvents();
                    newConnection.DBOpen();
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = DBResource.conn;
                    comm.CommandText = "dbo.SaveListOfEmployee";
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@GEID", listMemModel[i].GEID);
                    comm.Parameters.AddWithValue("@CostCenter", listMemModel[i].CostCenter);
                    comm.Parameters.AddWithValue("@LegalVehicle", listMemModel[i].LegalVehicle);
                    comm.Parameters.AddWithValue("@MemberType", listMemModel[i].MemberType);
                    comm.Parameters.AddWithValue("@Membercode", listMemModel[i].Membercode);
                    comm.Parameters.AddWithValue("@EmployeeName", listMemModel[i].EmployeeName);
                    comm.Parameters.AddWithValue("@Sex", listMemModel[i].Sex);
                    comm.Parameters.AddWithValue("@CS", listMemModel[i].CS);
                    comm.Parameters.AddWithValue("@BirthDate", listMemModel[i].BirthDate);
                    comm.Parameters.AddWithValue("@EffectiveDate", listMemModel[i].EffectiveDate);
                    comm.Parameters.AddWithValue("@ValidityDate", listMemModel[i].ValidityDate);
                    comm.Parameters.AddWithValue("@Relation", listMemModel[i].Relation);
                    comm.Parameters.AddWithValue("@PlanDescription", listMemModel[i].PlanDescription);
                    comm.Parameters.AddWithValue("@Area", listMemModel[i].Area);

                    comm.ExecuteNonQuery();
                    comm.Dispose();
                    newConnection.DBClose();
                    SqlConnection.ClearAllPools();
                    obj.Text = "Total number of employees: " + i + " of " + EmployeeCount;
                }
                obj.Close();
                obj.Hide();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<GetEmployeeDetailsModel> GetEmpDetails(string GEID)
        {
            try
            {

                DBResource newConnection = new DBResource();

                List<GetEmployeeDetailsModel> listEmpModel = new List<GetEmployeeDetailsModel>();
                GetEmployeeDetailsModel EmpDetailsModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetEmployeeDetails'" + GEID + "'";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            EmpDetailsModel = new GetEmployeeDetailsModel();

                            EmpDetailsModel.LegalVehicle = dr["LegalVehicle"].ToString();
                            EmpDetailsModel.EmpName = dr["EmployeeName"].ToString();

                            listEmpModel.Add(EmpDetailsModel);
                        }
                        myConnection.Close();
                    }

                }
                return listEmpModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<GetDuplicateGEIDModel> GetDuplicateGEID(string FilePath, string FileName)
        {
            try
            {
                List<GetDuplicateGEIDModel> ListofDuplicate = new List<GetDuplicateGEIDModel>();

                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                          FilePath + ";Extended Properties='Excel 12.0 XML;HDR=YES;IMEX=2;';";

                OleDbConnection OleDb = new OleDbConnection(constr);
                OleDb.Open();

                DataTable dt = new DataTable();
                OleDbDataAdapter OleDa = new OleDbDataAdapter(string.Format("select [GEID #], [Name], [Legal Vehicle] from [{0}$] where [GEID #] in (select [GEID #] from [{0}$] where [Member Type] = 'P' group by [GEID #] having count(*) = 2) and [Member Type] = 'P'", "Sheet1"), constr);
                OleDa.Fill(dt);

                IList<GetDuplicateGEIDModel> items = dt.AsEnumerable().Select(row =>
                new GetDuplicateGEIDModel
                {

                    GEID = row.Field<string>("GEID #") ?? " ",
                    EmpName = row.Field<string>("Name") ?? " ",
                    LegalVehicle = row.Field<string>("Legal Vehicle") ?? " ",

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
