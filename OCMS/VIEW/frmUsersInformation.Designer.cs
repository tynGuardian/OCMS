namespace OCMS.VIEW
{
    partial class frmUsersInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersInformation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPrivilege = new System.Windows.Forms.CheckBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textCpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textLnumber = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textMname = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkPrivilege);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCpassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textUsername);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textLnumber);
            this.groupBox1.Controls.Add(this.textLname);
            this.groupBox1.Controls.Add(this.textMname);
            this.groupBox1.Controls.Add(this.textFname);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 347);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // chkPrivilege
            // 
            this.chkPrivilege.AutoSize = true;
            this.chkPrivilege.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilege.Location = new System.Drawing.Point(13, 285);
            this.chkPrivilege.Name = "chkPrivilege";
            this.chkPrivilege.Size = new System.Drawing.Size(275, 21);
            this.chkPrivilege.TabIndex = 43;
            this.chkPrivilege.Text = "Give access to create/manage user accounts";
            this.chkPrivilege.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            this.cmbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRole.BackColor = System.Drawing.Color.White;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.cmbRole.Location = new System.Drawing.Point(158, 172);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(156, 24);
            this.cmbRole.TabIndex = 28;
            this.cmbRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRole_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(10, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 14);
            this.label14.TabIndex = 42;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Access Role:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(230, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 29);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(10, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Field with asterisk(*) is required.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(10, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 14);
            this.label13.TabIndex = 40;
            this.label13.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(10, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 14);
            this.label9.TabIndex = 34;
            this.label9.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(10, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 14);
            this.label12.TabIndex = 38;
            this.label12.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Last Name: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(10, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 14);
            this.label11.TabIndex = 37;
            this.label11.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(10, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 14);
            this.label10.TabIndex = 35;
            this.label10.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Middle Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(140, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "License Number:";
            // 
            // textCpassword
            // 
            this.textCpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCpassword.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCpassword.Location = new System.Drawing.Point(158, 257);
            this.textCpassword.Name = "textCpassword";
            this.textCpassword.PasswordChar = '*';
            this.textCpassword.Size = new System.Drawing.Size(156, 21);
            this.textCpassword.TabIndex = 32;
            this.textCpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCpassword_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "User Name:";
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(158, 230);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(156, 21);
            this.textPassword.TabIndex = 31;
            this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassword_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password:";
            // 
            // textUsername
            // 
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(158, 202);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(156, 21);
            this.textUsername.TabIndex = 29;
            this.textUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUsername_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Confirm Password:";
            // 
            // textLnumber
            // 
            this.textLnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLnumber.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLnumber.Location = new System.Drawing.Point(158, 145);
            this.textLnumber.Name = "textLnumber";
            this.textLnumber.Size = new System.Drawing.Size(156, 21);
            this.textLnumber.TabIndex = 25;
            this.textLnumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textLnumber_KeyDown);
            this.textLnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLnumber_KeyPress);
            // 
            // textLname
            // 
            this.textLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLname.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLname.Location = new System.Drawing.Point(158, 61);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(156, 21);
            this.textLname.TabIndex = 19;
            this.textLname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textLname_KeyDown);
            // 
            // textMname
            // 
            this.textMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMname.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMname.Location = new System.Drawing.Point(158, 117);
            this.textMname.Name = "textMname";
            this.textMname.Size = new System.Drawing.Size(156, 21);
            this.textMname.TabIndex = 24;
            this.textMname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMname_KeyDown);
            // 
            // textFname
            // 
            this.textFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFname.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFname.Location = new System.Drawing.Point(158, 89);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(156, 21);
            this.textFname.TabIndex = 22;
            this.textFname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFname_KeyDown);
            // 
            // frmUsersInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 368);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsersInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsersInformation";
            this.Load += new System.EventHandler(this.frmUsersInformation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsersInformation_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLnumber;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.TextBox textMname;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.CheckBox chkPrivilege;
    }
}