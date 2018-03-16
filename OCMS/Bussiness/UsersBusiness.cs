using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OCMS.MODEL;
using OCMS.DAL;

namespace OCMS.Bussiness
{
    public class UsersBusiness
    {
        UsersDataAccess usersdata = new UsersDataAccess();
        UsersDataAccess validateuser = new UsersDataAccess();
        public bool SaveUsersInfo(UsersModel usersmodel)
        {
            try
            {
                if (usersdata.SaveUsersInformation(usersmodel) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           catch(Exception ex)
            {
                throw ex;
            }

        }

        public bool validateUserInfo(UsersModel usermodel)
        {
            try
            {
                if (validateuser.validateUserInformation(usermodel) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
