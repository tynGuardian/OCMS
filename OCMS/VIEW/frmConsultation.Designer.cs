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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultation));
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.dtpTimeOutTime = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeIn = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnSaveConsultation = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbComplaint = new System.Windows.Forms.ComboBox();
            this.cmbMedQuantity = new System.Windows.Forms.ComboBox();
            this.lvDiagnosis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMedicine = new System.Windows.Forms.ListView();
            this.Medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.cmbDisposition = new System.Windows.Forms.ComboBox();
            this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.lblDisposition = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.listComplaint = new System.Windows.Forms.ListBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.BackColor = System.Drawing.Color.Transparent;
            this.grpPatient.Controls.Add(this.dtpTimeOutTime);
            this.grpPatient.Controls.Add(this.dtpTimeOut);
            this.grpPatient.Controls.Add(this.label2);
            this.grpPatient.Controls.Add(this.txtCompany);
            this.grpPatient.Controls.Add(this.label1);
            this.grpPatient.Controls.Add(this.txtTimeIn);
            this.grpPatient.Controls.Add(this.txtEmpName);
            this.grpPatient.Controls.Add(this.lblDate);
            this.grpPatient.Controls.Add(this.lblName);
            this.grpPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPatient.Location = new System.Drawing.Point(11, 30);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(468, 114);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
            // 
            // dtpTimeOutTime
            // 
            this.dtpTimeOutTime.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeOutTime.Location = new System.Drawing.Point(302, 90);
            this.dtpTimeOutTime.Name = "dtpTimeOutTime";
            this.dtpTimeOutTime.Size = new System.Drawing.Size(144, 22);
            this.dtpTimeOutTime.TabIndex = 14;
            this.dtpTimeOutTime.Value = new System.DateTime(2018, 4, 4, 0, 0, 0, 0);
            // 
            // dtpTimeOut
            // 
            this.dtpTimeOut.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeOut.Location = new System.Drawing.Point(120, 90);
            this.dtpTimeOut.MinimumSize = new System.Drawing.Size(5, 5);
            this.dtpTimeOut.Name = "dtpTimeOut";
            this.dtpTimeOut.Size = new System.Drawing.Size(176, 22);
            this.dtpTimeOut.TabIndex = 13;
            this.dtpTimeOut.Value = new System.DateTime(2018, 4, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time Out:";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.Enabled = false;
            this.txtCompany.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(120, 39);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(326, 22);
            this.txtCompany.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Legal Vehicle:";
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.BackColor = System.Drawing.Color.White;
            this.txtTimeIn.Enabled = false;
            this.txtTimeIn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeIn.Location = new System.Drawing.Point(120, 65);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(176, 22);
            this.txtTimeIn.TabIndex = 7;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.White;
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(120, 12);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(326, 22);
            this.txtEmpName.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Time In:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name:";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.Menu;
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(562, 12);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(145, 20);
            this.txtGender.TabIndex = 6;
            // 
            // btnSaveConsultation
            // 
            this.btnSaveConsultation.BackColor = System.Drawing.Color.White;
            this.btnSaveConsultation.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConsultation.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveConsultation.Image")));
            this.btnSaveConsultation.Location = new System.Drawing.Point(11, 2);
            this.btnSaveConsultation.Name = "btnSaveConsultation";
            this.btnSaveConsultation.Size = new System.Drawing.Size(70, 28);
            this.btnSaveConsultation.TabIndex = 21;
            this.btnSaveConsultation.Text = "&Save";
            this.btnSaveConsultation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveConsultation.UseVisualStyleBackColor = false;
            this.btnSaveConsultation.Click += new System.EventHandler(this.btnSaveConsultation_Click);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(663, 65);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(44, 20);
            this.txtAge.TabIndex = 25;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(638, 66);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 16);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "Age:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(562, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbComplaint);
            this.groupBox1.Controls.Add(this.cmbMedQuantity);
            this.groupBox1.Controls.Add(this.lvDiagnosis);
            this.groupBox1.Controls.Add(this.lvMedicine);
            this.groupBox1.Controls.Add(this.btnAddComplaint);
            this.groupBox1.Controls.Add(this.btnDiagnosis);
            this.groupBox1.Controls.Add(this.cmbDisposition);
            this.groupBox1.Controls.Add(this.cmbDiagnosis);
            this.groupBox1.Controls.Add(this.lblDiagnosis);
            this.groupBox1.Controls.Add(this.lblComplaint);
            this.groupBox1.Controls.Add(this.lblDisposition);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbMedicine);
            this.groupBox1.Controls.Add(this.listComplaint);
            this.groupBox1.Controls.Add(this.lblMed);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 367);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // cmbComplaint
            // 
            this.cmbComplaint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbComplaint.BackColor = System.Drawing.Color.White;
            this.cmbComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComplaint.FormattingEnabled = true;
            this.cmbComplaint.Location = new System.Drawing.Point(91, 21);
            this.cmbComplaint.Name = "cmbComplaint";
            this.cmbComplaint.Size = new System.Drawing.Size(293, 25);
            this.cmbComplaint.TabIndex = 41;
            // 
            // cmbMedQuantity
            // 
            this.cmbMedQuantity.BackColor = System.Drawing.Color.White;
            this.cmbMedQuantity.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedQuantity.FormattingEnabled = true;
            this.cmbMedQuantity.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbMedQuantity.Location = new System.Drawing.Point(347, 119);
            this.cmbMedQuantity.Name = "cmbMedQuantity";
            this.cmbMedQuantity.Size = new System.Drawing.Size(37, 25);
            this.cmbMedQuantity.TabIndex = 40;
            // 
            // lvDiagnosis
            // 
            this.lvDiagnosis.BackColor = System.Drawing.Color.White;
            this.lvDiagnosis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDiagnosis.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDiagnosis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDiagnosis.Location = new System.Drawing.Point(92, 284);
            this.lvDiagnosis.Name = "lvDiagnosis";
            this.lvDiagnosis.Size = new System.Drawing.Size(358, 75);
            this.lvDiagnosis.TabIndex = 38;
            this.lvDiagnosis.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Medicine";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 100;
            // 
            // lvMedicine
            // 
            this.lvMedicine.BackColor = System.Drawing.Color.White;
            this.lvMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Medicine,
            this.Quantity});
            this.lvMedicine.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMedicine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMedicine.Location = new System.Drawing.Point(92, 148);
            this.lvMedicine.Name = "lvMedicine";
            this.lvMedicine.Size = new System.Drawing.Size(358, 72);
            this.lvMedicine.TabIndex = 37;
            this.lvMedicine.UseCompatibleStateImageBehavior = false;
            // 
            // Medicine
            // 
            this.Medicine.Text = "Medicine";
            this.Medicine.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 100;
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.BackColor = System.Drawing.Color.White;
            this.btnAddComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComplaint.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComplaint.Image")));
            this.btnAddComplaint.Location = new System.Drawing.Point(390, 19);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(61, 28);
            this.btnAddComplaint.TabIndex = 39;
            this.btnAddComplaint.Text = "Add";
            this.btnAddComplaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddComplaint.UseVisualStyleBackColor = false;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click_2);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BackColor = System.Drawing.Color.White;
            this.btnDiagnosis.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.Image")));
            this.btnDiagnosis.Location = new System.Drawing.Point(390, 255);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(61, 28);
            this.btnDiagnosis.TabIndex = 36;
            this.btnDiagnosis.Text = "Add";
            this.btnDiagnosis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiagnosis.UseVisualStyleBackColor = false;
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click_1);
            // 
            // cmbDisposition
            // 
            this.cmbDisposition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDisposition.BackColor = System.Drawing.Color.White;
            this.cmbDisposition.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisposition.FormattingEnabled = true;
            this.cmbDisposition.Location = new System.Drawing.Point(92, 226);
            this.cmbDisposition.Name = "cmbDisposition";
            this.cmbDisposition.Size = new System.Drawing.Size(359, 25);
            this.cmbDisposition.TabIndex = 35;
            // 
            // cmbDiagnosis
            // 
            this.cmbDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDiagnosis.BackColor = System.Drawing.Color.White;
            this.cmbDiagnosis.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiagnosis.FormattingEnabled = true;
            this.cmbDiagnosis.Location = new System.Drawing.Point(92, 257);
            this.cmbDiagnosis.Name = "cmbDiagnosis";
            this.cmbDiagnosis.Size = new System.Drawing.Size(292, 25);
            this.cmbDiagnosis.TabIndex = 31;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(9, 259);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(74, 17);
            this.lblDiagnosis.TabIndex = 30;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(10, 24);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(85, 17);
            this.lblComplaint.TabIndex = 26;
            this.lblComplaint.Text = "Complaints:";
            // 
            // lblDisposition
            // 
            this.lblDisposition.AutoSize = true;
            this.lblDisposition.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisposition.Location = new System.Drawing.Point(9, 227);
            this.lblDisposition.Name = "lblDisposition";
            this.lblDisposition.Size = new System.Drawing.Size(84, 17);
            this.lblDisposition.TabIndex = 29;
            this.lblDisposition.Text = "Disposition:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(390, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 28);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedicine.BackColor = System.Drawing.Color.White;
            this.cmbMedicine.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(92, 119);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(187, 25);
            this.cmbMedicine.TabIndex = 32;
            // 
            // listComplaint
            // 
            this.listComplaint.BackColor = System.Drawing.Color.White;
            this.listComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listComplaint.FormattingEnabled = true;
            this.listComplaint.HorizontalScrollbar = true;
            this.listComplaint.ItemHeight = 17;
            this.listComplaint.Location = new System.Drawing.Point(91, 48);
            this.listComplaint.Name = "listComplaint";
            this.listComplaint.Size = new System.Drawing.Size(359, 55);
            this.listComplaint.TabIndex = 34;
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.Location = new System.Drawing.Point(9, 124);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(78, 17);
            this.lblMed.TabIndex = 27;
            this.lblMed.Text = "Medicines:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(285, 124);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 17);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity:";
            // 
            // frmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 524);
            this.Controls.Add(this.btnSaveConsultation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPatient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.frmConsultation_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtTimeIn;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnSaveConsultation;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTimeOut;
        private System.Windows.Forms.DateTimePicker dtpTimeOutTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbComplaint;
        private System.Windows.Forms.ComboBox cmbMedQuantity;
        private System.Windows.Forms.ListView lvDiagnosis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvMedicine;
        private System.Windows.Forms.ColumnHeader Medicine;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.Button btnDiagnosis;
        private System.Windows.Forms.ComboBox cmbDisposition;
        private System.Windows.Forms.ComboBox cmbDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Label lblDisposition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.ListBox listComplaint;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblQuantity;
    }
}