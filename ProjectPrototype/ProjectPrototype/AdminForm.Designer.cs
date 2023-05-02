
namespace ProjectPrototype
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditTenant = new System.Windows.Forms.Button();
            this.numEditTenant = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.lbTenant = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditForm = new System.Windows.Forms.Button();
            this.btnAddHouseRule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHouseRules = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.numComplaintID = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.btnRemoveComplaint = new System.Windows.Forms.Button();
            this.btnMarkResolved = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.numAgreementId = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbAgreements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabChores = new System.Windows.Forms.TabPage();
            this.btnDeleteChore = new System.Windows.Forms.Button();
            this.numChoreId = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbChores = new System.Windows.Forms.ListBox();
            this.linkLabelSignOut = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditTenant)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numComplaintID)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgreementId)).BeginInit();
            this.tabChores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChoreId)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabChores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 468);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabelSignOut);
            this.tabPage1.Controls.Add(this.btnEditTenant);
            this.tabPage1.Controls.Add(this.numEditTenant);
            this.tabPage1.Controls.Add(this.btnRefresh1);
            this.tabPage1.Controls.Add(this.lbTenant);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnEditForm);
            this.tabPage1.Controls.Add(this.btnAddHouseRule);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbHouseRules);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnEditTenant
            // 
            this.btnEditTenant.Location = new System.Drawing.Point(529, 295);
            this.btnEditTenant.Name = "btnEditTenant";
            this.btnEditTenant.Size = new System.Drawing.Size(124, 57);
            this.btnEditTenant.TabIndex = 10;
            this.btnEditTenant.Text = "Edit tenant";
            this.btnEditTenant.UseVisualStyleBackColor = true;
            this.btnEditTenant.Click += new System.EventHandler(this.btnEditTenant_Click);
            // 
            // numEditTenant
            // 
            this.numEditTenant.Location = new System.Drawing.Point(673, 310);
            this.numEditTenant.Name = "numEditTenant";
            this.numEditTenant.Size = new System.Drawing.Size(90, 27);
            this.numEditTenant.TabIndex = 9;
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Location = new System.Drawing.Point(682, 392);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(102, 35);
            this.btnRefresh1.TabIndex = 8;
            this.btnRefresh1.Text = "Refresh";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // lbTenant
            // 
            this.lbTenant.FormattingEnabled = true;
            this.lbTenant.HorizontalScrollbar = true;
            this.lbTenant.ItemHeight = 20;
            this.lbTenant.Location = new System.Drawing.Point(490, 44);
            this.lbTenant.Name = "lbTenant";
            this.lbTenant.Size = new System.Drawing.Size(294, 244);
            this.lbTenant.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(588, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tenants";
            // 
            // btnEditForm
            // 
            this.btnEditForm.Location = new System.Drawing.Point(194, 294);
            this.btnEditForm.Name = "btnEditForm";
            this.btnEditForm.Size = new System.Drawing.Size(124, 57);
            this.btnEditForm.TabIndex = 3;
            this.btnEditForm.Text = "Edit rule";
            this.btnEditForm.UseVisualStyleBackColor = true;
            this.btnEditForm.Click += new System.EventHandler(this.btnEditForm_Click);
            // 
            // btnAddHouseRule
            // 
            this.btnAddHouseRule.Location = new System.Drawing.Point(41, 294);
            this.btnAddHouseRule.Name = "btnAddHouseRule";
            this.btnAddHouseRule.Size = new System.Drawing.Size(122, 57);
            this.btnAddHouseRule.TabIndex = 2;
            this.btnAddHouseRule.Text = "Add Rule";
            this.btnAddHouseRule.UseVisualStyleBackColor = true;
            this.btnAddHouseRule.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "House Rules";
            // 
            // lbHouseRules
            // 
            this.lbHouseRules.FormattingEnabled = true;
            this.lbHouseRules.HorizontalScrollbar = true;
            this.lbHouseRules.ItemHeight = 20;
            this.lbHouseRules.Location = new System.Drawing.Point(21, 44);
            this.lbHouseRules.Name = "lbHouseRules";
            this.lbHouseRules.Size = new System.Drawing.Size(324, 244);
            this.lbHouseRules.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.numComplaintID);
            this.tabPage3.Controls.Add(this.btnRefresh2);
            this.tabPage3.Controls.Add(this.btnRemoveComplaint);
            this.tabPage3.Controls.Add(this.btnMarkResolved);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lbComplaints);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(808, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Complaints";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Complaint ID";
            // 
            // numComplaintID
            // 
            this.numComplaintID.Location = new System.Drawing.Point(624, 103);
            this.numComplaintID.Name = "numComplaintID";
            this.numComplaintID.Size = new System.Drawing.Size(142, 27);
            this.numComplaintID.TabIndex = 5;
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Location = new System.Drawing.Point(681, 391);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(107, 36);
            this.btnRefresh2.TabIndex = 4;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // btnRemoveComplaint
            // 
            this.btnRemoveComplaint.Location = new System.Drawing.Point(624, 228);
            this.btnRemoveComplaint.Name = "btnRemoveComplaint";
            this.btnRemoveComplaint.Size = new System.Drawing.Size(142, 64);
            this.btnRemoveComplaint.TabIndex = 3;
            this.btnRemoveComplaint.Text = "Remove Complaint";
            this.btnRemoveComplaint.UseVisualStyleBackColor = true;
            this.btnRemoveComplaint.Click += new System.EventHandler(this.btnRemoveComplaint_Click);
            // 
            // btnMarkResolved
            // 
            this.btnMarkResolved.Location = new System.Drawing.Point(624, 136);
            this.btnMarkResolved.Name = "btnMarkResolved";
            this.btnMarkResolved.Size = new System.Drawing.Size(142, 60);
            this.btnMarkResolved.TabIndex = 2;
            this.btnMarkResolved.Text = "Mark as resolved";
            this.btnMarkResolved.UseVisualStyleBackColor = true;
            this.btnMarkResolved.Click += new System.EventHandler(this.btnMarkResolved_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(145, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Complaints";
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 20;
            this.lbComplaints.Location = new System.Drawing.Point(22, 61);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(560, 324);
            this.lbComplaints.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.numAgreementId);
            this.tabPage2.Controls.Add(this.btnRefresh3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lbAgreements);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agreements";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Agreement Id";
            // 
            // numAgreementId
            // 
            this.numAgreementId.Location = new System.Drawing.Point(600, 136);
            this.numAgreementId.Name = "numAgreementId";
            this.numAgreementId.Size = new System.Drawing.Size(141, 27);
            this.numAgreementId.TabIndex = 5;
            // 
            // btnRefresh3
            // 
            this.btnRefresh3.Location = new System.Drawing.Point(695, 391);
            this.btnRefresh3.Name = "btnRefresh3";
            this.btnRefresh3.Size = new System.Drawing.Size(95, 36);
            this.btnRefresh3.TabIndex = 4;
            this.btnRefresh3.Text = "Refresh";
            this.btnRefresh3.UseVisualStyleBackColor = true;
            this.btnRefresh3.Click += new System.EventHandler(this.btnRefresh3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Agreement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbAgreements
            // 
            this.lbAgreements.FormattingEnabled = true;
            this.lbAgreements.HorizontalScrollbar = true;
            this.lbAgreements.ItemHeight = 20;
            this.lbAgreements.Location = new System.Drawing.Point(26, 62);
            this.lbAgreements.Name = "lbAgreements";
            this.lbAgreements.Size = new System.Drawing.Size(540, 324);
            this.lbAgreements.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agreements";
            // 
            // tabChores
            // 
            this.tabChores.Controls.Add(this.btnDeleteChore);
            this.tabChores.Controls.Add(this.numChoreId);
            this.tabChores.Controls.Add(this.btnRefresh4);
            this.tabChores.Controls.Add(this.label7);
            this.tabChores.Controls.Add(this.lbChores);
            this.tabChores.Location = new System.Drawing.Point(4, 29);
            this.tabChores.Name = "tabChores";
            this.tabChores.Size = new System.Drawing.Size(808, 435);
            this.tabChores.TabIndex = 3;
            this.tabChores.Text = "Chores";
            this.tabChores.UseVisualStyleBackColor = true;
            // 
            // btnDeleteChore
            // 
            this.btnDeleteChore.Location = new System.Drawing.Point(621, 198);
            this.btnDeleteChore.Name = "btnDeleteChore";
            this.btnDeleteChore.Size = new System.Drawing.Size(150, 55);
            this.btnDeleteChore.TabIndex = 4;
            this.btnDeleteChore.Text = "Delete Chore";
            this.btnDeleteChore.UseVisualStyleBackColor = true;
            this.btnDeleteChore.Click += new System.EventHandler(this.btnDeleteChore_Click);
            // 
            // numChoreId
            // 
            this.numChoreId.Location = new System.Drawing.Point(621, 155);
            this.numChoreId.Name = "numChoreId";
            this.numChoreId.Size = new System.Drawing.Size(150, 27);
            this.numChoreId.TabIndex = 3;
            // 
            // btnRefresh4
            // 
            this.btnRefresh4.Location = new System.Drawing.Point(693, 394);
            this.btnRefresh4.Name = "btnRefresh4";
            this.btnRefresh4.Size = new System.Drawing.Size(96, 33);
            this.btnRefresh4.TabIndex = 2;
            this.btnRefresh4.Text = "Refresh";
            this.btnRefresh4.UseVisualStyleBackColor = true;
            this.btnRefresh4.Click += new System.EventHandler(this.btnRefresh4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(178, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chores";
            // 
            // lbChores
            // 
            this.lbChores.FormattingEnabled = true;
            this.lbChores.ItemHeight = 20;
            this.lbChores.Location = new System.Drawing.Point(25, 67);
            this.lbChores.Name = "lbChores";
            this.lbChores.Size = new System.Drawing.Size(506, 304);
            this.lbChores.TabIndex = 0;
            // 
            // linkLabelSignOut
            // 
            this.linkLabelSignOut.AutoSize = true;
            this.linkLabelSignOut.Location = new System.Drawing.Point(21, 392);
            this.linkLabelSignOut.Name = "linkLabelSignOut";
            this.linkLabelSignOut.Size = new System.Drawing.Size(68, 20);
            this.linkLabelSignOut.TabIndex = 11;
            this.linkLabelSignOut.TabStop = true;
            this.linkLabelSignOut.Text = "Sing out!";
            this.linkLabelSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignOut_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditTenant)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numComplaintID)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgreementId)).EndInit();
            this.tabChores.ResumeLayout(false);
            this.tabChores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChoreId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbAgreements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTenant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditForm;
        private System.Windows.Forms.Button btnAddHouseRule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbHouseRules;
        private System.Windows.Forms.Button btnRemoveComplaint;
        private System.Windows.Forms.Button btnMarkResolved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Button btnRefresh3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numComplaintID;
        private System.Windows.Forms.NumericUpDown numAgreementId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditTenant;
        private System.Windows.Forms.NumericUpDown numEditTenant;
        private System.Windows.Forms.TabPage tabChores;
        private System.Windows.Forms.Button btnRefresh4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbChores;
        private System.Windows.Forms.Button btnDeleteChore;
        private System.Windows.Forms.NumericUpDown numChoreId;
        private System.Windows.Forms.LinkLabel linkLabelSignOut;
    }
}

