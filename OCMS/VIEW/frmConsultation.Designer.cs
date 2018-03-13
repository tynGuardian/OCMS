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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.grpConsult = new System.Windows.Forms.GroupBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblDisposition = new System.Windows.Forms.Label();
            this.txtDisposition = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.txtDiagCode = new System.Windows.Forms.TextBox();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpPatient.SuspendLayout();
            this.grpConsult.SuspendLayout();
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
            this.grpPatient.Size = new System.Drawing.Size(442, 85);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
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
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(292, 17);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // grpConsult
            // 
            this.grpConsult.Controls.Add(this.btnAdd);
            this.grpConsult.Controls.Add(this.cmbMedicine);
            this.grpConsult.Controls.Add(this.txtDiagCode);
            this.grpConsult.Controls.Add(this.cmbDiagnosis);
            this.grpConsult.Controls.Add(this.lblDiagnosis);
            this.grpConsult.Controls.Add(this.txtDisposition);
            this.grpConsult.Controls.Add(this.lblDisposition);
            this.grpConsult.Controls.Add(this.txtQuantity);
            this.grpConsult.Controls.Add(this.label2);
            this.grpConsult.Controls.Add(this.label1);
            this.grpConsult.Controls.Add(this.txtComplaint);
            this.grpConsult.Controls.Add(this.lblComplaint);
            this.grpConsult.Location = new System.Drawing.Point(11, 113);
            this.grpConsult.Name = "grpConsult";
            this.grpConsult.Size = new System.Drawing.Size(441, 278);
            this.grpConsult.TabIndex = 1;
            this.grpConsult.TabStop = false;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(6, 27);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(78, 16);
            this.lblComplaint.TabIndex = 2;
            this.lblComplaint.Text = "Complaints:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(292, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Time In:";
            // 
            // txtComplaint
            // 
            this.txtComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplaint.Location = new System.Drawing.Point(89, 27);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(340, 73);
            this.txtComplaint.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medicines:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(327, 131);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(43, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // lblDisposition
            // 
            this.lblDisposition.AutoSize = true;
            this.lblDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisposition.Location = new System.Drawing.Point(6, 194);
            this.lblDisposition.Name = "lblDisposition";
            this.lblDisposition.Size = new System.Drawing.Size(78, 16);
            this.lblDisposition.TabIndex = 8;
            this.lblDisposition.Text = "Disposition:";
            // 
            // txtDisposition
            // 
            this.txtDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisposition.Location = new System.Drawing.Point(89, 188);
            this.txtDisposition.Name = "txtDisposition";
            this.txtDisposition.Size = new System.Drawing.Size(340, 22);
            this.txtDisposition.TabIndex = 9;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(6, 242);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(72, 16);
            this.lblDiagnosis.TabIndex = 10;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // cmbDiagnosis
            // 
            this.cmbDiagnosis.FormattingEnabled = true;
            this.cmbDiagnosis.Location = new System.Drawing.Point(89, 237);
            this.cmbDiagnosis.Name = "cmbDiagnosis";
            this.cmbDiagnosis.Size = new System.Drawing.Size(232, 21);
            this.cmbDiagnosis.TabIndex = 11;
            // 
            // txtDiagCode
            // 
            this.txtDiagCode.Location = new System.Drawing.Point(344, 237);
            this.txtDiagCode.Name = "txtDiagCode";
            this.txtDiagCode.Size = new System.Drawing.Size(85, 20);
            this.txtDiagCode.TabIndex = 12;
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(89, 131);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(167, 21);
            this.cmbMedicine.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(383, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 403);
            this.Controls.Add(this.grpConsult);
            this.Controls.Add(this.grpPatient);
            this.Name = "frmConsultation";
            this.Text = "frmConsultation";
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpConsult.ResumeLayout(false);
            this.grpConsult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpConsult;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.TextBox txtDiagCode;
        private System.Windows.Forms.ComboBox cmbDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDisposition;
        private System.Windows.Forms.Label lblDisposition;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Button btnAdd;
    }
}