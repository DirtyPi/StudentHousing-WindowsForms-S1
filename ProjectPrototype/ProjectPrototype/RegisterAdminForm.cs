using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class RegisterAdminForm : Form
    {
        public RegisterAdminForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AdminAccount newAccount = new AdminAccount(tbUsername.Text, tbPassword.Text);
            System.IO.File.AppendAllText(@"database/Admins.txt", tbUsername.Text + Environment.NewLine);
            System.IO.File.AppendAllText(@"database/AdminPasswords.txt", tbPassword.Text + Environment.NewLine);
            AccountsManager.AddAdminAccount(newAccount);
            this.Hide();
        }
    }
}
