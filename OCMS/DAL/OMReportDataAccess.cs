using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using OCMS.Class;
using System.Data;

namespace OCMS.DAL
{
    public class OMReportDataAccess
    {        
        public List<OMReportModel> RetrieveReport(string datefrom, string dateto)
        {
            try
            {
                DBResource newConnection = new DBResource();

                List<OMReportModel> listOMReport = new List<OMReportModel>();
                OMReportModel OMReport;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {
                    string query = "dbo.GenerateOMReport '" + Convert.ToDateTime(datefrom).ToShortDateString() + "','" + Convert.ToDateTime(dateto).ToShortDateString() + "','Medicard'";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                OMReport = new OMReportModel();
                                OMReport.Employee_id = dr["Employee_id"].ToString();
                                OMReport.Employee_Name = dr["Employee_Name"].ToString();
                                OMReport.Legal_Vehicle = dr["Legal_Vehicle"].ToString();
                                OMReport.created_date = Convert.ToDateTime(dr["date"]).ToShortDateString();
                                OMReport.time_in = Convert.ToDateTime(dr["time_in"]);
                                OMReport.time_out = Convert.ToDateTime(dr["time_out"]);
                                OMReport.BirthDate = dr["BirthDate"].ToString();
                                OMReport.Age = clsUtility.GetAge(DateTime.Now.ToString("MM/dd/yyyy"), dr["BirthDate"].ToString());
                                OMReport.gender = dr["gender"].ToString();
                                OMReport.complaint1 = dr["complaint1"].ToString();
                                OMReport.complaint2 = dr["complaint2"].ToString();
                                OMReport.complaint3 = dr["complaint3"].ToString();
                                OMReport.Medicine1 = dr["Medicine1"].ToString();
                                OMReport.quantity1 = dr["quantity1"].ToString();
                                OMReport.Medicine2 = dr["Medicine2"].ToString();
                                OMReport.quantity2 = dr["quantity2"].ToString();
                                OMReport.Medicine3 = dr["Medicine3"].ToString();
                                OMReport.quantity3 = dr["quantity3"].ToString();
                                OMReport.disposition = dr["disposition"].ToString();
                                OMReport.diagnosis = dr["Diagnosis"].ToString();
                                listOMReport.Add(OMReport);

                            }
                        }
                    }
                    myConnection.Close();
                }
                return listOMReport;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
