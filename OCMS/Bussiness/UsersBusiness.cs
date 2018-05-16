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
        public bool SaveUsersInfo(UsersModel usersmodel, int isupdate)
        {
            try
            {
                if (usersdata.SaveUsersInformation(usersmodel, isupdate) == true)
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
        public List<RoleModel> getRole(int option)
        {
            try
            {
                List<RoleModel> roleList = usersdata.getRole(option);

                return roleList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List <UsersModel> getUsers(string filter)
        {
            try
            {
                List<UsersModel> UserList = usersdata.getUsersList(filter);

                return UserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool UserActivation(UsersModel usersmodel)
        {
            try
            {
                if (usersdata.UserActivation(usersmodel) == true)
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
