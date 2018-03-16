using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OCMS.Bussiness;
using OCMS.MODEL;
using OCMS.VIEW;

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

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMember.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MemberModel memModel = new MemberModel();

                if (dgvMember.Rows[e.RowIndex].Cells[2].Value.ToString() != null)
                {
                    memModel.EmpID = dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString();
                    memModel.CompanyName = dgvMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                    memModel.MemberCode = dgvMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                    memModel.LName = dgvMember.Rows[e.RowIndex].Cells[3].Value.ToString();
                    memModel.FName = dgvMember.Rows[e.RowIndex].Cells[4].Value.ToString();
                    memModel.MName = dgvMember.Rows[e.RowIndex].Cells[5].Value.ToString();
                    memModel.BDate = dgvMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                    memModel.Age = dgvMember.Rows[e.RowIndex].Cells[6].Value.ToString();
                    memModel.Gender = dgvMember.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
                else
                {
                    MessageBox.Show("There are no specified member code", "OCMS");
                }

                frmConsultation frmConsultation = new frmConsultation(memModel);
                frmConsultation.ShowDialog();
            }


        }
    }
}
