﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OCMS.MODEL;
using System.Data;
using OCMS.Class;

namespace OCMS.DAL
{
    public class UsersDataAccess
    {
        public bool SaveUsersInformation(UsersModel UsersModel, int isupdate)
        {
            try
            {
                int result;
                DBResource newConnection = new DBResource();
                newConnection.DBOpen();

                SqlCommand comm = new SqlCommand();
                comm.Connection = DBResource.conn;
                comm.CommandText = "dbo.SaveUserInformation";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@LastName", UsersModel.lastname);
                comm.Parameters.AddWithValue("@FirstName", UsersModel.firstname);
                comm.Parameters.AddWithValue("@MiddleName", UsersModel.middlename);
                comm.Parameters.AddWithValue("@UserCode", UsersModel.usercode);
                comm.Parameters.AddWithValue("@UserPassword", UsersModel.userpass);
                comm.Parameters.AddWithValue("@Role", UsersModel.role);
                comm.Parameters.AddWithValue("@LicenseNo", UsersModel.licenseno);
                comm.Parameters.AddWithValue("@Privilege", UsersModel.privilege);
                comm.Parameters.AddWithValue("@active", UsersModel.active);
                comm.Parameters.AddWithValue("@isUpdate", isupdate);
                result = comm.ExecuteNonQuery();
                newConnection.DBClose();
                if (result > 0)
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

        public bool validateUserInformation(UsersModel UsersModel)
        {

            DBResource newConnection = new DBResource();

            using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
            {

                string query = "dbo.CheckUserAccount '" + UsersModel.usercode + "','" + UsersModel.userpass + "','" + UsersModel.role + "'";
                SqlCommand cmd = new SqlCommand(query, myConnection);
                myConnection.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            clsGlobal.lblrole = dr["role"].ToString().Trim();
                            clsGlobal.usercode = dr["user_code"].ToString().Trim();
                            clsGlobal.LastName = dr["last_name"].ToString().Trim();
                            clsGlobal.FirstName = dr["first_name"].ToString().Trim();
                            clsGlobal.lblprivilege = dr["privilege"].ToString().Trim();
                            return true;
                        }
                    }
                    myConnection.Close();
                    return false;
                }
            }

        }

        public List<RoleModel> getRole(int option)
        {
            try
            {

                DBResource newConnection = new DBResource();

                List<RoleModel> listModel = new List<RoleModel>();
                RoleModel RoleModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetRole " + option + "";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            RoleModel = new RoleModel();

                            RoleModel.role = dr["role"].ToString();

                            listModel.Add(RoleModel);
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
        public List<UsersModel> getUsersList(string filter)
        {
            try
            {

                DBResource newConnection = new DBResource();

                List<UsersModel> ListUser = new List<UsersModel>();
                UsersModel UserModel;

                using (SqlConnection myConnection = new SqlConnection(newConnection.connectionString.ToString()))
                {

                    string query = "dbo.GetUsersList " + filter + "";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            UserModel = new UsersModel();
                            UserModel.lastname = dr["last_name"].ToString().Trim();
                            UserModel.firstname = dr["first_name"].ToString().Trim();
                            UserModel.middlename = dr["middle_name"].ToString().Trim();
                            UserModel.userpass = dr["user_password"].ToString().Trim();
                            UserModel.usercode = dr["user_code"].ToString();
                            UserModel.role = dr["role"].ToString().Trim();
                            if (dr.GetBoolean(dr.GetOrdinal("active")) == true)
                            {
                                UserModel.active = 1;
                                UserModel.displayactive = "YES";
                            }
                            else
                            {
                                UserModel.active = 0;
                                UserModel.displayactive = "NO";
                            }
                            UserModel.privilege = dr["privilege"].ToString().Trim();
                            UserModel.licenseno = dr["license_no"].ToString().Trim();
                            ListUser.Add(UserModel);
                        }
                        myConnection.Close();
                    }

                }
                return ListUser;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool UserActivation(UsersModel UsersModel)
        {
            try
            {
                int result;
                DBResource newConnection = new DBResource();
                newConnection.DBOpen();

                SqlCommand comm = new SqlCommand();
                comm.Connection = DBResource.conn;
                comm.CommandText = "dbo.UserActivation";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@usercode", UsersModel.usercode);
                comm.Parameters.AddWithValue("@active", UsersModel.active);
               
                result = comm.ExecuteNonQuery();
                newConnection.DBClose();
                if (result > 0)
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
