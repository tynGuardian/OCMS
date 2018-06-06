using System;
using System.Windows.Forms;
using OCMS.VIEW;

namespace OCMS.Class
{

    public class clsGlobal
    {
        public static frmMain g_objfrmMain;
        public static string lblrole;
        public static string lblprivilege;
        public static string usercode;
        public static string LastName;
        public static string FirstName;
        //public static frmConfirmationPage g_objfrmConfirmationPage;
        public static string userGlbl;
        public static string SystemVersion;

        public sealed class Global
        {
        }

        public static bool CheckOpened(string formName)
        {
            try
            {
                FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                    if (frm.GetType().Name == formName)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
