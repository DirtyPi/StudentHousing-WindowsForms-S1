using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class EditAgreement : Form
    {
        string firstTenant;
        string secondTenant;
        string agreementText;
        Agreement oldAgreement;
        AdminForm mainForm = null;
        public EditAgreement(AdminForm main, Agreement agreementValue)
        {
            InitializeComponent();
            mainForm = main;
            tbAgreementText.Text = agreementValue.GetText();
            firstTenant = agreementValue.ReturnFirstTenant();
            secondTenant = agreementValue.ReturnSecondTenant();
            oldAgreement = agreementValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditAgreement_Click(object sender, EventArgs e)
        {
            //agreementText = tbAgreementText.Text;
            //Agreement newAgreement = new Agreement(firstTenant, secondTenant, agreementText);
            //AgreementManager.EditAgreement(oldAgreement, newAgreement);
            //mainForm.RefreshListbox("agreement");
            //this.Hide();
        }
    }
}
