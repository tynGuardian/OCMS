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
    public class MemberBussiness
    {
        MemberDataAccess _dataAccess = new MemberDataAccess();

        ////Populate Grid using SQL Conn
        //public List<MemberModel> GetMember()
        //{
        //    try
        //    {

        //        List<MemberModel> listMember = _dataAccess.GetMember();

        //        return listMember;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //Populate Grid using Excel File
        public List<MemberModel> GetMemberExcel(string FilePath, string FileName)
        {
            try
            {
                FileInfo file = new FileInfo(FilePath);
                DataTable dt = new DataTable();
                List<MemberModel> listMemModel;

                if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                else
                {
                    listMemModel = _dataAccess.GetMemberExcel(FilePath, FileName);
                    Cursor.Current = Cursors.WaitCursor;
                }

                var list = listMemModel.OrderBy(d => d.LName);
                return list.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid uploaded data", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw ex;
            }
        }
    }
}
