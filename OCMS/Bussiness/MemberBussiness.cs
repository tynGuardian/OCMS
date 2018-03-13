using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using OCMS.DAL;
using System.Data;

namespace OCMS.Bussiness
{
    public class MemberBussiness
    {
        MemberDataAccess _dataAccess = new MemberDataAccess();

        public DataTable MemberModel GetMember()
        {
            try
            {

                DataTable dt = new DataTable();

                _dataAccess.GetMember();
                 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
