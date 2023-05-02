
namespace ProjectPrototype
{
    partial class LoginPage
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegisterTenant = new System.Windows.Forms.Button();
            this.lblRegisterTenant = new System.Windows.Forms.Label();
            this.btnRegisterAdmin = new System.Windows.Forms.Button();
            this.rbTenant = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.lblAccountSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(114, 106);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(125, 27);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(114, 164);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(125, 27);
            this.tbPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(114, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btnRegisterTenant
            // 
            this.btnRegisterTenant.Location = new System.Drawing.Point(335, 95);
            this.btnRegisterTenant.Name = "btnRegisterTenant";
            this.btnRegisterTenant.Size = new System.Drawing.Size(126, 60);
            this.btnRegisterTenant.TabIndex = 5;
            this.btnRegisterTenant.Text = "Register as tenant";
            this.btnRegisterTenant.UseVisualStyleBackColor = true;
            this.btnRegisterTenant.Click += new System.EventHandler(this.btnRegisterTenant_Click);
            // 
            // lblRegisterTenant
            // 
            this.lblRegisterTenant.AutoSize = true;
            this.lblRegisterTenant.Location = new System.Drawing.Point(345, 59);
            this.lblRegisterTenant.Name = "lblRegisterTenant";
            this.lblRegisterTenant.Size = new System.Drawing.Size(106, 20);
            this.lblRegisterTenant.TabIndex = 6;
            this.lblRegisterTenant.Text = "New member?";
            // 
            // btnRegisterAdmin
            // 
            this.btnRegisterAdmin.Location = new System.Drawing.Point(335, 174);
            this.btnRegisterAdmin.Name = "btnRegisterAdmin";
            this.btnRegisterAdmin.Size = new System.Drawing.Size(126, 56);
            this.btnRegisterAdmin.TabIndex = 7;
            this.btnRegisterAdmin.Text = "Register as admin";
            this.btnRegisterAdmin.UseVisualStyleBackColor = true;
            this.btnRegisterAdmin.Click += new System.EventHandler(this.btnRegisterAdmin_Click);
            // 
            // rbTenant
            // 
            this.rbTenant.AutoSize = true;
            this.rbTenant.Checked = true;
            this.rbTenant.Location = new System.Drawing.Point(61, 69);
            this.rbTenant.Name = "rbTenant";
            this.rbTenant.Size = new System.Drawing.Size(74, 24);
            this.rbTenant.TabIndex = 8;
            this.rbTenant.TabStop = true;
            this.rbTenant.Text = "Tenant";
            this.rbTenant.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(196, 69);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(74, 24);
            this.rbAdmin.TabIndex = 9;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblAccountSelect
            // 
            this.lblAccountSelect.AutoSize = true;
            this.lblAccountSelect.Location = new System.Drawing.Point(129, 35);
            this.lblAccountSelect.Name = "lblAccountSelect";
            this.lblAccountSelect.Size = new System.Drawing.Size(56, 20);
            this.lblAccountSelect.TabIndex = 10;
            this.lblAccountSelect.Text = "I am a..";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.lblAccountSelect);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbTenant);
            this.Controls.Add(this.btnRegisterAdmin);
            this.Controls.Add(this.lblRegisterTenant);
            this.Controls.Add(this.btnRegisterTenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegisterTenant;
        private System.Windows.Forms.Label lblRegisterTenant;
        private System.Windows.Forms.Button btnRegisterAdmin;
        private System.Windows.Forms.RadioButton rbTenant;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Label lblAccountSelect;
    }
}