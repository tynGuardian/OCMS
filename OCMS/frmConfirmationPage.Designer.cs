namespace OCMS
{
    partial class frmConfirmationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmationPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNurse = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Already have an Access? Go to login page.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNurse
            // 
            this.btnNurse.BackColor = System.Drawing.Color.Transparent;
            this.btnNurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNurse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNurse.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurse.ForeColor = System.Drawing.Color.Black;
            this.btnNurse.Location = new System.Drawing.Point(38, 102);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.Size = new System.Drawing.Size(181, 66);
            this.btnNurse.TabIndex = 2;
            this.btnNurse.Text = "NURSE";
            this.btnNurse.UseVisualStyleBackColor = false;
            this.btnNurse.Click += new System.EventHandler(this.btnNurse_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoctor.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.Black;
            this.btnDoctor.Location = new System.Drawing.Point(38, 21);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(181, 66);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "DOCTOR";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDoctor);
            this.panel1.Controls.Add(this.btnNurse);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 194);
            this.panel1.TabIndex = 1;
            // 
            // frmConfirmationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(282, 209);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirmationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmationPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNurse;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Panel panel1;
    }
}