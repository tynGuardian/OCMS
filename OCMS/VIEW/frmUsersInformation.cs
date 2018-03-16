using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.DAL;
using OCMS.Bussiness;
using OCMS.MODEL;
using OCMS.Class;

namespace OCMS.VIEW
{
    
    public partial class frmUsersInformation : Form
    {
        int role;
        public frmUsersInformation(int accessrole)
        {
            InitializeComponent();
            role = accessrole;
            if (role ==1)
            {
                clsGlobal.lblrole = "Doctor";
            }
            else
            {
                clsGlobal.lblrole = "Nurse";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((textLname.Text == "") || (textFname.Text == "") || (textUsername.Text == "") || (textPassword.Text == ""))
            {
                MessageBox.Show("Please fill up all required fields.", "Save");
            }
            else
            {
                SaveUsersInformation();
            }
        }
        public void SaveUsersInformation()
        {
            
            if (textPassword.Text == textCpassword.Text)
            {
                UsersBusiness users = new UsersBusiness();
                var user = new UsersModel();
                user.lastname = textLname.Text;
                user.firstname = textFname.Text;
                user.middlename = textMname.Text;
                user.usercode = textUsername.Text;
                user.userpass = clsUtility.Encrypt(textPassword.Text);
                user.role = clsGlobal.lblrole;
                user.licenseno = textLnumber.Text;
                user.active = 1;
               
                if (users.SaveUsersInfo(user) == true)
                {
                    MessageBox.Show("Users information successfully save.", "Save");

                    this.Hide();
                    this.Close();

                    frmMain objfrmMain = new frmMain();
                    objfrmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username already exists!", "Save");
                }
            }
            else
            {
                MessageBox.Show("Password not Match!", "Save");
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
