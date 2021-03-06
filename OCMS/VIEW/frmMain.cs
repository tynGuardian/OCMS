﻿using System;
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
            
            toolStripLabel4.Text = "Company: " + Properties.Settings.Default.Company;
            if (clsGlobal.lblprivilege == "Power User")
            {
                windowToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;
                patientMasterListToolStripMenuItem.Visible = false;
                importEmployeeToolStripMenuItem.Visible = false;
                closeChildToolStripMenuItem.Visible = false;
            }
            else if (clsGlobal.lblprivilege == "Admin")
            {
                addCompanyDeploymentToolStripMenuItem.Visible = false;
            }
            else if (clsGlobal.lblprivilege == "User")
            {
                createUserLoginToolStripMenuItem.Visible = false;
                addCompanyDeploymentToolStripMenuItem.Visible = false;
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
            //Hide();
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

        private void oMREPORTToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                List<GetDuplicateGEIDModel> listofDuplicate;
                
                _bll.GetEmployeeExcel(filePath, fileName);
                _bll.SaveListEmployee();

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
                MessageBox.Show("Successfully Import List of Employee!", "OCMS", MessageBoxButtons.OK);
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void createUserLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}

