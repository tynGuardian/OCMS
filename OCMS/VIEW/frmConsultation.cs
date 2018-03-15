using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.MODEL;

namespace OCMS.VIEW
{
    public partial class frmConsultation : Form
    {
        private string membercode;
        public frmConsultation(MemberModel model)
        {
            InitializeComponent();
            txtEmpName.Text = model.MemberCode;
            txtAge.Text = model.Age;
            txtGender.Text = model.Gender;
            txtTimeIn.Text = DateTime.Now.ToString("MM/dd/yyyy");
            membercode = model.MemberCode;
        }

        private void frmConsultation_Load(object sender, EventArgs e)
        {

        }
    }
}
