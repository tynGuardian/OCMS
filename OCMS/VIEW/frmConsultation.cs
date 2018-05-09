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
using OCMS.Class;

namespace OCMS.VIEW
{
    public partial class frmConsultation : Form
    {
        private string membercode;
        private string consultationID;
        private string GEID;
        private string disposition;
        PatientComplainBusiness compBusiness = new PatientComplainBusiness();

        ConsultationBusiness _bll = new ConsultationBusiness();

        public frmConsultation(MemberModel model)
        {
            InitializeComponent();
            txtEmpName.Text = model.LName + ", " + model.FName + " " + model.MName;
            txtAge.Text = model.Age;
            txtGender.Text = model.Gender;
            txtTimeIn.Text = DateTime.Now.ToString("MM/dd/yyyy");
            membercode = model.MemberCode;
            txtBday.Text = model.BDate;
        }
        public frmConsultation(PatientComplaintModel patientModel)
        {
            InitializeComponent();
            if (patientModel.Complaints!="")
            {
                string[] words = patientModel.Complaints.Split(',');
                foreach (string word in words)
                {
                    listComplaint.Items.Add(word);
                }
            }
            if (patientModel.Medicine != "")
            {
                lvMedicine.View = View.Details;
                lvMedicine.Columns.Add("Medicine", 300);
                lvMedicine.Columns.Add("Quantity", 100);
                ListViewItem item;
                string[] meds = patientModel.Medicine.Split(',');

                for (int i = 0; i < meds.Length; i++)
                {

                    string[] arrMed = new string[2];
                    for (int j = 0; j <= 1; j++)
                    {
                        arrMed[j] = meds[i];
                        i += 1;
                    }
                    i -= 1;
                    item = new ListViewItem(arrMed);
                    lvMedicine.Items.Add(item);
                }
            }
            if (patientModel.diagnosis != "")
            {
                lvDiagnosis.View = View.Details;
                lvDiagnosis.Columns.Add("Diagnosis", 300);
                string[] words = patientModel.diagnosis.Split(';');
                foreach (string word in words)
                {
                    lvDiagnosis.Items.Add(word);
                }
            }
            disposition = patientModel.disposition;
            txtEmpName.Text = patientModel.EmpName;
            txtCompany.Text = patientModel.Company;
            txtTimeIn.Text = Convert.ToDateTime(patientModel.CreatedDate).ToString();
            
            consultationID = patientModel.ConsultatonId;
            GEID = patientModel.geid;
            membercode = patientModel.membercode;
            
            //Manipulate Access Role
            if (clsGlobal.lblrole == "Nurse")
            {
                this.Size = new Size(503, 450);
                groupBox1.Size = new Size(460, 255);
            }
            //END
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

            //BEGIN GET COMPLAINTS
            cmbComplaint.DataSource = compBusiness.getComplaint();
            cmbComplaint.DisplayMember = "complaint";
            cmbComplaint.ValueMember = "complaint";
            //END

            if (disposition != "" || disposition != null)
            {
                cmbDisposition.Text = disposition;
            }

            dtpTimeOut.Text = DateTime.Now.ToString("MM/dd/yyyy");
            dtpTimeOutTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
            AcceptButton = btnSaveConsultation;
        }

        private void listComplaint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this complaint ?", "OCMS", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listComplaint);
                selectedItems = listComplaint.SelectedItems;

                if (listComplaint.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listComplaint.Items.Remove(selectedItems[i]);
                }

            }
        }

        private void btnSaveConsultation_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            try
            {

                ConsultationModel consultationModel = new ConsultationModel();

                consultationModel.ConsultatonId = consultationID;
                consultationModel.GEID = GEID;
                consultationModel.MemberCode = membercode;
                consultationModel.TimeIn = Convert.ToDateTime(txtTimeIn.Text);
                consultationModel.TimeOut = Convert.ToDateTime(dtpTimeOut.Text + " " + dtpTimeOutTime.Text);
                consultationModel.Disposition = cmbDisposition.Text.ToString();

                //getting listBoxComplaint items
                string complaints = "";
                foreach (var item in listComplaint.Items)
                {
                    complaints += item.ToString() + ",";
                }
                if (complaints =="")
                {
                    complaints = "";
                    consultationModel.Complaints = complaints;
                }
                else
                {
                    complaints = complaints.Remove(complaints.Length - 1);
                    consultationModel.Complaints = complaints;
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
                    consultationModel.Medicine = medicine;
                }
                else
                {
                    medicine = medicine.Remove(medicine.Length - 1);
                    consultationModel.Medicine = medicine;
                }

                consultationModel.CreatedBy = clsGlobal.usercode;
                consultationModel.CreatedDate = DateTime.Now;

                if (clsGlobal.lblrole == "Doctor")
                {
                    //getting listViewMed items
                    string diagnosis = "";
                    foreach (ListViewItem itemRow in this.lvDiagnosis.Items)
                    {
                        for (int i = 0; i < itemRow.SubItems.Count - 1; i++)
                        {
                            diagnosis += itemRow.SubItems[1].Text + ",";
                        }
                    }
                    if (diagnosis == "")
                    {
                        diagnosis = "";
                        consultationModel.DiagCode = diagnosis;
                    }
                    else
                    {
                        diagnosis = diagnosis.Remove(diagnosis.Length - 1);
                        consultationModel.DiagCode = diagnosis;
                    }
                }
                
                _bll.saveConsultation(consultationModel);
                MessageBox.Show("Successfully saved!", "OCMS", MessageBoxButtons.OK);
                ClearAllText();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved" + ex.Message, "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor.Current = Cursors.Default;
        }

        private void lvMedicine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this medicine ?", "OCMS", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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

        private void lvDiagnosis_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this diagnosis ?", "OCMS", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                ListView.SelectedListViewItemCollection selectedItems = new ListView.SelectedListViewItemCollection(lvDiagnosis);
                selectedItems = lvDiagnosis.SelectedItems;

                if (lvDiagnosis.SelectedItems.Count != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        lvDiagnosis.Items.Remove(selectedItems[i]);
                }

            }
        }

        private void ClearAllText()
        {
            //foreach (Control c in con.Controls)
            //{
            //    if (c is TextBox)
            //        ((TextBox)c).Clear();
            //    else
            //        ClearAllText(c);
            //}

            foreach (ListViewItem itemRow in this.lvMedicine.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count - 1; i++)
                {
                    lvMedicine.Items.Remove(itemRow);
                }
            }

            foreach (ListViewItem itemRow in this.lvDiagnosis.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count - 1; i++)
                {
                    lvDiagnosis.Items.Remove(itemRow);
                }
            }

            listComplaint.Items.Clear();
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

        private void cmbDiagnosis_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAddComplaint_Click_2(object sender, EventArgs e)
        {
            listComplaint.Items.Add(cmbComplaint.Text.ToUpper());

            if (listComplaint.Items.Count >= 3)
            {

                btnAddComplaint.Enabled = false;
                MessageBox.Show("Maximum complaint encoded", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
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

        private void btnDiagnosis_Click_1(object sender, EventArgs e)
        {
            //Add items

            lvDiagnosis.View = View.Details;
            lvDiagnosis.Columns.Add("Diagnosis", 300);
            lvDiagnosis.Columns.Add("Diag_Code", 100);
            
            
            string[] arrMed = new string[2];
            ListViewItem item;

            arrMed[0] = cmbDiagnosis.Text.ToString();
            arrMed[1] = cmbDiagnosis.SelectedValue.ToString();

            item = new ListViewItem(arrMed);
            lvDiagnosis.Items.Add(item);
            lvDiagnosis.Columns.RemoveAt(1);
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

        private void lvDiagnosis_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this diagnosis ?", "OCMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                ListView.SelectedListViewItemCollection selectedItems = new ListView.SelectedListViewItemCollection(lvDiagnosis);
                selectedItems = lvDiagnosis.SelectedItems;

                if (lvDiagnosis.SelectedItems.Count != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        lvDiagnosis.Items.Remove(selectedItems[i]);
                }

            }
        }
    }
}
