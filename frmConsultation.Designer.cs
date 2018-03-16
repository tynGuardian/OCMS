namespace OCMS.VIEW
{
    partial class frmConsultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.txtTimeIn = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbDisposition = new System.Windows.Forms.ComboBox();
            this.listMedicine = new System.Windows.Forms.ListBox();
            this.listDiagnosis = new System.Windows.Forms.ListBox();
            this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.lblDisposition = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.listComplaint = new System.Windows.Forms.ListBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbConsultation = new System.Windows.Forms.TabControl();
            this.grpPatient.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbConsultation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.Controls.Add(this.txtTimeIn);
            this.grpPatient.Controls.Add(this.txtGender);
            this.grpPatient.Controls.Add(this.txtAge);
            this.grpPatient.Controls.Add(this.txtEmpName);
            this.grpPatient.Controls.Add(this.lblDate);
            this.grpPatient.Controls.Add(this.lblGender);
            this.grpPatient.Controls.Add(this.lblAge);
            this.grpPatient.Controls.Add(this.lblName);
            this.grpPatient.Location = new System.Drawing.Point(11, 16);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(460, 85);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTimeIn.Enabled = false;
            this.txtTimeIn.Location = new System.Drawing.Point(350, 47);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(104, 20);
            this.txtTimeIn.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.Menu;
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(120, 51);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(145, 20);
            this.txtGender.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(350, 16);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(44, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(120, 17);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(145, 20);
            this.txtEmpName.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(289, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Time In:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(1, 51);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(289, 16);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbDisposition);
            this.tabPage1.Controls.Add(this.listMedicine);
            this.tabPage1.Controls.Add(this.listDiagnosis);
            this.tabPage1.Controls.Add(this.cmbDiagnosis);
            this.tabPage1.Controls.Add(this.btnAddComplaint);
            this.tabPage1.Controls.Add(this.lblDiagnosis);
            this.tabPage1.Controls.Add(this.lblComplaint);
            this.tabPage1.Controls.Add(this.lblDisposition);
            this.tabPage1.Controls.Add(this.txtComplaint);
            this.tabPage1.Controls.Add(this.txtQuantity);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.cmbMedicine);
            this.tabPage1.Controls.Add(this.listComplaint);
            this.tabPage1.Controls.Add(this.lblMed);
            this.tabPage1.Controls.Add(this.lblQuantity);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbDisposition
            // 
            this.cmbDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisposition.FormattingEnabled = true;
            this.cmbDisposition.Location = new System.Drawing.Point(84, 253);
            this.cmbDisposition.Name = "cmbDisposition";
            this.cmbDisposition.Size = new System.Drawing.Size(338, 21);
            this.cmbDisposition.TabIndex = 18;
            // 
            // listMedicine
            // 
            this.listMedicine.FormattingEnabled = true;
            this.listMedicine.ItemHeight = 16;
            this.listMedicine.Location = new System.Drawing.Point(84, 162);
            this.listMedicine.Name = "listMedicine";
            this.listMedicine.Size = new System.Drawing.Size(337, 84);
            this.listMedicine.TabIndex = 19;
            // 
            // listDiagnosis
            // 
            this.listDiagnosis.FormattingEnabled = true;
            this.listDiagnosis.ItemHeight = 16;
            this.listDiagnosis.Location = new System.Drawing.Point(84, 315);
            this.listDiagnosis.Name = "listDiagnosis";
            this.listDiagnosis.Size = new System.Drawing.Size(337, 68);
            this.listDiagnosis.TabIndex = 17;
            // 
            // cmbDiagnosis
            // 
            this.cmbDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiagnosis.FormattingEnabled = true;
            this.cmbDiagnosis.Location = new System.Drawing.Point(84, 284);
            this.cmbDiagnosis.Name = "cmbDiagnosis";
            this.cmbDiagnosis.Size = new System.Drawing.Size(338, 21);
            this.cmbDiagnosis.TabIndex = 11;
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComplaint.Location = new System.Drawing.Point(375, 15);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(46, 23);
            this.btnAddComplaint.TabIndex = 16;
            this.btnAddComplaint.Text = "Add";
            this.btnAddComplaint.UseVisualStyleBackColor = false;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(5, 289);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(72, 16);
            this.lblDiagnosis.TabIndex = 10;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(6, 19);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(78, 16);
            this.lblComplaint.TabIndex = 2;
            this.lblComplaint.Text = "Complaints:";
            // 
            // lblDisposition
            // 
            this.lblDisposition.AutoSize = true;
            this.lblDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisposition.Location = new System.Drawing.Point(9, 254);
            this.lblDisposition.Name = "lblDisposition";
            this.lblDisposition.Size = new System.Drawing.Size(78, 16);
            this.lblDisposition.TabIndex = 8;
            this.lblDisposition.Text = "Disposition:";
            // 
            // txtComplaint
            // 
            this.txtComplaint.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplaint.Location = new System.Drawing.Point(84, 16);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(281, 22);
            this.txtComplaint.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(329, 135);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(43, 22);
            this.txtQuantity.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(376, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(84, 134);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(181, 21);
            this.cmbMedicine.TabIndex = 13;
            // 
            // listComplaint
            // 
            this.listComplaint.FormattingEnabled = true;
            this.listComplaint.ItemHeight = 16;
            this.listComplaint.Location = new System.Drawing.Point(84, 44);
            this.listComplaint.Name = "listComplaint";
            this.listComplaint.Size = new System.Drawing.Size(337, 84);
            this.listComplaint.TabIndex = 15;
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.Location = new System.Drawing.Point(12, 134);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(73, 16);
            this.lblMed.TabIndex = 4;
            this.lblMed.Text = "Medicines:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(267, 137);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 16);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // tbConsultation
            // 
            this.tbConsultation.Controls.Add(this.tabPage1);
            this.tbConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsultation.Location = new System.Drawing.Point(7, 107);
            this.tbConsultation.Name = "tbConsultation";
            this.tbConsultation.SelectedIndex = 0;
            this.tbConsultation.Size = new System.Drawing.Size(468, 421);
            this.tbConsultation.TabIndex = 2;
            // 
            // frmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 531);
            this.Controls.Add(this.tbConsultation);
            this.Controls.Add(this.grpPatient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.frmConsultation_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbConsultation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbDisposition;
        private System.Windows.Forms.ListBox listMedicine;
        private System.Windows.Forms.ListBox listDiagnosis;
        private System.Windows.Forms.ComboBox cmbDiagnosis;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Label lblDisposition;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.ListBox listComplaint;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TabControl tbConsultation;
        private System.Windows.Forms.TextBox txtTimeIn;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEmpName;
    }
}