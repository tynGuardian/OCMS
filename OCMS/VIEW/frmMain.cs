using System;
using System.IO;
using System.Windows.Forms;
using OCMS.Bussiness;

namespace OCMS
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
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

        }

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

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

    }
}

