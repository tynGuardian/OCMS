using System;
using System.Windows.Forms;

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

        
    }
}
