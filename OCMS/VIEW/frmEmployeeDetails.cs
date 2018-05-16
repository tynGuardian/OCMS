using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.Bussiness;
using System.Reflection;
using OCMS.Class;

namespace OCMS.VIEW
{
    public partial class frmEmployeeDetails : Form
    {
        EmployeeBusiness _bll = new EmployeeBusiness();
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "ColumnCheck";
            checkColumn.HeaderText = "";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            dgvEmployee.Columns.Add(checkColumn);
            dgvEmployee.DataSource = _bll.GetEmployeeDetails();
            dgvEmployee.Columns[6].Visible = false;

            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgvEmployee.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgvEmployee, true, null);
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
            
            if (dgvEmployee.CurrentCell.ColumnIndex == 0) 
            {
                dgvEmployee.BeginEdit(true);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = ValidateCheckbox();
            EmployeeBusiness empdetails = new EmployeeBusiness();
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                DataGridViewCheckBoxCell chkchecking = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    Application.DoEvents();
                    if (result == true)
                    {
                        MessageBox.Show("Please select only one reference!", "OCMS", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        empdetails.UpdateEmployeeDetails(dgvEmployee.Rows[row.Index].Cells[1].Value.ToString(), dgvEmployee.Rows[row.Index].Cells[4].Value.ToString(), dgvEmployee.Rows[row.Index].Cells[2].Value.ToString(), dgvEmployee.Rows[row.Index].Cells[3].Value.ToString(), dgvEmployee.Rows[row.Index].Cells[5].Value.ToString());
                    }
                }
            }
            MessageBox.Show("Successfully Update Employee Information!", "OCMS", MessageBoxButtons.OK);
            this.Close();
        }
        
        public bool ValidateCheckbox()
        {
            List<string> geid = new List<string>();   
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                DataGridViewCheckBoxCell chkchecking = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    geid.Add(dgvEmployee.Rows[row.Index].Cells[1].Value.ToString());
                }
            }
            if (geid.Count != geid.Distinct().Count())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmployee.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.LightGray;
        }
    }
}
