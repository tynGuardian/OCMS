﻿using System;
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
        //int role;
        UsersBusiness usersdata = new UsersBusiness();
        public frmUsersInformation()
        {
            InitializeComponent();
            //if (role ==1)
            //{
            //    clsGlobal.lblrole = "Doctor";
            //}
            //else
            //{
            //    clsGlobal.lblrole = "Nurse";
            //}
        }
        
        public void SaveUsersInformation()
        {
            if (clsGlobal.lblprivilege == "Power User")
            {
                clsGlobal.lblrole = cmbRole.Text;
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
                    user.privilege = "Admin";
                    user.active = 1;

                    if (users.SaveUsersInfo(user) == true)
                    {
                        MessageBox.Show("Users information successfully save.", "OCMS", MessageBoxButtons.OK);

                        //this.Hide();
                        //frmMain objfrmMain = new frmMain();
                        //objfrmMain.Closed += (s, args) => this.Close();
                        //objfrmMain.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username already exists!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Password not Match!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(clsGlobal.lblprivilege =="Admin")
            {
                clsGlobal.lblrole = cmbRole.Text;
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
                    user.privilege = "User";
                    user.active = 1;

                    if (users.SaveUsersInfo(user) == true)
                    {
                        MessageBox.Show("Users information successfully save.", "OCMS", MessageBoxButtons.OK);

                        //this.Hide();
                        //frmMain objfrmMain = new frmMain();
                        //objfrmMain.Closed += (s, args) => this.Close();
                        //objfrmMain.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username already exists!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Password not Match!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        private void frmUsersInformation_Load(object sender, EventArgs e)
        {
            cmbRole.DataSource = usersdata.getRole(1);
            cmbRole.DisplayMember = "role";
            cmbRole.ValueMember = "role";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //frmLogin objfrmLogin = new frmLogin();
            //objfrmLogin.Closed += (s, args) => this.Close();
            //objfrmLogin.ShowDialog();
            Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            if ((textLname.Text == "") || (textFname.Text == "") || (textUsername.Text == "") || (textPassword.Text == "") || (cmbRole.Text == ""))
            {
                MessageBox.Show("Please fill up all required fields!", "OCMS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SaveUsersInformation();
            }
            Cursor.Current = Cursors.Default;
        }

        private void textLnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmUsersInformation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void textLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }

        private void textFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }

        private void textMname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }

        private void textLnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }

        private void cmbRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }

        private void textUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }

        private void textCpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.Closed += (s, args) => this.Close();
                objfrmLogin.ShowDialog();
            }
        }
    }
}
