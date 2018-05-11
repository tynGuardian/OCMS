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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientComplaint));
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbMedQuantity = new System.Windows.Forms.ComboBox();
            this.lvMedicine = new System.Windows.Forms.ListView();
            this.Medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.txtGEID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPSave = new System.Windows.Forms.Button();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.cmbComplaint = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpConsent = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPAddComplaint = new System.Windows.Forms.Button();
            this.listPComplaint = new System.Windows.Forms.ListBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.grpPatient.SuspendLayout();
            this.grpConsent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.BackColor = System.Drawing.Color.Transparent;
            this.grpPatient.Controls.Add(this.button1);
            this.grpPatient.Controls.Add(this.lblQuantity);
            this.grpPatient.Controls.Add(this.cmbMedQuantity);
            this.grpPatient.Controls.Add(this.lvMedicine);
            this.grpPatient.Controls.Add(this.btnAdd);
            this.grpPatient.Controls.Add(this.cmbMedicine);
            this.grpPatient.Controls.Add(this.lblMed);
            this.grpPatient.Controls.Add(this.txtGEID);
            this.grpPatient.Controls.Add(this.label3);
            this.grpPatient.Controls.Add(this.btnPSave);
            this.grpPatient.Controls.Add(this.chkAgree);
            this.grpPatient.Controls.Add(this.cmbComplaint);
            this.grpPatient.Controls.Add(this.cmbCompany);
            this.grpPatient.Controls.Add(this.label2);
            this.grpPatient.Controls.Add(this.grpConsent);
            this.grpPatient.Controls.Add(this.btnPAddComplaint);
            this.grpPatient.Controls.Add(this.listPComplaint);
            this.grpPatient.Controls.Add(this.lblComplaint);
            this.grpPatient.Controls.Add(this.txtFullName);
            this.grpPatient.Controls.Add(this.label1);
            this.grpPatient.Controls.Add(this.shapeContainer1);
            this.grpPatient.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatient.Location = new System.Drawing.Point(9, 10);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(500, 619);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Patient Details";
            this.grpPatient.Enter += new System.EventHandler(this.grpPatient_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(250, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(305, 233);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 20);
            this.lblQuantity.TabIndex = 32;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cmbMedQuantity
            // 
            this.cmbMedQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedQuantity.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedQuantity.FormattingEnabled = true;
            this.cmbMedQuantity.Location = new System.Drawing.Point(377, 232);
            this.cmbMedQuantity.Name = "cmbMedQuantity";
            this.cmbMedQuantity.Size = new System.Drawing.Size(37, 24);
            this.cmbMedQuantity.TabIndex = 7;
            this.cmbMedQuantity.SelectedIndexChanged += new System.EventHandler(this.cmbMedQuantity_SelectedIndexChanged);
            this.cmbMedQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMedQuantity_KeyPress);
            // 
            // lvMedicine
            // 
            this.lvMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Medicine,
            this.Quantity});
            this.lvMedicine.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMedicine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMedicine.Location = new System.Drawing.Point(111, 260);
            this.lvMedicine.Name = "lvMedicine";
            this.lvMedicine.Size = new System.Drawing.Size(370, 92);
            this.lvMedicine.TabIndex = 30;
            this.lvMedicine.UseCompatibleStateImageBehavior = false;
            this.lvMedicine.DoubleClick += new System.EventHandler(this.lvMedicine_DoubleClick);
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(420, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicine.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(111, 232);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(188, 24);
            this.cmbMedicine.TabIndex = 6;
            this.cmbMedicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMedicine_KeyPress);
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.Location = new System.Drawing.Point(6, 233);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(77, 20);
            this.lblMed.TabIndex = 27;
            this.lblMed.Text = "Medicines:";
            // 
            // txtGEID
            // 
            this.txtGEID.AcceptsTab = true;
            this.txtGEID.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGEID.Location = new System.Drawing.Point(112, 42);
            this.txtGEID.Name = "txtGEID";
            this.txtGEID.Size = new System.Drawing.Size(207, 21);
            this.txtGEID.TabIndex = 0;
            this.txtGEID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGEID_KeyPress);
            this.txtGEID.Leave += new System.EventHandler(this.txtGEID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Geid:";
            // 
            // btnPSave
            // 
            this.btnPSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSave.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSave.Image = ((System.Drawing.Image)(resources.GetObject("btnPSave.Image")));
            this.btnPSave.Location = new System.Drawing.Point(157, 581);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(86, 32);
            this.btnPSave.TabIndex = 10;
            this.btnPSave.Text = "Save";
            this.btnPSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPSave.UseVisualStyleBackColor = false;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Location = new System.Drawing.Point(130, 590);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(15, 14);
            this.chkAgree.TabIndex = 9;
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.CheckStateChanged += new System.EventHandler(this.chkAgree_CheckStateChanged);
            // 
            // cmbComplaint
            // 
            this.cmbComplaint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbComplaint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComplaint.FormattingEnabled = true;
            this.cmbComplaint.Location = new System.Drawing.Point(112, 127);
            this.cmbComplaint.Name = "cmbComplaint";
            this.cmbComplaint.Size = new System.Drawing.Size(290, 24);
            this.cmbComplaint.TabIndex = 4;
            this.cmbComplaint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbComplaint_KeyPress);
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompany.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(112, 97);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(369, 24);
            this.cmbCompany.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Legal Vehicle:";
            // 
            // grpConsent
            // 
            this.grpConsent.Controls.Add(this.richTextBox1);
            this.grpConsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpConsent.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsent.Location = new System.Drawing.Point(10, 353);
            this.grpConsent.Name = "grpConsent";
            this.grpConsent.Size = new System.Drawing.Size(471, 222);
            this.grpConsent.TabIndex = 20;
            this.grpConsent.TabStop = false;
            this.grpConsent.Text = "Consent";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(450, 190);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnPAddComplaint
            // 
            this.btnPAddComplaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPAddComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAddComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAddComplaint.Image = ((System.Drawing.Image)(resources.GetObject("btnPAddComplaint.Image")));
            this.btnPAddComplaint.Location = new System.Drawing.Point(420, 127);
            this.btnPAddComplaint.Name = "btnPAddComplaint";
            this.btnPAddComplaint.Size = new System.Drawing.Size(61, 28);
            this.btnPAddComplaint.TabIndex = 5;
            this.btnPAddComplaint.Text = "Add";
            this.btnPAddComplaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPAddComplaint.UseVisualStyleBackColor = false;
            this.btnPAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);
            // 
            // listPComplaint
            // 
            this.listPComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPComplaint.FormattingEnabled = true;
            this.listPComplaint.HorizontalScrollbar = true;
            this.listPComplaint.ItemHeight = 16;
            this.listPComplaint.Location = new System.Drawing.Point(112, 159);
            this.listPComplaint.Name = "listPComplaint";
            this.listPComplaint.Size = new System.Drawing.Size(369, 68);
            this.listPComplaint.TabIndex = 17;
            this.listPComplaint.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPComplaint_MouseDoubleClick);
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(6, 127);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(84, 20);
            this.lblComplaint.TabIndex = 4;
            this.lblComplaint.Text = "Complaints:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(112, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(369, 21);
            this.txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(494, 594);
            this.shapeContainer1.TabIndex = 34;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleShape1.BackgroundImage")));
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.SkyBlue;
            this.rectangleShape1.FillColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(108, 19);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(208, 22);
            // 
            // frmPatientComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 637);
            this.Controls.Add(this.grpPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatientComplaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPatientComplaint_FormClosing);
            this.Load += new System.EventHandler(this.frmPatientComplaint_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpConsent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPAddComplaint;
        private System.Windows.Forms.ListBox listPComplaint;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.GroupBox grpConsent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.ComboBox cmbComplaint;
        private System.Windows.Forms.TextBox txtGEID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedQuantity;
        private System.Windows.Forms.ListView lvMedicine;
        private System.Windows.Forms.ColumnHeader Medicine;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}