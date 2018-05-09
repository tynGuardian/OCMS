using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using OCMS.Bussiness;
using System.Reflection;
using OCMS.MODEL;

namespace OCMS.VIEW
{
    public partial class frmPatientList : Form
    {
        private bool sortAscending = false;
        List<PatientComplaintModel> listmodel1 = new List<PatientComplaintModel>();

        public frmPatientList()
        {
            InitializeComponent();
            txtSearch.Focus();
        }

        private void frmPatientList_Load(object sender, EventArgs e)
        {
            PatientComplainBusiness _bll = new PatientComplainBusiness();

            dgvPatient.DataSource = _bll.getPatientList(txtSearch.Text);
            listmodel1 = _bll.getPatientList(txtSearch.Text);
            dgvPatient.Columns[0].Visible = false;
            dgvPatient.Columns[1].Visible = false;
            dgvPatient.Columns[2].Visible = false;
            dgvPatient.Columns[6].Visible = false;
            dgvPatient.Columns[10].Visible = false;
            dgvPatient.Columns[11].Visible = false;
            dgvPatient.Columns[12].Visible = false;

            dgvPatient.Columns[3].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[4].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[5].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[7].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[8].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[9].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[11].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[13].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvPatient.Columns[14].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);

            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgvPatient.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgvPatient, true, null);
            }

        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.Default;

            //DISABLE CLICKING THE HEADER CODE
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvPatient.Rows[e.RowIndex];
            //END

            if (dgvPatient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                PatientComplaintModel listPatientModel = new PatientComplaintModel();

                if (dgvPatient.Rows[e.RowIndex].Cells[2].Value.ToString() != null)
                {
                    listPatientModel.ConsultatonId = dgvPatient.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
                    listPatientModel.geid = dgvPatient.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "";
                    listPatientModel.membercode = dgvPatient.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "";
                    listPatientModel.EmpName = dgvPatient.Rows[e.RowIndex].Cells[3].Value.ToString() ?? "";
                    listPatientModel.Complaints = dgvPatient.Rows[e.RowIndex].Cells[4].Value.ToString() ?? "";
                    listPatientModel.Medicine = dgvPatient.Rows[e.RowIndex].Cells[5].Value.ToString() ?? "";
                    listPatientModel.Company = dgvPatient.Rows[e.RowIndex].Cells[7].Value.ToString() ?? "";
                    listPatientModel.diagnosis = dgvPatient.Rows[e.RowIndex].Cells[8].Value.ToString() ?? "";
                    listPatientModel.CreatedDate = Convert.ToDateTime(dgvPatient.Rows[e.RowIndex].Cells[13].Value.ToString());
                    listPatientModel.disposition = dgvPatient.Rows[e.RowIndex].Cells[9].Value.ToString() ?? "";
                }

                frmConsultation frmConsultation = new frmConsultation(listPatientModel);
                frmConsultation.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                PatientComplainBusiness _bll = new PatientComplainBusiness();
                dgvPatient.DataSource = _bll.getPatientList(txtSearch.Text);
                //DataTable utility = Class.clsUtility.ToDataTable(_bll.getPatientList());
                //dgvPatient.DataSource = utility;
                //listmodel1 = _bll.getPatientList();
                //(dgvPatient.DataSource as DataTable).DefaultView.RowFilter =
                //    string.Format("EmpName LIKE '%{0}%'", txtSearch.Text);
                //(dgvPatient.DataSource as DataTable).DefaultView.ToTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid search" + " " + ex.Message, "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                PatientComplainBusiness _bll = new PatientComplainBusiness();
                txtSearch.Text = "";
                Cursor = Cursors.WaitCursor;
                dgvPatient.DataSource = _bll.getPatientList(txtSearch.Text);
                Cursor = Cursors.Default;
                //DataTable utility = Class.clsUtility.ToDataTable(_bll.getPatientList());
                //dgvPatient.DataSource = utility;
                //listmodel1 = _bll.getPatientList();
                //(dgvPatient.DataSource as DataTable).DefaultView.RowFilter =
                //    string.Format("EmpName LIKE '%{0}%'", txtSearch.Text);
                //(dgvPatient.DataSource as DataTable).DefaultView.ToTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid search" + " " + ex.Message, "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvPatient_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortAscending)
                dgvPatient.DataSource = listmodel1.OrderBy(dgvPatient.Columns[e.ColumnIndex].DataPropertyName).ToList();
            else
                dgvPatient.DataSource = listmodel1.OrderBy(dgvPatient.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            sortAscending = !sortAscending;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(sender, e);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
        }

        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.Default;

            //DISABLE CLICKING THE HEADER CODE
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvPatient.Rows[e.RowIndex];
            //END

            if (dgvPatient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                PatientComplaintModel listPatientModel = new PatientComplaintModel();

                if (dgvPatient.Rows[e.RowIndex].Cells[2].Value.ToString() != null)
                {
                    listPatientModel.ConsultatonId = dgvPatient.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
                    listPatientModel.geid = dgvPatient.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "";
                    listPatientModel.membercode = dgvPatient.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "";
                    listPatientModel.EmpName = dgvPatient.Rows[e.RowIndex].Cells[3].Value.ToString() ?? "";
                    listPatientModel.Complaints = dgvPatient.Rows[e.RowIndex].Cells[4].Value.ToString() ?? "";
                    listPatientModel.Medicine = dgvPatient.Rows[e.RowIndex].Cells[12].Value.ToString() ?? "";
                    listPatientModel.Company = dgvPatient.Rows[e.RowIndex].Cells[7].Value.ToString() ?? "";
                    listPatientModel.diagnosis = dgvPatient.Rows[e.RowIndex].Cells[8].Value.ToString() ?? "";
                    listPatientModel.CreatedDate = Convert.ToDateTime(dgvPatient.Rows[e.RowIndex].Cells[14].Value.ToString());
                    listPatientModel.disposition = dgvPatient.Rows[e.RowIndex].Cells[9].Value.ToString() ?? "";
                }

                frmConsultation frmConsultation = new frmConsultation(listPatientModel);
                frmConsultation.ShowDialog();
            }
        }
    }
}
