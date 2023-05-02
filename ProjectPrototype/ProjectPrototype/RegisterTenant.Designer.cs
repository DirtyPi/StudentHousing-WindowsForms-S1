
namespace ProjectPrototype
{
    partial class RegisterTenant
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbTenantBuilding = new System.Windows.Forms.TextBox();
            this.numTenantRoom = new System.Windows.Forms.NumericUpDown();
            this.btnRegisterTenant = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTenantRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(127, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(125, 27);
            this.tbUsername.TabIndex = 0;
            // 
            // tbTenantBuilding
            // 
            this.tbTenantBuilding.Location = new System.Drawing.Point(127, 104);
            this.tbTenantBuilding.Name = "tbTenantBuilding";
            this.tbTenantBuilding.Size = new System.Drawing.Size(125, 27);
            this.tbTenantBuilding.TabIndex = 1;
            // 
            // numTenantRoom
            // 
            this.numTenantRoom.Location = new System.Drawing.Point(127, 151);
            this.numTenantRoom.Name = "numTenantRoom";
            this.numTenantRoom.Size = new System.Drawing.Size(125, 27);
            this.numTenantRoom.TabIndex = 2;
            // 
            // btnRegisterTenant
            // 
            this.btnRegisterTenant.Location = new System.Drawing.Point(127, 198);
            this.btnRegisterTenant.Name = "btnRegisterTenant";
            this.btnRegisterTenant.Size = new System.Drawing.Size(125, 39);
            this.btnRegisterTenant.TabIndex = 3;
            this.btnRegisterTenant.Text = "Register";
            this.btnRegisterTenant.UseVisualStyleBackColor = true;
            this.btnRegisterTenant.Click += new System.EventHandler(this.btnRegisterTenant_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Building";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(127, 61);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(125, 27);
            this.tbPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 64);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // RegisterTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 314);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRegisterTenant);
            this.Controls.Add(this.numTenantRoom);
            this.Controls.Add(this.tbTenantBuilding);
            this.Controls.Add(this.tbUsername);
            this.Name = "RegisterTenant";
            this.Text = "RegisterTenant";
            ((System.ComponentModel.ISupportInitialize)(this.numTenantRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbTenantBuilding;
        private System.Windows.Forms.NumericUpDown numTenantRoom;
        private System.Windows.Forms.Button btnRegisterTenant;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}