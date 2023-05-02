using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class AddAgreement : Form
    {
        private AdminForm mainForm = null;
        public AddAgreement(AdminForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public AddAgreement()
        {
            InitializeComponent();
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            if (tbTenant1.Text != "" && tbTenant2.Text != "" && numTenantRoom.Value != 0 && tbAgreement.Text != "")
            {
                int room = Convert.ToInt32(numTenantRoom.Value);
                if (AccountsManager.SearchTenant(room))
                {
                    Agreement newAgreement = new Agreement(tbTenant1.Text, tbTenant2.Text, room, tbAgreement.Text);
                    if(AgreementManager.RequestAgreement(newAgreement, room))
                    {
                        MessageBox.Show("Agreement request sent!");
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Agreement error!");
                    }
                } else
                {
                    MessageBox.Show("Tenant not found!");
                }

               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
