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
                comm.Parameters.AddWithValue("@lastname", model.LastName);
                comm.Parameters.AddWithValue("@firstname", model.FirstName);
                comm.Parameters.AddWithValue("@complaints", model.Complaints);
                comm.Parameters.AddWithValue("@created_by", model.CreatedBy);
                comm.Parameters.AddWithValue("@created_date", model.CreatedDate);
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
    }
}
