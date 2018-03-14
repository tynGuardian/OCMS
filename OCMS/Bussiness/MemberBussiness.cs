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

        //populated datagrid view
        public List<MemberModel> GetMember()
        {
            try
            {

                DataTable dt = new DataTable();

                List<MemberModel> listMember = _dataAccess.GetMember().ToList();

                return listMember;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
