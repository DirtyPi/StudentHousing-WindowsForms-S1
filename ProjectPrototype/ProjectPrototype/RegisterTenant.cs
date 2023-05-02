using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class RegisterTenant : Form
    {
        public RegisterTenant()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegisterTenant_Click(object sender, EventArgs e)
        {
            TenantAccount newAccount = new TenantAccount(tbUsername.Text, tbPassword.Text, tbTenantBuilding.Text, (int)numTenantRoom.Value);
            System.IO.File.AppendAllText(@"database/Tenants.txt", tbUsername.Text + Environment.NewLine);
            System.IO.File.AppendAllText(@"database/TenantPasswords.txt", tbPassword.Text + Environment.NewLine);
            System.IO.File.AppendAllText(@"database/TenantBuilding.txt", tbTenantBuilding.Text + Environment.NewLine);
            System.IO.File.AppendAllText(@"database/TenantRooms.txt", (int)numTenantRoom.Value + Environment.NewLine);
            AccountsManager.AddTenantAccount(newAccount);
            this.Hide();
        }
    }
}
