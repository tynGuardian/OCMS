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
    public class MedicineDataAccess
    {

        public List<MedicineModel> GetMedicine()
        {
            try
            {

                DBResource newConnection = new DBResource();

                List<MedicineModel> listModel = new List<MedicineModel>();
                MedicineModel medicineModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetMedicine";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while(dr.Read())
                        {
                            medicineModel = new MedicineModel();

                            medicineModel.genericId = Convert.ToInt32(dr["GENERIC_ID"]);
                            medicineModel.genericName = dr["generic_name"].ToString();

                            listModel.Add(medicineModel);
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
