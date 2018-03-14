using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.Bussiness;
using OCMS.MODEL;

namespace OCMS
{
    public partial class frmOMList : Form
    {

        public frmOMList()
        {
            InitializeComponent();
        }

        private static frmOMList m_OMList;
        public static frmOMList GetChildInstance()
        {
            if (m_OMList == null) //if not created yet, Create an instance
                m_OMList = new frmOMList();
            return m_OMList;  //just created or created earlier.Return it
        }

        private void frmOMList_Load(object sender, EventArgs e)
        {

            MemberBussiness _bll = new MemberBussiness();
            dgvMember.DataSource = _bll.GetMember().ToList();

        }
    }
}
