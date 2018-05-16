using System;
using System.Drawing;
using System.Windows.Forms;
using OCMS.Bussiness;
using OCMS.MODEL;
using OCMS.Class;

namespace OCMS.VIEW
{
    
    public partial class frmUsersInformation : Form
    {
        //int role;
        UsersBusiness usersdata = new UsersBusiness();
        int isupdate = 0;
        public frmUsersInformation()
        {
            InitializeComponent();
            if(clsGlobal.lblprivilege =="Power User")
            {
                chkPrivilege.Visible = false;
                btnSave.Location = new Point(149, 284);
                btnCancel.Location = new Point(230, 284);
                groupBox1.Size = new Size(325, 326);
                this.Size = new Size(347, 346);
            }
        }
        public frmUsersInformation(UsersModel UserList)
        {
            InitializeComponent();
            textLname.Text = UserList.lastname;
            textFname.Text = UserList.firstname;
            textMname.Text = UserList.middlename;
            textLnumber.Text = UserList.licenseno;
            textUsername.Text = UserList.usercode;
            textUsername.Enabled = false;
            btnSave.Text = "Update";
            isupdate = 1;
            if (UserList.privilege == "Admin")
            {
                chkPrivilege.Checked = true;
            }
            else
            {
                chkPrivilege.Checked = false;
            }
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

                    if (users.SaveUsersInfo(user,isupdate) == true)
                    {
                        if (btnSave.Text == "Save")
                        {
                            MessageBox.Show("Users information successfully save.", "OCMS", MessageBoxButtons.OK);
                            ClearAlltext();
                        }
                        else
                        {
                            MessageBox.Show("Successfully update users information.", "OCMS", MessageBoxButtons.OK);
                            ClearAlltext();
                        }
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
                    if (chkPrivilege.Checked == true)
                    {
                        user.privilege = "Admin";
                    }
                    else
                    {
                        user.privilege = "User";
                    }
                    user.active = 1;

                    if (users.SaveUsersInfo(user, isupdate) == true)
                    {
                        if (btnSave.Text == "Save")
                        {
                            MessageBox.Show("Users information successfully save.", "OCMS", MessageBoxButtons.OK);
                            ClearAlltext();
                        }
                        else
                        {
                            MessageBox.Show("Successfully update users information.", "OCMS", MessageBoxButtons.OK);
                            ClearAlltext();
                        }
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            if ((textLname.Text == "") || (textFname.Text == "") || (textUsername.Text == "") || (textPassword.Text == "") || (cmbRole.Text == "") || (textCpassword.Text == ""))
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
        }

        private void textLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
        }

        private void textFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
        }

        private void textMname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
        }

        private void textLnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
        }

        private void cmbRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
        }

        private void textUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
        }

        private void textCpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(sender, e);
            }
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    this.Hide();
            //    frmLogin objfrmLogin = new frmLogin();
            //    objfrmLogin.Closed += (s, args) => this.Close();
            //    objfrmLogin.ShowDialog();
            //}
        }
        public void ClearAlltext()
        {
            textLname.Text = "";
            textFname.Text = "";
            textMname.Text = "";
            textLnumber.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textCpassword.Text = "";
            chkPrivilege.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
