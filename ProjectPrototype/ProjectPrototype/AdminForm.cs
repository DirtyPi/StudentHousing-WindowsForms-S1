using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPrototype
{

    public partial class AdminForm : Form
    {
        List<TenantAccount> tenantList = null;
        List<Complaint> compList = null;
        List<Agreement> agreementList = null;
        HouseRules newHouseRule = new HouseRules();
        int n = 0;
        public AdminForm()
        {
            InitializeComponent();
            loadRules();

        }

        private void loadRules()
        {
            lbHouseRules.Items.Clear();
            List<string> temp = HouseRules.GetHouseRules();
            foreach (string a in temp)
            {
                lbHouseRules.Items.Add(a);
            }
        }


        // Method to go over HouseRule elements dynamically and add them to rules listbox
        public void IterateOverRules(HouseRules currentRules)
        {
            foreach (string rule in HouseRules.GetHouseRules())
            {
                if(!lbHouseRules.Items.Contains(rule))
                lbHouseRules.Items.Add(rule);
            }

        }

        // Method to go over the list of tenants in the tenantManager and check if they
        // should be added to the listbox
        //public void IterateOverTenants(List<Tenant> tenants)
        //{
            
        //    foreach(Tenant tenant in tenants)
        //    {
        //        string tenantItem = tenant.displayValue();
        //        if (!lbTenant.Items.Contains(tenantItem))
        //        {
        //            lbTenant.Items.Add(tenantItem);
        //            tenantList.Add(tenant);
        //            n++;
        //        }
        //    }
        //}

        public void DeleteRule(string ruleToDelete)
        {
          for(int i=lbHouseRules.Items.Count - 1; i>=0; --i)
            {
                if (lbHouseRules.Items[i].ToString().Contains(ruleToDelete))
                {
                    lbHouseRules.Items.RemoveAt(i);
                } else
                {
                    MessageBox.Show("Rule not found!");
                }
            }
        }


        public void UpdateRule(string ruleToUpdate, string newRule)
        {
            for (int i = lbHouseRules.Items.Count - 1; i >= 0; --i)
            {
                if (lbHouseRules.Items[i].ToString().Contains(ruleToUpdate))
                {
                    lbHouseRules.Items[i] = newRule;
                }
            }
        }

        public void DeleteTenant(string tenant)
        {
            for(int i = lbTenant.Items.Count - 1; i>=0; --i)
            {
                if (lbTenant.Items[i].ToString().Contains(tenant))
                {
                    lbTenant.Items.RemoveAt(i);
                    tenantList.RemoveAt(i);
                }
            }
        }

        //public void UpdateTenant(string oldTenant, string newTenant, Tenant newTenantObject)
        //{
        //    for (int i = lbTenant.Items.Count - 1; i >= 0; --i)
        //    {
        //        if (lbTenant.Items[i].ToString().Contains(oldTenant))
        //        {
        //            lbTenant.Items[i] = newTenant;
        //            tenantList[i] = newTenantObject;
        //        }
        //    }
        //}

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Initialize a new addRuleForm with the current form 
            // and a houserule object passed as parameters
           var addHouseRule = new AddRuleForm(this, newHouseRule);
           addHouseRule.Show();
        }

        private void btnEditForm_Click(object sender, EventArgs e)
        {
            if(lbHouseRules.SelectedIndex != -1)
            {
                var editHouseRule = new EditRuleForm(this, lbHouseRules.SelectedItem.ToString());
                editHouseRule.Show();
            } else
            {
                MessageBox.Show("Please select a rule to edit!");
            }
        }

        //private void btnAddTenant_Click(object sender, EventArgs e)
        //{
        //    var addTenant = new AddTenantForm(this);
        //    addTenant.Show();
        //}

        //private void btnEditTenant_Click(object sender, EventArgs e)
        //{
        //    if(lbTenant.SelectedIndex != -1)
        //    {
                
        //        var selectedTenant = tenantList[lbTenant.SelectedIndex];
        //        var editTenant = new EditTenantForm(this, selectedTenant);
        //        editTenant.Show();
        //    } else
        //    {
        //        MessageBox.Show("Please select a tenant to edit!");
        //    }
        //}

        public void RefreshButtonClick()
        {
            this.Refresh();
        }

        public void RefreshListbox(string keyword)
        {
            if(keyword == "complaint")
            {
                lbComplaints.Items.Clear();
                compList = ComplaintManager.ReturnComplaintList();

                foreach(Complaint c in compList)
                {
                    lbComplaints.Items.Add(c.GetInfo());
                }
            } else if (keyword == "agreement")
            {
                lbAgreements.Items.Clear();
                agreementList = AgreementManager.ReturnAgreementList();

                foreach(Agreement a in agreementList)
                {
                    lbAgreements.Items.Add(a.GetInfo());
                }
            } else if (keyword == "tenant")
            {
                lbTenant.Items.Clear();
                tenantList = AccountsManager.ReturnTenantAccounts();

                foreach(TenantAccount t in tenantList)
                {
                    lbTenant.Items.Add(t.GetUserInfo());
                }
            } else if (keyword == "chore")
            {
                lbChores.Items.Clear();
                foreach(Chore c in ChoreManager.ReturnChoreList())
                {
                    lbChores.Items.Add(c.GetInfo());
                }
            }
        }

        private void btnMarkResolved_Click(object sender, EventArgs e)
        {
            //if(lbComplaints.SelectedIndex != -1)
            //{
            //    int i = lbComplaints.SelectedIndex;
            //    int idOfComplaint = compList[i].GetId();

            //    foreach (Complaint c in compList)
            //    {
            //        if (c.GetId() == idOfComplaint)
            //        {
            //            c.MarkAsResolved();
            //        }
            //    }

            //    ComplaintManager.UpdateList(compList);
            //    this.RefreshListbox("complaint");
            //}

            int id = Convert.ToInt32(numComplaintID.Value);
            if (ComplaintManager.MarkComplaint(id))
            {
                MessageBox.Show("Complaint updated");
                RefreshListbox("complaint");
            } else
            {
                MessageBox.Show("Complaint Id could not be found!");
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void btnAddAgreement_Click(object sender, EventArgs e)
        //{
        //    AddAgreement newAgreementForm = new AddAgreement(this);
        //    newAgreementForm.Show();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //if(lbAgreements.SelectedIndex != -1)
            //{
            //    int x = lbAgreements.SelectedIndex;
            //    int idOfComplaint = agreementList[x].GetId();
            //    List<Agreement> listToRemove = new List<Agreement>();

            //    foreach (Agreement a in agreementList)
            //    {
            //        if (a.GetId() == idOfComplaint)
            //        {
            //            listToRemove.Add(a);
            //        }
            //    }

            //    if (listToRemove.Count != 0)
            //    {
            //        foreach (Agreement a in listToRemove)
            //        {
            //            agreementList.Remove(a);
            //            AgreementManager.RemoveAgreement(a);
            //        }

            //        this.RefreshListbox("agreement");
            //    }
            //}

            int id = Convert.ToInt32(numAgreementId.Value);
            if (AgreementManager.RemoveAgreement(id))
            {
                MessageBox.Show("Agreement succesfully deleted");
                RefreshListbox("agreement");
            } else
            {
                MessageBox.Show("Agreement Id not found!");
            }
        }


        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            this.RefreshButtonClick();
            RefreshListbox("tenant");
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            this.RefreshButtonClick();
            RefreshListbox("complaint");
        }

        private void btnRefresh3_Click(object sender, EventArgs e)
        {
            this.RefreshButtonClick();
            RefreshListbox("agreement");
        }

        private void btnRemoveComplaint_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numComplaintID.Value);
            if (ComplaintManager.RemoveComplaint(id))
            {
                MessageBox.Show("Complaint succesfully deleted!");
                RefreshListbox("complaint");
            }
            else
            {
                MessageBox.Show("Complaint not found!");
            }
        }

        private void btnEditTenant_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numEditTenant.Value);
            TenantAccount accountToEdit = AccountsManager.SearchById(id);
            if (accountToEdit != null)
            {
                EditTenant newEditForm = new EditTenant(accountToEdit);
                newEditForm.Show();
            } else
            {
                MessageBox.Show("Tenant Id not found!");
            }
        }

        private void btnRefresh4_Click(object sender, EventArgs e)
        {
            this.RefreshButtonClick();
            RefreshListbox("chore");
        }

        private void btnDeleteChore_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numChoreId.Value);
            if (ChoreManager.RemoveChore(id))
            {
                MessageBox.Show("Chore succesfully deleted!");
                RefreshListbox("chore");
            }
            else
            {
                MessageBox.Show("Chore not found!");
            }
        }

        private void linkLabelSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage tenantApp = new LoginPage ();
            tenantApp.ShowDialog();
            this.Close();
        }
    }
}
