using System;
using System.Windows.Forms;

namespace OCMS.Class
{
    public class clsMain
    {
        public clsMain()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        [STAThread]
        static void Main()
        {
            try
            {
                frmLogin objfrmMain = new frmLogin();
                objfrmMain.ShowDialog();
                clsGlobal.g_objfrmMain = new frmMain();
                Application.Run(clsGlobal.g_objfrmMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OCM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }

}
