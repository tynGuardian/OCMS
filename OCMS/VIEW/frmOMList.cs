using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OCMS.Bussiness;
using OCMS.MODEL;
using OCMS.VIEW;
using OCMS.Class;
using System.Data;

namespace OCMS
{
    public partial class frmOMList : Form
    {

        public frmOMList()
        {
            InitializeComponent();
            int newHeight = 61;
            panel1.MaximumSize = new Size(this.Width + 180, newHeight);
            panel1.Size = new Size(this.Width + 180, newHeight);
        }

        private static frmOMList m_OMList;
        public List<MemberModel> excelMemModel;

        public static frmOMList GetChildInstance()
        {
            if (m_OMList == null) //if not created yet, Create an instance
                m_OMList = new frmOMList();
            return m_OMList;  //just created or created earlier.Return it
        }

        private void frmOMList_Load(object sender, EventArgs e)
        {

            MemberBussiness _bll = new MemberBussiness();

            dgvMember.DataSource = excelMemModel;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DataTable utility = Class.clsUtility.ToDataTable(excelMemModel);
            dgvMember.DataSource = utility;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable utility = Class.clsUtility.ToDataTable(excelMemModel);
                dgvMember.DataSource = utility;

                (dgvMember.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("FName LIKE '%{0}%' OR LName LIKE '%{0}%'", txtSearch.Text);
                (dgvMember.DataSource as DataTable).DefaultView.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid search" + " " + ex.Message);
                return;
            }
           

        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.Default;

            //DISABLE CLICKING THE HEADER CODE
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvMember.Rows[e.RowIndex];
            //END

            if (dgvMember.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MemberModel memModel = new MemberModel();

                if (dgvMember.Rows[e.RowIndex].Cells[2].Value.ToString() != null)
                {
                    memModel.EmpID = dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";

                    memModel.MemberCode = dgvMember.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "";

                    memModel.LName = dgvMember.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "";

                    memModel.FName = dgvMember.Rows[e.RowIndex].Cells[3].Value.ToString() ?? "";

                    memModel.MName = dgvMember.Rows[e.RowIndex].Cells[4].Value.ToString() ?? "";

                    memModel.BDate = dgvMember.Rows[e.RowIndex].Cells[5].Value.ToString() ?? "";

                    memModel.Age = dgvMember.Rows[e.RowIndex].Cells[6].Value.ToString() ?? "";

                    memModel.Gender = dgvMember.Rows[e.RowIndex].Cells[7].Value.ToString() ?? "";

                    memModel.CompanyName = dgvMember.Rows[e.RowIndex].Cells[8].Value.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("There are field with no member code", "OCMS");
                }
               
                frmConsultation frmConsultation = new frmConsultation(memModel);
                frmConsultation.ShowDialog();
            }


        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvMember.Rows[e.RowIndex];
        }
    }
}
