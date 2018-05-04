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
            //this.Hide();
            //this.Close();

            //frmUsersInformation objFrmUserInfo = new frmUsersInformation(1);
            //objFrmUserInfo.ShowDialog();

            //this.Hide();
            //frmUsersInformation objFrmUserInfo = new frmUsersInformation(1);
            //objFrmUserInfo.Closed += (s, args) => this.Close();
            //objFrmUserInfo.ShowDialog();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Close();

            //frmUsersInformation objFrmUserInfo = new frmUsersInformation(0);
            //objFrmUserInfo.ShowDialog();

            //this.Hide();
            //frmUsersInformation objFrmUserInfo = new frmUsersInformation(0);
            //objFrmUserInfo.Closed += (s, args) => this.Close();
            //objFrmUserInfo.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Close();

            //frmLogin objfrmLogin = new frmLogin();
            //objfrmLogin.ShowDialog();

            this.Hide();
            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.Closed += (s, args) => this.Close();
            objfrmLogin.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Close();

            //frmPatientComplaint objfrmPatientComplaint = new frmPatientComplaint();
            //objfrmPatientComplaint.ShowDialog();

            this.Hide();
            frmPatientComplaint objfrmPatientComplaint = new frmPatientComplaint();
            objfrmPatientComplaint.Closed += (s, args) => this.Close();
            objfrmPatientComplaint.ShowDialog();
        }

        private void frmConfirmationPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
                this.Close();
        }
    }
}
