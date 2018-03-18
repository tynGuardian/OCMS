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
        //TO DO DISABLE ENABLE DIAGNOSIS IF NOT DOCTOR
        bool isRole = false;

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

            txtComplaint.Focus();
        }

        private void listComplaint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this complaint ?", "OCMS", MessageBoxButtons.YesNo);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add items

            lvMedicine.View = View.Details;
            lvMedicine.Columns.Add("Medicine", 300);
            lvMedicine.Columns.Add("Quantity", 100);

            string[] arrMed = new string[2];
            ListViewItem item;

            arrMed[0] = cmbMedicine.Text.ToString();
            arrMed[1] = txtMedQuantity.Text.ToString();

            item = new ListViewItem(arrMed);
            lvMedicine.Items.Add(item);
            txtMedQuantity.Clear();

        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
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

        }

        private void btnSaveConsultation_Click(object sender, EventArgs e)
        {
            try
            {

                ConsultationModel consultationModel = new ConsultationModel();

                consultationModel.ConsultatonId = Guid.NewGuid().ToString();
                consultationModel.MemberCode = membercode;
                consultationModel.TimeIn = Convert.ToDateTime(txtTimeIn.Text);
                consultationModel.TimeOut = DateTime.Now;
                consultationModel.Disposition = cmbDisposition.Text.ToString();

                //getting listBoxComplaint items
                string complaints = "";
                foreach (var item in listComplaint.Items)
                {
                    complaints += item.ToString() + ",";
                }
                complaints = complaints.Remove(complaints.Length - 1);
                consultationModel.Complaints = complaints;

                //getting listViewMed items
                string medicine = "";
                foreach (ListViewItem itemRow in this.lvMedicine.Items)
                {
                    for (int i = 0; i < itemRow.SubItems.Count - 1; i++)
                    {
                        medicine += itemRow.Text + "," + itemRow.SubItems[1].Text + ",";
                    }
                }
                medicine = medicine.Remove(medicine.Length - 1);
                consultationModel.Medicine = medicine;

                //getting listViewMed items
                string diagnosis = "";
                foreach (ListViewItem itemRow in this.lvDiagnosis.Items)
                {
                    for (int i = 0; i < itemRow.SubItems.Count - 1; i++)
                    {
                        diagnosis += itemRow.SubItems[1].Text + ",";
                    }
                }
                diagnosis = diagnosis.Remove(diagnosis.Length - 1);
                consultationModel.DiagCode = diagnosis;

                consultationModel.CreatedBy = "knguardian";
                consultationModel.CreatedDate = DateTime.Now;

                _bll.saveConsultation(consultationModel);
                MessageBox.Show("Successfully saved!", "OCMS");
                ClearAllText();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved" + ex.Message, "OCMS");
                return;
            }

        }

        private void lvMedicine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this medicine ?", "OCMS", MessageBoxButtons.YesNo);

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

        private void listDiagnosis_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this diagnosis ?", "OCMS", MessageBoxButtons.YesNo);

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
    }
}
