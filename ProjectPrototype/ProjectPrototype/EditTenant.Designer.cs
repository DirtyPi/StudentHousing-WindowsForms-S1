
namespace ProjectPrototype
{
    partial class EditTenant
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
            this.tbBuilding = new System.Windows.Forms.TextBox();
            this.numRoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteTenant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(201, 53);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(125, 27);
            this.tbUsername.TabIndex = 0;
            // 
            // tbBuilding
            // 
            this.tbBuilding.Location = new System.Drawing.Point(201, 96);
            this.tbBuilding.Name = "tbBuilding";
            this.tbBuilding.Size = new System.Drawing.Size(125, 27);
            this.tbBuilding.TabIndex = 1;
            // 
            // numRoom
            // 
            this.numRoom.Location = new System.Drawing.Point(201, 140);
            this.numRoom.Name = "numRoom";
            this.numRoom.Size = new System.Drawing.Size(125, 27);
            this.numRoom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tenant Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tenant Building";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tenant Room";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(73, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 56);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 56);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteTenant
            // 
            this.btnDeleteTenant.Location = new System.Drawing.Point(140, 268);
            this.btnDeleteTenant.Name = "btnDeleteTenant";
            this.btnDeleteTenant.Size = new System.Drawing.Size(121, 56);
            this.btnDeleteTenant.TabIndex = 8;
            this.btnDeleteTenant.Text = "Delete Tenant";
            this.btnDeleteTenant.UseVisualStyleBackColor = true;
            this.btnDeleteTenant.Click += new System.EventHandler(this.btnDeleteTenant_Click);
            // 
            // EditTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 336);
            this.Controls.Add(this.btnDeleteTenant);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRoom);
            this.Controls.Add(this.tbBuilding);
            this.Controls.Add(this.tbUsername);
            this.Name = "EditTenant";
            this.Text = "EditTenant";
            this.Load += new System.EventHandler(this.EditTenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbBuilding;
        private System.Windows.Forms.NumericUpDown numRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteTenant;
    }
}