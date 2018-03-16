using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using System.Data;

namespace OCMS.DAL
{
    public class ConsultationDataAccess
    {
        public bool SaveConsultation(ConsultationModel model)
        {

            try
            {
                DBResource newConnection = new DBResource();
                newConnection.DBOpen();

                SqlCommand comm = new SqlCommand();
                comm.Connection = DBResource.conn;
                comm.CommandText = "dbo.SaveConsultation";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@consultaton_id", model.ConsultatonId);
                comm.Parameters.AddWithValue("@member_code", model.MemberCOde);
                comm.Parameters.AddWithValue("@time_in", model.TimeIn);
                comm.Parameters.AddWithValue("@time_out", model.TimeOut);
                comm.Parameters.AddWithValue("@complaints", model.Complaints);
                comm.Parameters.AddWithValue("@medicine", model.Medicine);
                comm.Parameters.AddWithValue("@quantity", model.Quantity);
                comm.Parameters.AddWithValue("@disposition", model.Disposition);
                comm.Parameters.AddWithValue("@diag_code", model.DiagCode);
                comm.Parameters.AddWithValue("@created_by", model.CreatedBy);
                comm.Parameters.AddWithValue("@created_date", model.CreatedDate);

                comm.ExecuteNonQuery();
                newConnection.DBClose();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<DispositionModel> getDisposition()
        {
            try
            {

                DBResource newConnection = new DBResource();

                List<DispositionModel> listModel = new List<DispositionModel>();
                DispositionModel dispositionModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetDisposition";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            dispositionModel = new DispositionModel();

                            dispositionModel.dispositionId = Convert.ToInt32(dr["disposition_id"]);
                            dispositionModel.disposition = dr["disposition"].ToString();

                            listModel.Add(dispositionModel);
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

        public List<DiagnosisModel> getDiagnosis()
        {
            try
            {

                DBResource newConnection = new DBResource();

                List<DiagnosisModel> listModel = new List<DiagnosisModel>();
                DiagnosisModel diagnosisModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetDiagnosis";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            diagnosisModel = new DiagnosisModel();

                            diagnosisModel.diag_desc = dr["diag_desc"].ToString();
                            diagnosisModel.diag_code = dr["diag_code"].ToString();
                            diagnosisModel.icd10_code = dr["icd10_code"].ToString();
                            diagnosisModel.icd10_4c = dr["icd10_4c"].ToString();

                            listModel.Add(diagnosisModel);
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
