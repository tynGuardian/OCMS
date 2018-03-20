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
    public partial class frmPatientComplaint : Form
    {

        PatientComplaintModel PatientComplaintModel = new PatientComplaintModel();
        PatientComplainBusiness _bll = new PatientComplainBusiness();

        public frmPatientComplaint()
        {
            InitializeComponent();
            btnPSave.Enabled = false;
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            listPComplaint.Items.Add(cmbComplaint.Text.ToUpper());
            
            if (listPComplaint.Items.Count >= 3)
            {

                btnPAddComplaint.Enabled = false;
                MessageBox.Show("Maximum complaint encoded", "OCMS");
            }

            cmbComplaint.Focus();
        }

        private void listPComplaint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this complaint ?", "OCMS", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listPComplaint);
                selectedItems = listPComplaint.SelectedItems;

                if (listPComplaint.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listPComplaint.Items.Remove(selectedItems[i]);
                }

            }
        }

        private void chkAgree_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAgree.Checked == true)
            {
                btnPSave.Enabled = true;
            }
            else
            {
                btnPSave.Enabled = false;
            }
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            try
            {

                PatientComplaintModel.ConsultatonId = Guid.NewGuid().ToString();
                PatientComplaintModel.LastName = txtLName.Text.ToUpper();
                PatientComplaintModel.FirstName = txtFName.Text.ToUpper();

                //Getting Complaints items on the listView
                string complaints = "";
                foreach (var item in listPComplaint.Items)
                {
                    complaints += item.ToString() + ",";
                }
                complaints = complaints.Remove(complaints.Length - 1);
                PatientComplaintModel.Complaints = complaints;

                PatientComplaintModel.CreatedDate = DateTime.Now;
                PatientComplaintModel.CreatedBy = (txtLName.Text.ToString() + ", " + txtFName.Text.ToString()).ToUpper();
                PatientComplaintModel.Agree = true;
                PatientComplaintModel.Company = cmbCompany.Text.ToUpper();

                _bll.SavePatientComplaint(PatientComplaintModel);

                MessageBox.Show("Successfully saved!", "OCMS");

            }
            catch (Exception ex)
            {
                MessageBox.Show("We are unable to save you complaint!" + " ," + ex.Message, "OCMS");
                return;
            }
        }

        private void frmPatientComplaint_Load(object sender, EventArgs e)
        {

            //BEGIN GET COMPLAINT
            cmbComplaint.DataSource = _bll.getComplaint();
            cmbComplaint.DisplayMember = "complaint";
            cmbComplaint.ValueMember = "complaint";
            //END

        }
    }
}
