using System;
using System.Drawing;
using System.Windows.Forms;
using OCMS.MODEL;
using OCMS.Class;
using OCMS.Bussiness;
using System.Runtime.InteropServices;
using OCMS.VIEW;

namespace OCMS
{
    public partial class frmLogin : Form
    {
        UsersBusiness usersdata = new UsersBusiness();
        public frmLogin()
        {
            InitializeComponent();
            //this.AcceptButton = btnLogin;
        }
        
        private void patientMasterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            frmConfirmationPage objfrmConfirmationPage = new frmConfirmationPage();
            objfrmConfirmationPage.ShowDialog();
        }
        public static Label SetPlaceholder(Control control, string text)
        {
            var placeholder = new Label
            {
                Text = text,
                Font = control.Font,
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Cursor = Cursors.IBeam,
                Margin = Padding.Empty,

                //get rid of the left margin that all labels have
                FlatStyle = FlatStyle.System,
                AutoSize = false,

                //Leave 1px on the left so we can see the blinking cursor
                Size = new Size(control.Size.Width - 1, control.Size.Height),
                Location = new Point(control.Location.X + 1, control.Location.Y)
            };

            //when clicking on the label, pass focus to the control
            placeholder.Click += (sender, args) => { control.Focus(); };

            //disappear when the user starts typing
            control.TextChanged += (sender, args) => {
                placeholder.Visible = string.IsNullOrEmpty(control.Text);
            };

            //stay the same size/location as the control
            EventHandler updateSize = (sender, args) => {
                placeholder.Location = new Point(control.Location.X + 1, control.Location.Y);
                placeholder.Size = new Size(control.Size.Width - 1, control.Size.Height);
            };

            control.SizeChanged += updateSize;
            control.LocationChanged += updateSize;

            control.Parent.Controls.Add(placeholder);
            placeholder.BringToFront();

            return placeholder;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //for encryption connection string
            //string conn = "Server=LAPTOP124\\devteam;Database=OCMS;Integrated Security = false;User ID=usermedicoms;Password=m3d!c0ms";
            //conn = clsUtility.Encrypt(conn.ToString());
            //conn = clsUtility.Decrypt(conn.ToString());

            //string conn = "Server=devteamsvr001;Database=OCMS;Integrated Security = false;User ID=mpiuser;Password=itdbtw3n+y12";
            //conn = clsUtility.Encrypt(conn.ToString());

            UsersBusiness usersbusiness = new UsersBusiness();
            var user = new UsersModel();

            //clsGlobal.userGlbl = textUsername.Text;
            //TO Do, Add Role

            user.usercode = textUsername.Text;
            user.userpass = clsUtility.Encrypt(textPassword.Text);
            if (usersbusiness.validateUserInfo(user) == true)
            {

                if (Class.clsGlobal.lblrole == "Nurse")
                {
                    this.Hide();
                    this.Close();
                    frmMain objfrmMain = new frmMain();
                    objfrmMain.ShowDialog();

                    //patientMasterListToolStripMenuItem_Click(sender, e);

                }
                else
                {
                    this.Hide();
                    this.Close();

                    frmMain objfrmMain = new frmMain();
                    objfrmMain.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Usercode!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            //for encryption connection string
            //string conn = "Server=devteamsvr001;Database=dbMedicomsDenormalize;Integrated Security = false;User ID=mpiuser;Password=itdbtw3n+y12";
            //conn = clsUtility.Encrypt(conn.ToString());
            //conn = clsUtility.Decrypt(conn.ToString());

            //string conn = "Server=devteamsvr001;Database=OCMS;Integrated Security = false;User ID=mpiuser;Password=itdbtw3n+y12";
            //conn = clsUtility.Encrypt(conn.ToString());

            //string test = "Medicard!1";
            //test = clsUtility.Encrypt(test.ToString());
            DBResource newConnection = new DBResource();

            if (newConnection.IsAvailable(newConnection.connectionString.ToString()))
            {
                Cursor.Current = Cursors.AppStarting;
                UsersBusiness usersbusiness = new UsersBusiness();
                var user = new UsersModel();

                //clsGlobal.userGlbl = textUsername.Text;
                //TO Do, Add Role

                user.usercode = textUsername.Text;
                user.userpass = clsUtility.Encrypt(textPassword.Text);
                user.role = cmbRole.Text;
                Class.clsGlobal.lblrole = cmbRole.Text;
                if (usersbusiness.validateUserInfo(user) == true)
                {
                    this.Hide();
                    frmMain objfrmMain = new frmMain();
                    objfrmMain.Closed += (s, args) => this.Close();
                    objfrmMain.ShowDialog();


                    //if (Class.clsGlobal.lblrole == "Nurse")
                    //{
                    //    this.Hide();
                    //    this.Close();
                    //    frmMain objfrmMain = new frmMain();
                    //    objfrmMain.ShowDialog();

                    //    //patientMasterListToolStripMenuItem_Click(sender, e);

                    //}
                    //else
                    //{
                    //    this.Hide();
                    //    frmMain objfrmMain = new frmMain();
                    //    objfrmMain.Closed += (s, args) => this.Close();
                    //    objfrmMain.ShowDialog();
                    //}
                }
                else
                {
                    MessageBox.Show("Kindly check login privilege, username and password!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Please check your database connection!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            DBResource newConnection = new DBResource();

            if (newConnection.IsAvailable(newConnection.connectionString.ToString()))
            {
                cmbRole.DataSource = usersdata.getRole(0);
                cmbRole.DisplayMember = "role";
                cmbRole.ValueMember = "role";
            }
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Employee")
            {
                Hide();
                frmPatientComplaint objfrmPatientComplaint = new frmPatientComplaint();
                objfrmPatientComplaint.Closed += (s, args) => this.Close();
                objfrmPatientComplaint.ShowDialog();
            }
            //else if (comboBox1.Text == "Doctor" || comboBox1.Text == "Nurse")
            //{
            //    textUsername.Enabled = true;
            //    textPassword.Enabled = true;
            //    btnLogin.Enabled = true;
            //    SetPlaceholder(textUsername, "Username");
            //    SetPlaceholder(textPassword, "Password");
            //}
            else if (cmbRole.Text == "")
            {
                textUsername.Enabled = false;
                textPassword.Enabled = false;
                btnLogin.Enabled = false;
                SetPlaceholder(textUsername, "");
                SetPlaceholder(textPassword, "");
            }
            else
            {
                textUsername.Enabled = true;
                textPassword.Enabled = true;
                btnLogin.Enabled = true;
                SetPlaceholder(textUsername, "Username");
                SetPlaceholder(textPassword, "Password");
            }
            textUsername.Focus();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "Employee")
            //{
            //    this.Hide();
            //    frmPatientComplaint objfrmPatientComplaint = new frmPatientComplaint();
            //    objfrmPatientComplaint.Closed += (s, args) => this.Close();
            //    objfrmPatientComplaint.ShowDialog();
            //}
            //else if (comboBox1.Text == "Doctor" || comboBox1.Text == "Nurse")
            //{
            //    textUsername.Enabled = true;
            //    textPassword.Enabled = true;
            //    btnLogin.Enabled = true;
            //    SetPlaceholder(textUsername, "Username");
            //    SetPlaceholder(textPassword, "Password");
            //}
            //else if (comboBox1.Text == "")
            //{
            //    textUsername.Enabled = false;
            //    textPassword.Enabled = false;
            //    btnLogin.Enabled = false;
            //    SetPlaceholder(textUsername, "");
            //    SetPlaceholder(textPassword, "");
            //}
            //textUsername.Focus();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)27)
            //    Close();
        }
        
        private void textUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click_2(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click_2(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.F3)
            {
                frmDatabaseSettings objfrmDatabaseSettings = new frmDatabaseSettings();
                objfrmDatabaseSettings.ShowDialog();
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmUsersInformation objFrmUserInfo = new frmUsersInformation();
            objFrmUserInfo.Closed += (s, args) => this.Close();
            objFrmUserInfo.ShowDialog();
        }
    }
}
