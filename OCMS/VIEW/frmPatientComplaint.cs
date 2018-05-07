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
        GetEmployeeDetailsModel EmpModel = new GetEmployeeDetailsModel();
        PatientComplainBusiness _bll = new PatientComplainBusiness();
        ConsultationBusiness consultationBusiness = new ConsultationBusiness();
        EmployeeBusiness EmpBusiness = new EmployeeBusiness();
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
                MessageBox.Show("Maximum complaint encoded", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmbComplaint.Focus();
        }

        private void listPComplaint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this complaint ?", "OCMS", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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
            Cursor.Current = Cursors.AppStarting;
            try
            {
                if (txtGEID.Text =="" && txtFullName.Text == "")
                {
                    MessageBox.Show("Don't leave blank the GEID and Employee Name!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PatientComplaintModel.ConsultatonId = Guid.NewGuid().ToString();
                    PatientComplaintModel.EmpName = txtFullName.Text.ToUpper();
                    PatientComplaintModel.geid = txtGEID.Text;

                    //Getting Complaints items on the listView
                    string complaints = "";
                    foreach (var item in listPComplaint.Items)
                    {
                        complaints += item.ToString() + ",";
                    }
                    if (complaints =="")
                    {
                        complaints = "";
                        PatientComplaintModel.Complaints = complaints;
                    }
                    else
                    {
                        complaints = complaints.Remove(complaints.Length - 1);
                        PatientComplaintModel.Complaints = complaints;
                    }

                    //getting listViewMed items
                    string medicine = "";
                    foreach (ListViewItem itemRow in this.lvMedicine.Items)
                    {
                        for (int i = 0; i < itemRow.SubItems.Count - 1; i++)
                        {
                            medicine += itemRow.Text + "," + itemRow.SubItems[1].Text + ",";
                        }
                    }
                    if (medicine =="")
                    {
                        medicine = "";
                        PatientComplaintModel.Medicine = medicine;
                    }
                    else
                    {
                        medicine = medicine.Remove(medicine.Length - 1);
                        PatientComplaintModel.Medicine = medicine;
                    }

                    PatientComplaintModel.CreatedDate = DateTime.Now;
                    PatientComplaintModel.CreatedBy = txtFullName.Text.ToUpper();
                    PatientComplaintModel.Agree = true;
                    PatientComplaintModel.Company = cmbCompany.Text.ToUpper();

                    _bll.SavePatientComplaint(PatientComplaintModel);

                    MessageBox.Show("Successfully saved!", "OCMS", MessageBoxButtons.OK);

                    this.Hide();
                    frmLogin objfrmLogin = new frmLogin();
                    objfrmLogin.Closed += (s, args) => this.Close();
                    objfrmLogin.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We are unable to save you complaint!" + " ," + ex.Message, "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor.Current = Cursors.Default;
        }

        private void frmPatientComplaint_Load(object sender, EventArgs e)
        {

            //BEGIN GET COMPLAINT
            cmbComplaint.DataSource = _bll.getComplaint();
            cmbComplaint.DisplayMember = "complaint";
            cmbComplaint.ValueMember = "complaint";
            //END

            //BEGIN GET COMPANY
            cmbCompany.DataSource = consultationBusiness.getCompany();
            cmbCompany.DisplayMember = "company";
            cmbCompany.ValueMember = "company";
            //END

            //BEGIN GET MEDICINE
            cmbMedicine.DataSource = consultationBusiness.getMedicine();
            cmbMedicine.DisplayMember = "genericName";
            cmbMedicine.ValueMember = "genericId";
            //END
            
        }

        private void cmbMedQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbMedQuantity.Text == "")
            {
                MessageBox.Show("Please select quantity!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Add items
                lvMedicine.View = View.Details;
                lvMedicine.Columns.Add("Medicine", 300);
                lvMedicine.Columns.Add("Quantity", 100);

                string[] arrMed = new string[2];
                ListViewItem item;

                arrMed[0] = cmbMedicine.Text.ToString().ToUpper();
                //arrMed[1] = txtMedQuantity.Text.ToString();
                arrMed[1] = cmbMedQuantity.Text.ToString().ToUpper();

                item = new ListViewItem(arrMed);
                lvMedicine.Items.Add(item);
                //txtMedQuantity.Clear();
            }
        }
        
        private void txtGEID_Leave(object sender, EventArgs e)
        {
            List<GetEmployeeDetailsModel> listEmpModel = new List<GetEmployeeDetailsModel>();
            listEmpModel = EmpBusiness.GetEmployeeDetails(txtGEID.Text);
            if (listEmpModel.Count > 0)
            {
                foreach (var item in listEmpModel)
                {
                    txtFullName.Text = item.EmpName;
                    cmbCompany.Text = item.LegalVehicle;
                    cmbCompany.Enabled = false;
                }
            }
            else
            {
                txtFullName.Text = "";
                cmbCompany.Text = "";
                cmbCompany.Enabled = true;
            }
        }

        private void lvMedicine_DoubleClick(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this medicine ?", "OCMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                ListView.SelectedListViewItemCollection selectedItems = new ListView.SelectedListViewItemCollection(lvMedicine);
                selectedItems = lvMedicine.SelectedItems;

                if (lvMedicine.SelectedItems.Count != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        lvMedicine.Items.Remove(selectedItems[i]);
                }

            }
        }

        private void frmPatientComplaint_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmConfirmationPage objfrmConfirmationPage = new frmConfirmationPage();
            objfrmConfirmationPage.Closed += (s, args) => this.Close();
            objfrmConfirmationPage.Show();
        }

        private void txtGEID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.Closed += (s, args) => this.Close();
            objfrmLogin.ShowDialog();
        }
        
        private void cmbComplaint_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsSeparator(pressedKey) || Char.IsPunctuation(pressedKey))
            {
                // Allow input.
                e.Handled = false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
        }

        private void cmbMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsSeparator(pressedKey) || Char.IsPunctuation(pressedKey))
            {
                // Allow input.
                e.Handled = false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
        }

        private void cmbMedQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grpPatient_Enter(object sender, EventArgs e)
        {

        }
    }
}
