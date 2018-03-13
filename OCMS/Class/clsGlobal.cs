using System;
using System.Windows.Forms;

namespace OCMS.Class
{

    public class clsGlobal
    {
        public static frmMain g_objfrmMain;

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
