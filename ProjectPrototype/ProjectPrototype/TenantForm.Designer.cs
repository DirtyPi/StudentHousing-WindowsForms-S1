
namespace ProjectPrototype
{
    partial class TenantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.UploadPicturebtn = new System.Windows.Forms.Button();
            this.tenantPicture = new System.Windows.Forms.PictureBox();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabAgreements = new System.Windows.Forms.TabPage();
            this.lblUnconfirmedAgreements = new System.Windows.Forms.Label();
            this.lblAgreementId = new System.Windows.Forms.Label();
            this.numUnconfirmedAgreement = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmAgreement = new System.Windows.Forms.Button();
            this.lbUnconfirmedAgreements = new System.Windows.Forms.ListBox();
            this.btnRequestAgreement = new System.Windows.Forms.Button();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAgreements = new System.Windows.Forms.ListBox();
            this.tabDuties = new System.Windows.Forms.TabPage();
            this.btnRefresh3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numChoreId = new System.Windows.Forms.NumericUpDown();
            this.lbChores = new System.Windows.Forms.ListBox();
            this.btnRemoveChore = new System.Windows.Forms.Button();
            this.btnAddChore = new System.Windows.Forms.Button();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbChore = new System.Windows.Forms.ComboBox();
            this.tabComplaints = new System.Windows.Forms.TabPage();
            this.btnRemoveComplaint = new System.Windows.Forms.Button();
            this.lblComplaintId = new System.Windows.Forms.Label();
            this.numComplaintId = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh4 = new System.Windows.Forms.Button();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.lblAddComplaint = new System.Windows.Forms.Label();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.tabAnnouncements = new System.Windows.Forms.TabPage();
            this.btnRefresh5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveAnnouncement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAnnouncement = new System.Windows.Forms.Button();
            this.tbAddAnnouncement = new System.Windows.Forms.TextBox();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantPicture)).BeginInit();
            this.tabAgreements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnconfirmedAgreement)).BeginInit();
            this.tabDuties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChoreId)).BeginInit();
            this.tabComplaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numComplaintId)).BeginInit();
            this.tabAnnouncements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabAgreements);
            this.tabControl1.Controls.Add(this.tabDuties);
            this.tabControl1.Controls.Add(this.tabComplaints);
            this.tabControl1.Controls.Add(this.tabAnnouncements);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 437);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.linkLabel1);
            this.tabMain.Controls.Add(this.UploadPicturebtn);
            this.tabMain.Controls.Add(this.tenantPicture);
            this.tabMain.Controls.Add(this.lbRules);
            this.tabMain.Controls.Add(this.btnRefresh1);
            this.tabMain.Controls.Add(this.lblHouseRules);
            this.tabMain.Controls.Add(this.lblWelcome);
            this.tabMain.Location = new System.Drawing.Point(4, 29);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(790, 404);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // UploadPicturebtn
            // 
            this.UploadPicturebtn.Location = new System.Drawing.Point(39, 197);
            this.UploadPicturebtn.Name = "UploadPicturebtn";
            this.UploadPicturebtn.Size = new System.Drawing.Size(114, 36);
            this.UploadPicturebtn.TabIndex = 6;
            this.UploadPicturebtn.Text = "Upload";
            this.UploadPicturebtn.UseVisualStyleBackColor = true;
            this.UploadPicturebtn.Click += new System.EventHandler(this.UploadPicturebtn_Click);
            // 
            // tenantPicture
            // 
            this.tenantPicture.Location = new System.Drawing.Point(16, 48);
            this.tenantPicture.Name = "tenantPicture";
            this.tenantPicture.Size = new System.Drawing.Size(155, 134);
            this.tenantPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenantPicture.TabIndex = 5;
            this.tenantPicture.TabStop = false;
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 20;
            this.lbRules.Location = new System.Drawing.Point(454, 84);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(300, 264);
            this.lbRules.TabIndex = 4;
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Location = new System.Drawing.Point(16, 347);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(114, 41);
            this.btnRefresh1.TabIndex = 3;
            this.btnRefresh1.Text = "Refresh";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHouseRules.Location = new System.Drawing.Point(542, 37);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(118, 28);
            this.lblHouseRules.TabIndex = 1;
            this.lblHouseRules.Text = "House Rules";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(16, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(73, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // tabAgreements
            // 
            this.tabAgreements.Controls.Add(this.lblUnconfirmedAgreements);
            this.tabAgreements.Controls.Add(this.lblAgreementId);
            this.tabAgreements.Controls.Add(this.numUnconfirmedAgreement);
            this.tabAgreements.Controls.Add(this.btnConfirmAgreement);
            this.tabAgreements.Controls.Add(this.lbUnconfirmedAgreements);
            this.tabAgreements.Controls.Add(this.btnRequestAgreement);
            this.tabAgreements.Controls.Add(this.btnRefresh2);
            this.tabAgreements.Controls.Add(this.label1);
            this.tabAgreements.Controls.Add(this.lbAgreements);
            this.tabAgreements.Location = new System.Drawing.Point(4, 29);
            this.tabAgreements.Name = "tabAgreements";
            this.tabAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgreements.Size = new System.Drawing.Size(790, 404);
            this.tabAgreements.TabIndex = 1;
            this.tabAgreements.Text = "Agreements";
            this.tabAgreements.UseVisualStyleBackColor = true;
            // 
            // lblUnconfirmedAgreements
            // 
            this.lblUnconfirmedAgreements.AutoSize = true;
            this.lblUnconfirmedAgreements.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnconfirmedAgreements.Location = new System.Drawing.Point(515, 18);
            this.lblUnconfirmedAgreements.Name = "lblUnconfirmedAgreements";
            this.lblUnconfirmedAgreements.Size = new System.Drawing.Size(248, 28);
            this.lblUnconfirmedAgreements.TabIndex = 8;
            this.lblUnconfirmedAgreements.Text = "Unconfirmed Agreements";
            // 
            // lblAgreementId
            // 
            this.lblAgreementId.AutoSize = true;
            this.lblAgreementId.Location = new System.Drawing.Point(355, 190);
            this.lblAgreementId.Name = "lblAgreementId";
            this.lblAgreementId.Size = new System.Drawing.Size(100, 20);
            this.lblAgreementId.TabIndex = 7;
            this.lblAgreementId.Text = "Agreement Id";
            // 
            // numUnconfirmedAgreement
            // 
            this.numUnconfirmedAgreement.Location = new System.Drawing.Point(345, 213);
            this.numUnconfirmedAgreement.Name = "numUnconfirmedAgreement";
            this.numUnconfirmedAgreement.Size = new System.Drawing.Size(123, 27);
            this.numUnconfirmedAgreement.TabIndex = 6;
            // 
            // btnConfirmAgreement
            // 
            this.btnConfirmAgreement.Location = new System.Drawing.Point(345, 246);
            this.btnConfirmAgreement.Name = "btnConfirmAgreement";
            this.btnConfirmAgreement.Size = new System.Drawing.Size(123, 62);
            this.btnConfirmAgreement.TabIndex = 5;
            this.btnConfirmAgreement.Text = "Confirm agreement";
            this.btnConfirmAgreement.UseVisualStyleBackColor = true;
            this.btnConfirmAgreement.Click += new System.EventHandler(this.btnConfirmAgreement_Click);
            // 
            // lbUnconfirmedAgreements
            // 
            this.lbUnconfirmedAgreements.FormattingEnabled = true;
            this.lbUnconfirmedAgreements.HorizontalScrollbar = true;
            this.lbUnconfirmedAgreements.ItemHeight = 20;
            this.lbUnconfirmedAgreements.Location = new System.Drawing.Point(503, 56);
            this.lbUnconfirmedAgreements.Name = "lbUnconfirmedAgreements";
            this.lbUnconfirmedAgreements.Size = new System.Drawing.Size(260, 264);
            this.lbUnconfirmedAgreements.TabIndex = 4;
            // 
            // btnRequestAgreement
            // 
            this.btnRequestAgreement.Location = new System.Drawing.Point(345, 64);
            this.btnRequestAgreement.Name = "btnRequestAgreement";
            this.btnRequestAgreement.Size = new System.Drawing.Size(123, 62);
            this.btnRequestAgreement.TabIndex = 3;
            this.btnRequestAgreement.Text = "Request agreement";
            this.btnRequestAgreement.UseVisualStyleBackColor = true;
            this.btnRequestAgreement.Click += new System.EventHandler(this.btnRequestAgreement_Click);
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Location = new System.Drawing.Point(20, 352);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(116, 38);
            this.btnRefresh2.TabIndex = 2;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your agreements";
            // 
            // lbAgreements
            // 
            this.lbAgreements.FormattingEnabled = true;
            this.lbAgreements.HorizontalScrollbar = true;
            this.lbAgreements.ItemHeight = 20;
            this.lbAgreements.Location = new System.Drawing.Point(20, 64);
            this.lbAgreements.Name = "lbAgreements";
            this.lbAgreements.Size = new System.Drawing.Size(306, 244);
            this.lbAgreements.TabIndex = 0;
            // 
            // tabDuties
            // 
            this.tabDuties.Controls.Add(this.btnRefresh3);
            this.tabDuties.Controls.Add(this.label6);
            this.tabDuties.Controls.Add(this.label5);
            this.tabDuties.Controls.Add(this.label4);
            this.tabDuties.Controls.Add(this.numChoreId);
            this.tabDuties.Controls.Add(this.lbChores);
            this.tabDuties.Controls.Add(this.btnRemoveChore);
            this.tabDuties.Controls.Add(this.btnAddChore);
            this.tabDuties.Controls.Add(this.cbDay);
            this.tabDuties.Controls.Add(this.cbChore);
            this.tabDuties.Location = new System.Drawing.Point(4, 29);
            this.tabDuties.Name = "tabDuties";
            this.tabDuties.Size = new System.Drawing.Size(790, 404);
            this.tabDuties.TabIndex = 2;
            this.tabDuties.Text = "Chores";
            this.tabDuties.UseVisualStyleBackColor = true;
            this.tabDuties.Click += new System.EventHandler(this.tabDuties_Click);
            // 
            // btnRefresh3
            // 
            this.btnRefresh3.Location = new System.Drawing.Point(17, 360);
            this.btnRefresh3.Name = "btnRefresh3";
            this.btnRefresh3.Size = new System.Drawing.Size(104, 41);
            this.btnRefresh3.TabIndex = 9;
            this.btnRefresh3.Text = "Refresh";
            this.btnRefresh3.UseVisualStyleBackColor = true;
            this.btnRefresh3.Click += new System.EventHandler(this.btnRefresh3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(147, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chore";
            // 
            // numChoreId
            // 
            this.numChoreId.Location = new System.Drawing.Point(533, 231);
            this.numChoreId.Name = "numChoreId";
            this.numChoreId.Size = new System.Drawing.Size(150, 27);
            this.numChoreId.TabIndex = 5;
            // 
            // lbChores
            // 
            this.lbChores.FormattingEnabled = true;
            this.lbChores.ItemHeight = 20;
            this.lbChores.Location = new System.Drawing.Point(38, 77);
            this.lbChores.Name = "lbChores";
            this.lbChores.Size = new System.Drawing.Size(395, 244);
            this.lbChores.TabIndex = 4;
            // 
            // btnRemoveChore
            // 
            this.btnRemoveChore.Location = new System.Drawing.Point(545, 270);
            this.btnRemoveChore.Name = "btnRemoveChore";
            this.btnRemoveChore.Size = new System.Drawing.Size(119, 52);
            this.btnRemoveChore.TabIndex = 3;
            this.btnRemoveChore.Text = "Remove Chore";
            this.btnRemoveChore.UseVisualStyleBackColor = true;
            this.btnRemoveChore.Click += new System.EventHandler(this.btnRemoveChore_Click);
            // 
            // btnAddChore
            // 
            this.btnAddChore.Location = new System.Drawing.Point(545, 147);
            this.btnAddChore.Name = "btnAddChore";
            this.btnAddChore.Size = new System.Drawing.Size(119, 45);
            this.btnAddChore.TabIndex = 2;
            this.btnAddChore.Text = "Add Chore";
            this.btnAddChore.UseVisualStyleBackColor = true;
            this.btnAddChore.Click += new System.EventHandler(this.btnAddChore_Click);
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(533, 94);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(151, 28);
            this.cbDay.TabIndex = 1;
            // 
            // cbChore
            // 
            this.cbChore.FormattingEnabled = true;
            this.cbChore.Location = new System.Drawing.Point(533, 46);
            this.cbChore.Name = "cbChore";
            this.cbChore.Size = new System.Drawing.Size(151, 28);
            this.cbChore.TabIndex = 0;
            // 
            // tabComplaints
            // 
            this.tabComplaints.Controls.Add(this.btnRemoveComplaint);
            this.tabComplaints.Controls.Add(this.lblComplaintId);
            this.tabComplaints.Controls.Add(this.numComplaintId);
            this.tabComplaints.Controls.Add(this.btnRefresh4);
            this.tabComplaints.Controls.Add(this.btnAddComplaint);
            this.tabComplaints.Controls.Add(this.lblAddComplaint);
            this.tabComplaints.Controls.Add(this.lbComplaints);
            this.tabComplaints.Controls.Add(this.lblComplaints);
            this.tabComplaints.Location = new System.Drawing.Point(4, 29);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Size = new System.Drawing.Size(790, 404);
            this.tabComplaints.TabIndex = 3;
            this.tabComplaints.Text = "Complaints";
            this.tabComplaints.UseVisualStyleBackColor = true;
            // 
            // btnRemoveComplaint
            // 
            this.btnRemoveComplaint.Location = new System.Drawing.Point(557, 250);
            this.btnRemoveComplaint.Name = "btnRemoveComplaint";
            this.btnRemoveComplaint.Size = new System.Drawing.Size(149, 50);
            this.btnRemoveComplaint.TabIndex = 7;
            this.btnRemoveComplaint.Text = "Remove Complaint";
            this.btnRemoveComplaint.UseVisualStyleBackColor = true;
            this.btnRemoveComplaint.Click += new System.EventHandler(this.btnRemoveComplaint_Click);
            // 
            // lblComplaintId
            // 
            this.lblComplaintId.AutoSize = true;
            this.lblComplaintId.Location = new System.Drawing.Point(522, 219);
            this.lblComplaintId.Name = "lblComplaintId";
            this.lblComplaintId.Size = new System.Drawing.Size(95, 20);
            this.lblComplaintId.TabIndex = 6;
            this.lblComplaintId.Text = "Complaint Id";
            // 
            // numComplaintId
            // 
            this.numComplaintId.Location = new System.Drawing.Point(629, 217);
            this.numComplaintId.Name = "numComplaintId";
            this.numComplaintId.Size = new System.Drawing.Size(77, 27);
            this.numComplaintId.TabIndex = 5;
            // 
            // btnRefresh4
            // 
            this.btnRefresh4.Location = new System.Drawing.Point(24, 348);
            this.btnRefresh4.Name = "btnRefresh4";
            this.btnRefresh4.Size = new System.Drawing.Size(104, 42);
            this.btnRefresh4.TabIndex = 4;
            this.btnRefresh4.Text = "Refresh";
            this.btnRefresh4.UseVisualStyleBackColor = true;
            this.btnRefresh4.Click += new System.EventHandler(this.btnRefresh4_Click);
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.Location = new System.Drawing.Point(557, 125);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(149, 49);
            this.btnAddComplaint.TabIndex = 3;
            this.btnAddComplaint.Text = "Add complaint";
            this.btnAddComplaint.UseVisualStyleBackColor = true;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);
            // 
            // lblAddComplaint
            // 
            this.lblAddComplaint.AutoSize = true;
            this.lblAddComplaint.Location = new System.Drawing.Point(522, 83);
            this.lblAddComplaint.Name = "lblAddComplaint";
            this.lblAddComplaint.Size = new System.Drawing.Size(223, 20);
            this.lblAddComplaint.TabIndex = 2;
            this.lblAddComplaint.Text = "Do you have anything to report?";
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.HorizontalScrollbar = true;
            this.lbComplaints.ItemHeight = 20;
            this.lbComplaints.Location = new System.Drawing.Point(24, 96);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(363, 204);
            this.lbComplaints.TabIndex = 1;
            // 
            // lblComplaints
            // 
            this.lblComplaints.AutoSize = true;
            this.lblComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaints.Location = new System.Drawing.Point(90, 40);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(152, 28);
            this.lblComplaints.TabIndex = 0;
            this.lblComplaints.Text = "Your complaints";
            // 
            // tabAnnouncements
            // 
            this.tabAnnouncements.Controls.Add(this.btnRefresh5);
            this.tabAnnouncements.Controls.Add(this.label3);
            this.tabAnnouncements.Controls.Add(this.btnRemoveAnnouncement);
            this.tabAnnouncements.Controls.Add(this.label2);
            this.tabAnnouncements.Controls.Add(this.btnAddAnnouncement);
            this.tabAnnouncements.Controls.Add(this.tbAddAnnouncement);
            this.tabAnnouncements.Controls.Add(this.lbAnnouncements);
            this.tabAnnouncements.Location = new System.Drawing.Point(4, 29);
            this.tabAnnouncements.Name = "tabAnnouncements";
            this.tabAnnouncements.Size = new System.Drawing.Size(790, 404);
            this.tabAnnouncements.TabIndex = 4;
            this.tabAnnouncements.Text = "Announcements";
            this.tabAnnouncements.UseVisualStyleBackColor = true;
            // 
            // btnRefresh5
            // 
            this.btnRefresh5.Location = new System.Drawing.Point(18, 362);
            this.btnRefresh5.Name = "btnRefresh5";
            this.btnRefresh5.Size = new System.Drawing.Size(98, 39);
            this.btnRefresh5.TabIndex = 6;
            this.btnRefresh5.Text = "Refresh";
            this.btnRefresh5.UseVisualStyleBackColor = true;
            this.btnRefresh5.Click += new System.EventHandler(this.btnRefresh5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text";
            // 
            // btnRemoveAnnouncement
            // 
            this.btnRemoveAnnouncement.Location = new System.Drawing.Point(531, 262);
            this.btnRemoveAnnouncement.Name = "btnRemoveAnnouncement";
            this.btnRemoveAnnouncement.Size = new System.Drawing.Size(207, 51);
            this.btnRemoveAnnouncement.TabIndex = 4;
            this.btnRemoveAnnouncement.Text = "Remove Announcement";
            this.btnRemoveAnnouncement.UseVisualStyleBackColor = true;
            this.btnRemoveAnnouncement.Click += new System.EventHandler(this.btnRemoveAnnouncement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(151, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Announcements";
            // 
            // btnAddAnnouncement
            // 
            this.btnAddAnnouncement.Location = new System.Drawing.Point(531, 186);
            this.btnAddAnnouncement.Name = "btnAddAnnouncement";
            this.btnAddAnnouncement.Size = new System.Drawing.Size(207, 55);
            this.btnAddAnnouncement.TabIndex = 2;
            this.btnAddAnnouncement.Text = "Add New Announcement";
            this.btnAddAnnouncement.UseVisualStyleBackColor = true;
            this.btnAddAnnouncement.Click += new System.EventHandler(this.btnAddAnnouncement_Click);
            // 
            // tbAddAnnouncement
            // 
            this.tbAddAnnouncement.Location = new System.Drawing.Point(531, 142);
            this.tbAddAnnouncement.Name = "tbAddAnnouncement";
            this.tbAddAnnouncement.Size = new System.Drawing.Size(207, 27);
            this.tbAddAnnouncement.TabIndex = 1;
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 20;
            this.lbAnnouncements.Location = new System.Drawing.Point(39, 81);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(455, 244);
            this.lbAnnouncements.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sing Out!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantForm";
            this.Text = "TenantForm";
            this.Load += new System.EventHandler(this.TenantForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantPicture)).EndInit();
            this.tabAgreements.ResumeLayout(false);
            this.tabAgreements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnconfirmedAgreement)).EndInit();
            this.tabDuties.ResumeLayout(false);
            this.tabDuties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChoreId)).EndInit();
            this.tabComplaints.ResumeLayout(false);
            this.tabComplaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numComplaintId)).EndInit();
            this.tabAnnouncements.ResumeLayout(false);
            this.tabAnnouncements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabAgreements;
        private System.Windows.Forms.TabPage tabComplaints;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.ListBox lbAgreements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.Label lblAddComplaint;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.Button btnRefresh4;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Button btnRequestAgreement;
        private System.Windows.Forms.Label lblUnconfirmedAgreements;
        private System.Windows.Forms.Label lblAgreementId;
        private System.Windows.Forms.NumericUpDown numUnconfirmedAgreement;
        private System.Windows.Forms.Button btnConfirmAgreement;
        private System.Windows.Forms.ListBox lbUnconfirmedAgreements;
        private System.Windows.Forms.Button btnRemoveComplaint;
        private System.Windows.Forms.Label lblComplaintId;
        private System.Windows.Forms.NumericUpDown numComplaintId;
        private System.Windows.Forms.TabPage tabDuties;
        private System.Windows.Forms.ListBox lbChores;
        private System.Windows.Forms.Button btnRemoveChore;
        private System.Windows.Forms.Button btnAddChore;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbChore;
        private System.Windows.Forms.NumericUpDown numChoreId;
        private System.Windows.Forms.TabPage tabAnnouncements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAnnouncement;
        private System.Windows.Forms.TextBox tbAddAnnouncement;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Button btnRemoveAnnouncement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh3;
        private System.Windows.Forms.Button btnRefresh5;
        private System.Windows.Forms.Button UploadPicturebtn;
        private System.Windows.Forms.PictureBox tenantPicture;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}