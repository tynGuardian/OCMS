using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OCMS.VIEW
{
    public partial class frmPatientComplaint : Form
    {
        public frmPatientComplaint()
        {
            InitializeComponent();
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            listPComplaint.Items.Add(txtPComp.Text);
            txtPComp.Clear();
            if (listPComplaint.Items.Count >= 3)
            {

                btnPAddComplaint.Enabled = false;
                MessageBox.Show("Maximum complaint encoded", "OCMS");
            }

            txtPComp.Focus();
        }

        private void listPComplaint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to remove this complaint ?", "OCMS", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listPComplaint);
                selectedItems = listPComplaint.SelectedItems;

                if (listPComplaint.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listPComplaint.Items.Remove(selectedItems[i]);
                }

            }
        }
    }
}
