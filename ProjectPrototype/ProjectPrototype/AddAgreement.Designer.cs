
namespace ProjectPrototype
{
    partial class AddAgreement
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
            this.tbTenant1 = new System.Windows.Forms.TextBox();
            this.tbTenant2 = new System.Windows.Forms.TextBox();
            this.tbAgreement = new System.Windows.Forms.TextBox();
            this.btnAddAgreement = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTenant1 = new System.Windows.Forms.Label();
            this.lblTenant2 = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.lblTenantRoom = new System.Windows.Forms.Label();
            this.numTenantRoom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTenantRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenant1
            // 
            this.tbTenant1.Location = new System.Drawing.Point(161, 70);
            this.tbTenant1.Name = "tbTenant1";
            this.tbTenant1.Size = new System.Drawing.Size(143, 27);
            this.tbTenant1.TabIndex = 0;
            // 
            // tbTenant2
            // 
            this.tbTenant2.Location = new System.Drawing.Point(161, 119);
            this.tbTenant2.Name = "tbTenant2";
            this.tbTenant2.Size = new System.Drawing.Size(143, 27);
            this.tbTenant2.TabIndex = 1;
            // 
            // tbAgreement
            // 
            this.tbAgreement.Location = new System.Drawing.Point(161, 212);
            this.tbAgreement.Name = "tbAgreement";
            this.tbAgreement.Size = new System.Drawing.Size(143, 27);
            this.tbAgreement.TabIndex = 2;
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Location = new System.Drawing.Point(161, 272);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(143, 54);
            this.btnAddAgreement.TabIndex = 3;
            this.btnAddAgreement.Text = "Request agreement";
            this.btnAddAgreement.UseVisualStyleBackColor = true;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(161, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 53);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenant1
            // 
            this.lblTenant1.AutoSize = true;
            this.lblTenant1.Location = new System.Drawing.Point(39, 70);
            this.lblTenant1.Name = "lblTenant1";
            this.lblTenant1.Size = new System.Drawing.Size(79, 20);
            this.lblTenant1.TabIndex = 5;
            this.lblTenant1.Text = "Your name";
            // 
            // lblTenant2
            // 
            this.lblTenant2.AutoSize = true;
            this.lblTenant2.Location = new System.Drawing.Point(39, 119);
            this.lblTenant2.Name = "lblTenant2";
            this.lblTenant2.Size = new System.Drawing.Size(103, 20);
            this.lblTenant2.TabIndex = 6;
            this.lblTenant2.Text = "Tenant\'s name";
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Location = new System.Drawing.Point(39, 212);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(83, 20);
            this.lblAgreement.TabIndex = 7;
            this.lblAgreement.Text = "Agreement";
            // 
            // lblTenantRoom
            // 
            this.lblTenantRoom.AutoSize = true;
            this.lblTenantRoom.Location = new System.Drawing.Point(39, 167);
            this.lblTenantRoom.Name = "lblTenantRoom";
            this.lblTenantRoom.Size = new System.Drawing.Size(102, 20);
            this.lblTenantRoom.TabIndex = 8;
            this.lblTenantRoom.Text = "Tenant\'s room";
            // 
            // numTenantRoom
            // 
            this.numTenantRoom.Location = new System.Drawing.Point(161, 165);
            this.numTenantRoom.Name = "numTenantRoom";
            this.numTenantRoom.Size = new System.Drawing.Size(143, 27);
            this.numTenantRoom.TabIndex = 9;
            // 
            // AddAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 432);
            this.Controls.Add(this.numTenantRoom);
            this.Controls.Add(this.lblTenantRoom);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.lblTenant2);
            this.Controls.Add(this.lblTenant1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAgreement);
            this.Controls.Add(this.tbAgreement);
            this.Controls.Add(this.tbTenant2);
            this.Controls.Add(this.tbTenant1);
            this.Name = "AddAgreement";
            this.Text = "AddAgreement";
            ((System.ComponentModel.ISupportInitialize)(this.numTenantRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTenant1;
        private System.Windows.Forms.TextBox tbTenant2;
        private System.Windows.Forms.TextBox tbAgreement;
        private System.Windows.Forms.Button btnAddAgreement;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTenant1;
        private System.Windows.Forms.Label lblTenant2;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.Label lblTenantRoom;
        private System.Windows.Forms.NumericUpDown numTenantRoom;
    }
}