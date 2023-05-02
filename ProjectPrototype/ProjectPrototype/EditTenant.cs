using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class EditTenant : Form
    {
        TenantAccount tenantAccount = null;
        public EditTenant(TenantAccount accountInUse)
        {
            tenantAccount = accountInUse;
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditTenant_Load(object sender, EventArgs e)
        {
            tbUsername.Text = tenantAccount.displayUser();
            tbBuilding.Text = tenantAccount.GetBuilding();
            numRoom.Value = tenantAccount.GetRoom();
        }

        private void btnDeleteTenant_Click(object sender, EventArgs e)
        {
            int id = tenantAccount.GetId();
            if (AccountsManager.RemoveTenantAccount(id))
            {
                MessageBox.Show("Tenant removed!");
                this.Hide();
            } else
            {
                MessageBox.Show("Tenant could not be removed!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tbBuilding.Text != "" && numRoom.Value != 0)
            {
                int id = tenantAccount.GetId();
                string building = tbBuilding.Text;
                int room = Convert.ToInt32(numRoom.Value);

                if(AccountsManager.UpdateTenant(id, building, room))
                {
                    MessageBox.Show("Tenant succesfully updated!");
                    this.Hide();
                } else
                {
                    MessageBox.Show("Tenant failed to update!");
                }
            }
        }
    }
}
