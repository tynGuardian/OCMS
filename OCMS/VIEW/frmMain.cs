using System;
using System.IO;
using System.Windows.Forms;
using OCMS.Bussiness;
using OCMS.MODEL;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using OCMS.Class;
using System.Deployment.Application;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace OCMS
{
    public partial class frmMain : Form
    {

        private BackgroundWorker worker = new BackgroundWorker();
        Version AssemblyVersion = new Version();
        string SystemVersion;
        public frmMain()
        {
            InitializeComponent();
            if (clsGlobal.lblrole == "Nurse")
            {
                VIEW.frmPatientList objfrmpatientlist = new VIEW.frmPatientList();
                objfrmpatientlist.MdiParent = this;
                objfrmpatientlist.WindowState = FormWindowState.Maximized;
                objfrmpatientlist.Show();
            }
        }

        private void operationMasterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOMList objOmList = new frmOMList();
            objOmList.MdiParent = this;
            objOmList.WindowState = FormWindowState.Maximized;
            objOmList.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Current User: " + clsGlobal.usercode;
            windowToolStripMenuItem.Visible = false;
            closeChildToolStripMenuItem.Visible = false;
            //MOD BY KNG
            if (Properties.Settings.Default.Company == "")
            {
                toolStripLabel4.Text = "Company: " ;
            }
            else
            {
                toolStripLabel4.Text = "Company: " + Properties.Settings.Default.Company;
            }

            if (clsGlobal.lblprivilege == "Power User")
            {
                if (Properties.Settings.Default.Company == "")
                {
                    MessageBox.Show("Please don't forget to update the company in Maintenance -> Company Deployment -> Press Ok", "OCMS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                windowToolStripMenuItem.Visible = false;
                windowToolStripMenuItem.Enabled = false;
                patientMasterListToolStripMenuItem.Visible = false;
                patientMasterListToolStripMenuItem.Enabled = false;
                importEmployeeToolStripMenuItem.Visible = false;
                importEmployeeToolStripMenuItem.Enabled = false;
                reportToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Enabled = false;
                closeChildToolStripMenuItem.Visible = false;
                closeChildToolStripMenuItem.Enabled = false;
                userListToolStripMenuItem.Visible = false;
                userListToolStripMenuItem.Enabled = false;
            }
            else if (clsGlobal.lblprivilege == "Admin")
            {
                addCompanyDeploymentToolStripMenuItem.Visible = false;
                addCompanyDeploymentToolStripMenuItem.Enabled = false;
            }
            else if (clsGlobal.lblprivilege == "User")
            {
                maintenanceToolStripMenuItem.Visible = false;
                createUserLoginToolStripMenuItem.Enabled = false;
                userListToolStripMenuItem.Enabled = false;
                addCompanyDeploymentToolStripMenuItem.Enabled = false;
            }

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                AssemblyVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                SystemVersion = AssemblyVersion.ToString();
                this.Text = "On-Site Clinic Management System Ver. " + "(" + SystemVersion + ")";
            }
            else
            {
                SystemVersion = Application.ProductVersion.ToString();
                this.Text = "On-Site Clinic Management System Ver. " + "(" + SystemVersion + ")";
            }

            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }
        //public Version AssemblyVersion
        //{
        //    get
        //    {
        //        if(ApplicationDeployment.IsNetworkDeployed)
        //        {
        //            return ApplicationDeployment.CurrentDeployment.CurrentVersion;
        //        }
        //        else
        //        {
        //            return Application.ProductVersion.ToString();
        //        }
        //    }

        //}

        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.menuStrip1.MdiWindowListItem = mnuWindowCascade;
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVertocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.MdiWindowListItem = mnuTileVertical;
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.MdiWindowListItem = mnuTileHorizontal;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OnSite Clinic Management System version " + Application.ProductVersion.ToString() /*Assembly.GetExecutingAssembly().GetName().Version.ToString()*/, "OCMS");
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //Close();
            //frmConfirmationPage objfrmConfirmationPage = new frmConfirmationPage();
            //objfrmConfirmationPage.ShowDialog();
            
            this.Hide();
            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.Closed += (s, args) => this.Close();
            objfrmLogin.ShowDialog();
        }

        private void closeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                bool openOMList = Class.clsGlobal.CheckOpened("frmOMList");

                //To Close Active Child Form
                if (openOMList == true)
                {
                    if (this.ActiveMdiChild.Name == "frmOMList")
                    {
                        frmOMList _objOmList = (frmOMList)this.ActiveMdiChild;
                        _objOmList.Close();
                    }
                }
                //else
                //{
                //    closeChildToolStripMenuItem.Enabled = false;
                //}

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void importListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberBussiness _bll = new MemberBussiness();
            frmOMList frmOMList = new frmOMList();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                //frmOMList.dgvMember.DataSource = _bll.GetMemberExcel(filePath, fileName);

                frmOMList.excelMemModel = _bll.GetMemberExcel(filePath, fileName);
                frmOMList.MdiParent = this;
                frmOMList.WindowState = FormWindowState.Maximized;
                frmOMList.dgvMember.MaximumSize = MaximumSize;
                frmOMList.Show();
            }
        }

        private void generateOMReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            VIEW.frmOMReport objOMReport = new VIEW.frmOMReport();
            objOMReport.StartPosition = FormStartPosition.CenterScreen;
            objOMReport.Show();
            Cursor = Cursors.Default;
        }

        private void patientMasterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            VIEW.frmPatientList objfrmpatientlist = new VIEW.frmPatientList();
            objfrmpatientlist.MdiParent = this;
            objfrmpatientlist.WindowState = FormWindowState.Maximized;
            objfrmpatientlist.Show();
            Cursor = Cursors.Default;
        }

        private void importEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeBusiness _bll = new EmployeeBusiness();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;";
            Cursor.Current = Cursors.WaitCursor;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                List<GetDuplicateGEIDModel> listofDuplicate;
                List<EmployeeModel> ExistingDetails;
                
                _bll.GetEmployeeExcel(filePath, fileName);
                _bll.SaveListEmployee();

                //Write duplicate list in text file
                listofDuplicate = _bll.GetDuplicateGEID(filePath, fileName);

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Directory.CreateDirectory(path + "\\ListofDuplicate");
                string fullpath = path + "\\ListofDuplicate\\DuplicateGEID_" + fileName.Replace(".xls", "") + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
                StreamWriter writer = new StreamWriter(fullpath, false, System.Text.Encoding.GetEncoding("windows-1252"));
                writer.WriteLine("GEID Number ; Employee Name ; Legal Vehicle");
                if (listofDuplicate.Count > 0)
                {
                    
                    for (int i = 0; i <= listofDuplicate.Count - 1; i++)
                    {
                        writer.WriteLine(listofDuplicate[i].GEID + " ; " + listofDuplicate[i].EmpName + " ; " + listofDuplicate[i].LegalVehicle);
                    }
                    MessageBox.Show("Please check the list of duplicate GEID # in: " + fullpath, "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                writer.Close();
                // Up to here

                killExcel();
                MessageBox.Show("Successfully Import List of Employee!", "OCMS", MessageBoxButtons.OK);

                //Check if there is existing employee saved to database
                ExistingDetails = _bll.GetEmployeeDetails();
                if (ExistingDetails.Count > 0)
                {
                    MessageBox.Show("Please select the correct details of employee!", "OCMS", MessageBoxButtons.OK);
                    VIEW.frmEmployeeDetails objfrmEmployeeDetails = new VIEW.frmEmployeeDetails();
                    objfrmEmployeeDetails.StartPosition = FormStartPosition.CenterScreen;
                    objfrmEmployeeDetails.Show();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void createUserLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersModel UserList = new UsersModel();

            VIEW.frmUsersInformation objFrmUserInfo = new VIEW.frmUsersInformation();
            objFrmUserInfo.StartPosition = FormStartPosition.CenterScreen;
            objFrmUserInfo.Show();
        }
       
        private void tmr_Tick(object sender, EventArgs e)
        {
            toolStripLabel3.Text = "Date and Time: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:tt");
        }

        private void addCompanyDeploymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter the company", "", Properties.Settings.Default.Company, -1, -1);

            Properties.Settings.Default.Company = input;
            Properties.Settings.Default.Save();
        }
        private void killExcel()
        {
            Process[] Processes;
            Processes = System.Diagnostics.

            Process.GetProcessesByName("EXCEL");

            foreach (System.Diagnostics.Process p in Processes)
            {
                if (p.MainWindowTitle.Trim() == "")
                    p.Kill();
            }

        }

        private void oMREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            VIEW.frmOMReport objfrmOMReport = new VIEW.frmOMReport();
            objfrmOMReport.StartPosition = FormStartPosition.CenterScreen;
            objfrmOMReport.Show();
            Cursor = Cursors.Default;
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            VIEW.frmUserList objfrmUserList = new VIEW.frmUserList();
            objfrmUserList.StartPosition = FormStartPosition.CenterScreen;
            objfrmUserList.Show();
            Cursor = Cursors.Default;
        }
    }
}

