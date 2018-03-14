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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.grpPatient.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(310, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Time In:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(310, 17);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(14, 51);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 17);
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
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbDisposition
            // 
            this.cmbDisposition.FormattingEnabled = true;
            this.cmbDisposition.Location = new System.Drawing.Point(84, 230);
            this.cmbDisposition.Name = "cmbDisposition";
            this.cmbDisposition.Size = new System.Drawing.Size(338, 21);
            this.cmbDisposition.TabIndex = 18;
            // 
            // listMedicine
            // 
            this.listMedicine.FormattingEnabled = true;
            this.listMedicine.Location = new System.Drawing.Point(84, 168);
            this.listMedicine.Name = "listMedicine";
            this.listMedicine.Size = new System.Drawing.Size(337, 43);
            this.listMedicine.TabIndex = 19;
            // 
            // listDiagnosis
            // 
            this.listDiagnosis.FormattingEnabled = true;
            this.listDiagnosis.Location = new System.Drawing.Point(84, 324);
            this.listDiagnosis.Name = "listDiagnosis";
            this.listDiagnosis.Size = new System.Drawing.Size(337, 43);
            this.listDiagnosis.TabIndex = 17;
            // 
            // cmbDiagnosis
            // 
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
            this.btnAddComplaint.Location = new System.Drawing.Point(376, 32);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(46, 23);
            this.btnAddComplaint.TabIndex = 16;
            this.btnAddComplaint.Text = "Add";
            this.btnAddComplaint.UseVisualStyleBackColor = false;
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
            this.lblComplaint.Location = new System.Drawing.Point(6, 39);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(78, 16);
            this.lblComplaint.TabIndex = 2;
            this.lblComplaint.Text = "Complaints:";
            // 
            // lblDisposition
            // 
            this.lblDisposition.AutoSize = true;
            this.lblDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisposition.Location = new System.Drawing.Point(9, 231);
            this.lblDisposition.Name = "lblDisposition";
            this.lblDisposition.Size = new System.Drawing.Size(78, 16);
            this.lblDisposition.TabIndex = 8;
            this.lblDisposition.Text = "Disposition:";
            // 
            // txtComplaint
            // 
            this.txtComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplaint.Location = new System.Drawing.Point(84, 36);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(281, 22);
            this.txtComplaint.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(326, 131);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(43, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(376, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(84, 130);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(167, 21);
            this.cmbMedicine.TabIndex = 13;
            // 
            // listComplaint
            // 
            this.listComplaint.FormattingEnabled = true;
            this.listComplaint.Location = new System.Drawing.Point(84, 64);
            this.listComplaint.Name = "listComplaint";
            this.listComplaint.Size = new System.Drawing.Size(337, 43);
            this.listComplaint.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medicines:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity:";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Location = new System.Drawing.Point(7, 107);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(468, 421);
            this.tab1.TabIndex = 2;
            // 
            // frmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 531);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.grpPatient);
            this.Name = "frmConsultation";
            this.Text = "frmConsultation";
            this.Load += new System.EventHandler(this.frmConsultation_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tab1;
    }
}