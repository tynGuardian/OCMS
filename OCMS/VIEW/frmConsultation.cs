using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.MODEL;
using OCMS.Bussiness;

namespace OCMS.VIEW
{
    public partial class frmConsultation : Form
    {
        private string membercode;
        ConsultationBusiness _bll = new ConsultationBusiness();

        public frmConsultation(MemberModel model)
        {
            InitializeComponent();
            txtEmpName.Text = model.LName + ", " + model.FName + " " + model.MName;
            txtAge.Text = model.Age;
            txtGender.Text = model.Gender;
            txtTimeIn.Text = DateTime.Now.ToString("MM/dd/yyyy");
            membercode = model.MemberCode;
        }

        private void frmConsultation_Load(object sender, EventArgs e)
        {
            //BEGIN GET MEDICINE
            cmbMedicine.DataSource = _bll.getMedicine();
            cmbMedicine.DisplayMember = "genericName";
            cmbMedicine.ValueMember = "genericId";
            //END

            //BEGIN GET DISPOSITION
            cmbDisposition.DataSource = _bll.getDisposition();
            cmbDisposition.DisplayMember = "disposition";
            cmbDisposition.ValueMember = "dispositionId";
            //END

            //BEGIN GET DIAGNOSIS
            cmbDiagnosis.DataSource = _bll.getDiagnosis();
            cmbDiagnosis.DisplayMember = "diag_desc";
            cmbDiagnosis.ValueMember = "diag_code";
            //END
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            listComplaint.Items.Add(txtComplaint.Text);
            txtComplaint.Clear();
            if (listComplaint.Items.Count >= 3)
            {

                btnAddComplaint.Enabled = false;
                MessageBox.Show("Maximum complaint encoded", "OCMS");

            }

        }
    }
}
