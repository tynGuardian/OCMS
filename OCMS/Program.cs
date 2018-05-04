using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OCMS.VIEW;

namespace OCMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.ShowDialog();

            //frmMain objfrmLogin = new frmMain();
            //objfrmLogin.ShowDialog();

        }
    }
}
