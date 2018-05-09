using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using System.Data;

namespace OCMS.DAL
{
    public class PatientConsultationDataAccess
    {

        public bool  SavePatientComp(PatientComplaintModel model)
        {
            try
            {

                DBResource newConnection = new DBResource();
                newConnection.DBOpen();

                SqlCommand comm = new SqlCommand();
                comm.Connection = DBResource.conn;
                comm.CommandText = "dbo.SavePatientComplaint";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@consultaton_id", model.ConsultatonId);
                comm.Parameters.AddWithValue("@geid", model.geid);
                comm.Parameters.AddWithValue("@empname", model.EmpName);
                comm.Parameters.AddWithValue("@complaints", model.Complaints);
                comm.Parameters.AddWithValue("@created_date", model.CreatedDate);
                comm.Parameters.AddWithValue("@created_by", model.CreatedBy);
                comm.Parameters.AddWithValue("@medicine", model.Medicine);
                comm.Parameters.AddWithValue("@isAgree", model.Agree);
                comm.Parameters.AddWithValue("@company", model.Company);

                comm.ExecuteNonQuery();
                newConnection.DBClose();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ComplaintModel> getComplaint()
        {
            try
            {

                DBResource newConnection = new DBResource();

                List<ComplaintModel> listModel = new List<ComplaintModel>();
                ComplaintModel complaintModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetComplaint";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            complaintModel = new ComplaintModel();

                            complaintModel.ComplaintId = dr.GetInt32(dr.GetOrdinal("complaint_id"));
                            complaintModel.Complaint = dr["complaint"].ToString();

                            listModel.Add(complaintModel);
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

        public List<PatientComplaintModel> getPatientComplaint(string search)
        {
            try
            {
                DBResource newConnection = new DBResource();

                List<PatientComplaintModel> listModel = new List<PatientComplaintModel>();
                PatientComplaintModel PatientComplaintModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetMembersPerAccount '" + search +"'";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            PatientComplaintModel = new PatientComplaintModel();

                            PatientComplaintModel.ConsultatonId = dr["consultaton_id"].ToString() ?? " ";
                            PatientComplaintModel.geid = dr["geid"].ToString() ?? " ";
                            PatientComplaintModel.EmpName = dr["EmployeeName"].ToString() ?? " ";
                            PatientComplaintModel.Complaints = dr["patient_complaints"].ToString() ?? " ";
                            PatientComplaintModel.Medicine = dr["medicine"].ToString() ?? " ";
                            PatientComplaintModel.CreatedBy = dr["created_by"].ToString() ?? " ";
                            PatientComplaintModel.CreatedDate = Convert.ToDateTime(dr["created_date"]);
                            PatientComplaintModel.Company = dr["company"].ToString() ?? " ";
                            PatientComplaintModel.membercode = dr["membercode"].ToString() ?? " ";
                            PatientComplaintModel.diagnosis = dr["Diagnosis"].ToString() ?? " ";
                            PatientComplaintModel.disposition = dr["Disposition"].ToString() ?? " ";
                            PatientComplaintModel.MedicineValue = dr["medicinevalue"].ToString() ?? " ";

                            listModel.Add(PatientComplaintModel);

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
        public List<PatientComplaintModel> getPatientComplaint(int search)
        {
            try
            {
                DBResource newConnection = new DBResource();

                List<PatientComplaintModel> listModel = new List<PatientComplaintModel>();
                PatientComplaintModel PatientComplaintModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetMembersPerAccount " + search;
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            PatientComplaintModel = new PatientComplaintModel();

                            PatientComplaintModel.ConsultatonId = dr["consultaton_id"].ToString() ?? " ";
                            PatientComplaintModel.geid = dr["geid"].ToString() ?? " ";
                            PatientComplaintModel.EmpName = dr["EmployeeName"].ToString() ?? " ";
                            PatientComplaintModel.Complaints = dr["patient_complaints"].ToString() ?? " ";
                            PatientComplaintModel.Medicine = dr["medicine"].ToString() ?? " ";
                            PatientComplaintModel.CreatedDate = Convert.ToDateTime(dr["created_date"]);
                            PatientComplaintModel.Company = dr["company"].ToString() ?? " ";
                            PatientComplaintModel.membercode = dr["membercode"].ToString() ?? " ";
                            PatientComplaintModel.diagnosis = dr["Diagnosis"].ToString() ?? " ";
                            PatientComplaintModel.disposition = dr["Disposition"].ToString() ?? " ";

                            listModel.Add(PatientComplaintModel);

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
