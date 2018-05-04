using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace OCMS.VIEW
{
    
    public partial class frmDatabaseSettings : Form
    {
        string user = string.Empty;
        string password = string.Empty;
        string servername = string.Empty;
        string dbname = string.Empty;
        public frmDatabaseSettings()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.ServerName = txtServer.Text;
            Properties.Settings.Default.DatabaseName = txtDatabase.Text;
            Properties.Settings.Default.Save();

            DBResource newConnection = new DBResource();

            if (newConnection.IsAvailable(newConnection.connectionString.ToString()))
            {
                MessageBox.Show("Database Settings successfully change.", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot find database server.", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor.Current = Cursors.Default;
        }

        private void frmDatabaseSettings_Load(object sender, EventArgs e)
        {
            user = Properties.Settings.Default.User;
            password = Properties.Settings.Default.Password;
            servername = Properties.Settings.Default.ServerName;
            dbname = Properties.Settings.Default.DatabaseName;

            loadfields();
        }

        private void loadfields()
        {
            txtUser.Text = user;
            txtPassword.Text = password;
            txtServer.Text = servername;
            txtDatabase.Text = dbname;
        }

        private void frmDatabaseSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChange_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChange_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChange_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChange_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChange_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
