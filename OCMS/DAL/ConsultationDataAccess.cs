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

    }
}
