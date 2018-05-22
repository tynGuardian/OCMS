using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCMS.DAL;
using OCMS.MODEL;

namespace OCMS.VIEW
{
    public partial class frmUserList : Form
    {
        UsersDataAccess usersdata = new UsersDataAccess();
        string usercode;
        int active;
        public frmUserList()
        {
            InitializeComponent();
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void dgvUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.Default;

            //DISABLE CLICKING THE HEADER CODE
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvUserList.Rows[e.RowIndex];
            //END

            if (dgvUserList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                UsersModel UserList = new UsersModel();

                if (dgvUserList.Rows[e.RowIndex].Cells[2].Value.ToString() != null)
                {
                    UserList.lastname = dgvUserList.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
                    UserList.firstname = dgvUserList.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "";
                    UserList.middlename = dgvUserList.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "";
                    UserList.usercode = dgvUserList.Rows[e.RowIndex].Cells[3].Value.ToString() ?? "";
                    UserList.licenseno = dgvUserList.Rows[e.RowIndex].Cells[6].Value.ToString() ?? "";
                    UserList.privilege = dgvUserList.Rows[e.RowIndex].Cells[7].Value.ToString() ?? "";
                }

                frmUsersInformation objfrmUsersInformation = new frmUsersInformation(UserList);
                objfrmUsersInformation.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text.Trim() != "" || string.IsNullOrWhiteSpace(textSearch.Text) == false)
            {
                if (btnSearch.Text == "Search")
                {
                    btnSearch.Text = "Refresh";
                    LoadInfo();
                }
                else
                {
                    btnSearch.Text = "Search";
                    textSearch.Text = "";
                    LoadInfo();
                }
            }
        }
        public void LoadInfo()
        {
            dgvUserList.DataSource = usersdata.getUsersList(textSearch.Text);
            dgvUserList.Columns[4].Visible = false;
            dgvUserList.Columns[5].Visible = false;
            dgvUserList.Columns[6].Visible = false;
            dgvUserList.Columns[7].Visible = false;
            dgvUserList.Columns[8].Visible = false;

            dgvUserList.Columns[0].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvUserList.Columns[1].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvUserList.Columns[2].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvUserList.Columns[3].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
            dgvUserList.Columns[9].HeaderCell.Style.Font = new Font("Franklin Gothic Book", 10, FontStyle.Bold);
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            DialogResult msg;
            bool result;
            if (active == 1)
            {
                msg = MessageBox.Show("Are you sure you want to Activate this account ?", "OCMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                msg = MessageBox.Show("Are you sure you want to Deactivate this account ?", "OCMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
              
            if (msg == DialogResult.Yes)
            {
                UsersModel UserList = new UsersModel();
                UserList.usercode = usercode;
                UserList.active = active;

                result = usersdata.UserActivation(UserList);
                if (result == true)
                {
                    if (active == 1)
                    {
                        MessageBox.Show("Successfully Activated the account", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Successfully Deactivated the account", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadInfo();
                }
            }
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUserList.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.LightGray;

            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvUserList.Rows[e.RowIndex];
            //END

            if (dgvUserList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                if ((int)dgvUserList.Rows[e.RowIndex].Cells[8].Value == 1)
                {
                    btnDeactivate.Text = "Deactivate User";
                    usercode = dgvUserList.Rows[e.RowIndex].Cells[3].Value.ToString() ?? "";
                    active = 0;
                }
                else
                {
                    btnDeactivate.Text = "Activate User";
                    usercode = dgvUserList.Rows[e.RowIndex].Cells[3].Value.ToString() ?? "";
                    active = 1;
                }
            }
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != "")
            {
                btnSearch.Text = "Search";
            }
        }
    }
}
