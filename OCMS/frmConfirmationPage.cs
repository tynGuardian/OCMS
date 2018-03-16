using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.Class;
using OCMS.VIEW;

namespace OCMS
{
    public partial class frmConfirmationPage : Form
    {
        public frmConfirmationPage()
        {
            InitializeComponent();
        }

        [STAThread]
        private void btnDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            frmUsersInformation objFrmUserInfo = new frmUsersInformation(1);
            objFrmUserInfo.ShowDialog();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            frmUsersInformation objFrmUserInfo = new frmUsersInformation(0);
            objFrmUserInfo.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
