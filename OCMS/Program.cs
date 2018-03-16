using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmConfirmationPage frmConfirmationPage = new frmConfirmationPage();
            frmConfirmationPage.ShowDialog();

            //Application.Run(new frmConfirmationPage());
        }
    }
}
