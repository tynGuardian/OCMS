namespace OCMS.VIEW
{
    partial class frmPatientComplaint
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
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPAddComplaint = new System.Windows.Forms.Button();
            this.listPComplaint = new System.Windows.Forms.ListBox();
            this.txtPComp = new System.Windows.Forms.TextBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpConsent = new System.Windows.Forms.GroupBox();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.grpPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.Controls.Add(this.cmbCompany);
            this.grpPatient.Controls.Add(this.label2);
            this.grpPatient.Controls.Add(this.chkAgree);
            this.grpPatient.Controls.Add(this.grpConsent);
            this.grpPatient.Controls.Add(this.btnPSave);
            this.grpPatient.Controls.Add(this.btnPAddComplaint);
            this.grpPatient.Controls.Add(this.listPComplaint);
            this.grpPatient.Controls.Add(this.txtPComp);
            this.grpPatient.Controls.Add(this.lblComplaint);
            this.grpPatient.Controls.Add(this.txtFName);
            this.grpPatient.Controls.Add(this.lblFName);
            this.grpPatient.Controls.Add(this.txtLName);
            this.grpPatient.Controls.Add(this.label1);
            this.grpPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatient.Location = new System.Drawing.Point(3, 3);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(373, 356);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Patient Details";
            // 
            // btnPSave
            // 
            this.btnPSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSave.Location = new System.Drawing.Point(92, 236);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(273, 32);
            this.btnPSave.TabIndex = 19;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = false;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPAddComplaint
            // 
            this.btnPAddComplaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPAddComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAddComplaint.Location = new System.Drawing.Point(313, 113);
            this.btnPAddComplaint.Name = "btnPAddComplaint";
            this.btnPAddComplaint.Size = new System.Drawing.Size(52, 23);
            this.btnPAddComplaint.TabIndex = 18;
            this.btnPAddComplaint.Text = "Add";
            this.btnPAddComplaint.UseVisualStyleBackColor = false;
            this.btnPAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);
            // 
            // listPComplaint
            // 
            this.listPComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPComplaint.FormattingEnabled = true;
            this.listPComplaint.HorizontalScrollbar = true;
            this.listPComplaint.Location = new System.Drawing.Point(92, 148);
            this.listPComplaint.Name = "listPComplaint";
            this.listPComplaint.Size = new System.Drawing.Size(273, 82);
            this.listPComplaint.TabIndex = 17;
            this.listPComplaint.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPComplaint_MouseDoubleClick);
            // 
            // txtPComp
            // 
            this.txtPComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPComp.Location = new System.Drawing.Point(92, 113);
            this.txtPComp.Name = "txtPComp";
            this.txtPComp.Size = new System.Drawing.Size(215, 22);
            this.txtPComp.TabIndex = 5;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(9, 118);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(71, 16);
            this.lblComplaint.TabIndex = 4;
            this.lblComplaint.Text = "Complaint:";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(92, 48);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(273, 22);
            this.txtFName.TabIndex = 3;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(9, 53);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(76, 16);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name:";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(92, 21);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(273, 22);
            this.txtLName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // grpConsent
            // 
            this.grpConsent.Location = new System.Drawing.Point(4, 274);
            this.grpConsent.Name = "grpConsent";
            this.grpConsent.Size = new System.Drawing.Size(364, 71);
            this.grpConsent.TabIndex = 20;
            this.grpConsent.TabStop = false;
            this.grpConsent.Text = "Consent";
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Location = new System.Drawing.Point(65, 246);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(15, 14);
            this.chkAgree.TabIndex = 21;
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.CheckStateChanged += new System.EventHandler(this.chkAgree_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Company:";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(92, 79);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(273, 24);
            this.cmbCompany.TabIndex = 23;
            // 
            // frmPatientComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 366);
            this.Controls.Add(this.grpPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatientComplaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Complaint";
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPComp;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPAddComplaint;
        private System.Windows.Forms.ListBox listPComplaint;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.GroupBox grpConsent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCompany;
    }
}