using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class LoginPage : Form
    {
        AdminForm f1 = null;
        List<AdminAccount> adminAccountList = AccountsManager.ReturnAdminAccounts();
        List<TenantAccount> tenantAccountList = AccountsManager.ReturnTenantAccounts();
        public LoginPage()
        {
            InitializeComponent();
            loadDatabaseToObj();
        }

        private void loadDatabaseToObj()
        {
            List<string> tempAdmin = System.IO.File.ReadLines(@"database/Admins.txt").ToList();
            List<string> tempAdminPasswords = System.IO.File.ReadLines(@"database/AdminPasswords.txt").ToList();

            for (int i = 0; i < tempAdmin.Count; i++)
            {
                adminAccountList.Add(new AdminAccount(tempAdmin[i], tempAdminPasswords[i]));
            }

            List<string> tempUser = System.IO.File.ReadLines(@"database/Tenants.txt").ToList();
            List<string> tempUserPasswords = System.IO.File.ReadLines(@"database/TenantPasswords.txt").ToList();
            List<string> tempbuildin = System.IO.File.ReadLines(@"database/TenantBuilding.txt").ToList();
            List<string> temproom = System.IO.File.ReadLines(@"database/TenantRooms.txt").ToList();

            for (int i = 0; i < tempUser.Count; i++)
            {
                tenantAccountList.Add(new TenantAccount(tempUser[i], tempUserPasswords[i], tempbuildin[i], Convert.ToInt32(temproom[i])));
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool foundTenant = false;
            bool foundAdmin = false;
            string welcomeMsg = "";
            if(rbAdmin.Checked)
            {
                foreach (AdminAccount account in adminAccountList)
                {

                    if (account.VerifyAccount(tbUsername.Text, tbPassword.Text) == true)
                    {
                        foundAdmin = true;
                    }
                    
                }
                if(foundAdmin == true)
                {
                    f1 = new AdminForm();
                    f1.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("User not found!");
                }

            } else if (rbTenant.Checked)
            {
                foreach (TenantAccount account in tenantAccountList)
                {

                    if (account.VerifyAccount(tbUsername.Text, tbPassword.Text) == true)
                    {
                        foundTenant = true;
                        welcomeMsg = account.displayUser();
                    }
                   
                }
                if (foundTenant == true)
                {
                    TenantForm f2 = new TenantForm(welcomeMsg);
                    f2.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterTenant_Click(object sender, EventArgs e)
        {
            RegisterTenant registerTenantForm = new RegisterTenant();
            registerTenantForm.Show();
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            RegisterAdminForm registerAdmin = new RegisterAdminForm();
            registerAdmin.Show();
        }
    }
}
