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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtPComp = new System.Windows.Forms.TextBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.btnPAddComplaint = new System.Windows.Forms.Button();
            this.listPComplaint = new System.Windows.Forms.ListBox();
            this.btnPSave = new System.Windows.Forms.Button();
            this.grpPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.Controls.Add(this.btnPSave);
            this.grpPatient.Controls.Add(this.btnPAddComplaint);
            this.grpPatient.Controls.Add(this.listPComplaint);
            this.grpPatient.Controls.Add(this.txtPComp);
            this.grpPatient.Controls.Add(this.lblComplaint);
            this.grpPatient.Controls.Add(this.textBox1);
            this.grpPatient.Controls.Add(this.lblFName);
            this.grpPatient.Controls.Add(this.txtLName);
            this.grpPatient.Controls.Add(this.label1);
            this.grpPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatient.Location = new System.Drawing.Point(3, 3);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(373, 232);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Patient Details";
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
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(92, 21);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(273, 21);
            this.txtLName.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 21);
            this.textBox1.TabIndex = 3;
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
            // txtPComp
            // 
            this.txtPComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPComp.Location = new System.Drawing.Point(92, 75);
            this.txtPComp.Name = "txtPComp";
            this.txtPComp.Size = new System.Drawing.Size(215, 21);
            this.txtPComp.TabIndex = 5;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(9, 80);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(71, 16);
            this.lblComplaint.TabIndex = 4;
            this.lblComplaint.Text = "Complaint:";
            // 
            // btnPAddComplaint
            // 
            this.btnPAddComplaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPAddComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAddComplaint.Location = new System.Drawing.Point(313, 75);
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
            this.listPComplaint.Location = new System.Drawing.Point(92, 104);
            this.listPComplaint.Name = "listPComplaint";
            this.listPComplaint.Size = new System.Drawing.Size(273, 82);
            this.listPComplaint.TabIndex = 17;
            this.listPComplaint.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPComplaint_MouseDoubleClick);
            // 
            // btnPSave
            // 
            this.btnPSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSave.Location = new System.Drawing.Point(92, 192);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(273, 32);
            this.btnPSave.TabIndex = 19;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = false;
            // 
            // frmPatientComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 244);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPComp;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPAddComplaint;
        private System.Windows.Forms.ListBox listPComplaint;
    }
}