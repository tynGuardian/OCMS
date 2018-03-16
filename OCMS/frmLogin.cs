using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.MODEL;
using OCMS.Class;
using OCMS.Bussiness;
using OCMS.VIEW;

namespace OCMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsersBusiness usersbusiness = new UsersBusiness();
            var user = new UsersModel();
            user.usercode = textUsername.Text;
            user.userpass = clsUtility.Encrypt(textPassword.Text);
            if (usersbusiness.validateUserInfo(user) == true)
            {
                this.Hide();
                this.Close();

                frmMain objfrmMain = new frmMain();
                objfrmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Usercode!", "Login");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            frmConfirmationPage objfrmConfirmationPage = new frmConfirmationPage();
            objfrmConfirmationPage.ShowDialog();
        }
    }
}
