using System;
using System.Windows.Forms;
using OCMS.VIEW;


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
                //frmLogin objfrmMain = new frmLogin();
                //objfrmMain.ShowDialog();
                //clsGlobal.g_objfrmMain = new frmMain();
                //Application.Run(clsGlobal.g_objfrmMain);

                //frmConfirmationPage objfrmConfirmationPage = new frmConfirmationPage();
                //objfrmConfirmationPage.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OCM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }

}
