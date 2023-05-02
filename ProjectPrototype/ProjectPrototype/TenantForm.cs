using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class TenantForm : Form
    {
        string welcomeMsg = "";
        List<Complaint> compList = null;
        HouseRules newHouseRule = new HouseRules();

        TenantAccount currentTenant = null;
        public TenantForm(string welcome)
        {
            InitializeComponent();
            welcomeMsg = welcome;
            ReloadPicture();
            loadRules();
        }

        private void loadRules()
        {
            lbRules.Items.Clear();
            List<string> temp = HouseRules.GetHouseRules();
            foreach (string a in temp)
            {
                lbRules.Items.Add(a);
            }
        }

        private void TenantForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {welcomeMsg}";
            currentTenant = AccountsManager.ReturnTenantWithAgreements(welcomeMsg);

            cbDay.Items.Add("Monday");
            cbDay.Items.Add("Tuesday");
            cbDay.Items.Add("Wednesday");
            cbDay.Items.Add("Thursday");
            cbDay.Items.Add("Friday");
            cbDay.Items.Add("Saturday");
            cbDay.Items.Add("Sunday");

            cbChore.Items.Add("Grocery Shopping");
            cbChore.Items.Add("Doing dishes");
            cbChore.Items.Add("Dusting");
            cbChore.Items.Add("Laundry");
            cbChore.Items.Add("Meal preparation");
            cbChore.Items.Add("Taking out trash");
            cbChore.Items.Add("Cleaning floors");
            cbChore.Items.Add("Vacuuming");

            displayHouseRules();
            displayAgreements();
            displayComplaints();
            loadRules();
        }

        private void displayHouseRules()
        {
            lbRules.Items.Clear();
            foreach(string rule in HouseRules.GetHouseRules())
            {
                if (!lbRules.Items.Contains(rule))
                    lbRules.Items.Add(rule);
            }
        }

        private void displayAgreements()
        {
            lbUnconfirmedAgreements.Items.Clear();
            lbAgreements.Items.Clear();


            //foreach (Agreement a in AgreementManager.ReturnUnconfirmedAgreements())
            //{
            //    lbUnconfirmedAgreements.Items.Add(a.GetInfo());
            //}
            TenantAccount currentTenant = AccountsManager.ReturnTenantWithAgreements(welcomeMsg);

            List<Agreement> unconfirmedAgreements = currentTenant.ReturnUnconfirmedAgreements();
            foreach (Agreement a in unconfirmedAgreements)
            {
                lbUnconfirmedAgreements.Items.Add(a.GetInfo());
            }

            foreach (Agreement a in AgreementManager.ReturnAgreementList())
            {
                lbAgreements.Items.Add(a.GetInfo());
            }
        }
        
        private void displayComplaints()
        {
            lbComplaints.Items.Clear();
            foreach (Complaint c in ComplaintManager.ReturnComplaintList())
            {
                lbComplaints.Items.Add(c.GetInfo());
            }
        }

        public void RefreshListbox(string keyword)
        {
            if (keyword == "complaint")
            {
                lbComplaints.Items.Clear();
                compList = ComplaintManager.ReturnComplaintList();

                foreach (Complaint c in compList)
                {
                    lbComplaints.Items.Add(c.GetInfo());
                }
            } else if (keyword == "agreement")
            {
                lbAgreements.Items.Clear();
                lbUnconfirmedAgreements.Items.Clear();

                foreach(Agreement a in AgreementManager.ReturnAgreementList())
                {
                    lbAgreements.Items.Add(a.GetInfo());
                }

                // Search for agreement based on current user

                List<Agreement> unconfirmedAgreements = currentTenant.ReturnUnconfirmedAgreements();
                foreach(Agreement a in unconfirmedAgreements)
                {
                    lbUnconfirmedAgreements.Items.Add(a.GetInfo());
                }
                //foreach(Agreement a in currentTenant.)
                //{
                //    lbUnconfirmedAgreements.Items.Add(a.GetInfo());
                //}
            } else if (keyword == "chore")
            {
                lbChores.Items.Clear();
                foreach(Chore c in ChoreManager.ReturnChoreList())
                {
                    lbChores.Items.Add(c.GetInfo());
                }
            } else if (keyword == "announcement") {
                {
                    lbAnnouncements.Items.Clear();

                    foreach (Announcement a in AnnouncementManager.GetAll())
                    {
                        lbAnnouncements.Items.Add(a.GetInfo());
                    }
                } }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            displayHouseRules();
            displayAgreements();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            AddComplaint newComplaint = new AddComplaint(this);
            newComplaint.Show();
        }

        private void btnRefresh4_Click(object sender, EventArgs e)
        {
            this.Refresh();
            RefreshListbox("complaint");
            displayHouseRules();
            displayAgreements();
            displayComplaints();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            RefreshListbox("agreement");
            displayHouseRules();
            displayAgreements();
            displayComplaints();
        }

        private void btnRequestAgreement_Click(object sender, EventArgs e)
        {
            AddAgreement newAgreement = new AddAgreement();
            newAgreement.Show();
        }

        private void btnRemoveComplaint_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numComplaintId.Value);
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

        private void btnConfirmAgreement_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numUnconfirmedAgreement.Value);
            if (AgreementManager.SearchAgreement(id, currentTenant))
            {
                RefreshListbox("agreement");
            } else
            {
                MessageBox.Show("Agreement not found!");
            }
        }

        private void btnAddChore_Click(object sender, EventArgs e)
        {
            if (cbChore.Text != "" && cbDay.Text != "")
            {
                Chore newChore = new Chore(cbDay.Text, cbChore.Text, welcomeMsg);
                ChoreManager.AddChore(newChore);
                RefreshListbox("chore");
            }
        }

        private void btnRemoveChore_Click(object sender, EventArgs e)
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

        private void tabDuties_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            if(tbAddAnnouncement.Text != "")
            {
                Announcement newAnnouncement = new Announcement(welcomeMsg, tbAddAnnouncement.Text);
                AnnouncementManager.Add(newAnnouncement);
                RefreshListbox("announcement");
            }
        }

        private void btnRemoveAnnouncement_Click(object sender, EventArgs e)
        {
            if(lbAnnouncements.SelectedIndex != -1)
            {
                int index = lbAnnouncements.SelectedIndex;
                AnnouncementManager.Remove(index);
                RefreshListbox("announcement");
            } else
            {
                MessageBox.Show("Please select an announcement to remove!");
            }
        }

        private void btnRefresh3_Click(object sender, EventArgs e)
        {
            this.Refresh();
            RefreshListbox("chore");
        }

        private void btnRefresh5_Click(object sender, EventArgs e)
        {
            this.Refresh();
            RefreshListbox("announcement");
        }

        private void UploadPicturebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(.jpg; *.png;)|.jpg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string imageSource = open.FileName;
                File.Copy(imageSource, @"database\ProfilePictures\" + welcomeMsg + ".png");
                ReloadPicture();
            }
        }
            private void ReloadPicture()
            {
                if (File.Exists(@"database\ProfilePictures\" + welcomeMsg + ".png"))
                {
                    tenantPicture.ImageLocation = @"database\ProfilePictures\" + welcomeMsg + ".png";
                    UploadPicturebtn.Hide();
                }
                else
                {
                    tenantPicture.ImageLocation = @"database\ProfilePictures\default.jpg";
                }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage tenantApp = new LoginPage();
            tenantApp.ShowDialog();
            this.Close();
        }
    }
}
