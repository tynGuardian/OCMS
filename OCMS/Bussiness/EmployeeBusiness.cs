using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using OCMS.MODEL;
using OCMS.DAL;
using System.Data;
using System.Windows.Forms;

namespace OCMS.Bussiness
{
    public class EmployeeBusiness
    {
        EmployeeDataAccess _dataAccess = new EmployeeDataAccess();
        public List<EmployeeModel> GetEmployeeExcel(string FilePath, string FileName)
        {
            try
            {
                FileInfo file = new FileInfo(FilePath);
                DataTable dt = new DataTable();
                List<EmployeeModel> listEmployeeModel;

                //To Do:
                //Complete error message, err message + title + icon
                if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                else
                {
                    listEmployeeModel = _dataAccess.GetEmployeeExcel(FilePath, FileName);
                    Cursor.Current = Cursors.WaitCursor;
                }

                var list = listEmployeeModel.OrderBy(d => d.EmployeeName);
                return list.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid uploaded data: " +  ex.Message.ToString(), "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw new Exception(ex.InnerException.Message);
            }
        }
        public bool SaveListEmployee()
        {
            try
            {

                _dataAccess.SaveEmployeeExcel();
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        public List<GetEmployeeDetailsModel> GetEmployeeDetails(string GEID)
        {
            try
            {
                List<GetEmployeeDetailsModel> listEmployeeModel;
                
                listEmployeeModel = _dataAccess.GetEmpDetails(GEID);
                    
                return listEmployeeModel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid uploaded data", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw ex;
            }
        }
        public List<GetDuplicateGEIDModel> GetDuplicateGEID(string FilePath, string FileName)
        {
            try
            {
                FileInfo file = new FileInfo(FilePath);
                DataTable dt = new DataTable();
                List<GetDuplicateGEIDModel> ListofDuplicate;

                if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                else
                {
                    ListofDuplicate = _dataAccess.GetDuplicateGEID(FilePath, FileName);
                    Cursor.Current = Cursors.WaitCursor;
                }

                var list = ListofDuplicate.OrderBy(d => d.GEID);
                return list.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid uploaded data", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw ex;
            }
        }

        public List<EmployeeModel> getPatientList()
        {
            try
            {
                List<EmployeeModel> employeeList = _dataAccess.GetEncryptedDetails();

                return employeeList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
