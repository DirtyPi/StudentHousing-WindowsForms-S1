
namespace ProjectPrototype
{
    partial class EditAgreement
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
            this.tbAgreementText = new System.Windows.Forms.TextBox();
            this.btnEditAgreement = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrentAgreement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAgreementText
            // 
            this.tbAgreementText.Location = new System.Drawing.Point(58, 79);
            this.tbAgreementText.Name = "tbAgreementText";
            this.tbAgreementText.Size = new System.Drawing.Size(190, 27);
            this.tbAgreementText.TabIndex = 0;
            // 
            // btnEditAgreement
            // 
            this.btnEditAgreement.Location = new System.Drawing.Point(85, 124);
            this.btnEditAgreement.Name = "btnEditAgreement";
            this.btnEditAgreement.Size = new System.Drawing.Size(125, 61);
            this.btnEditAgreement.TabIndex = 1;
            this.btnEditAgreement.Text = "Edit agreement";
            this.btnEditAgreement.UseVisualStyleBackColor = true;
            this.btnEditAgreement.Click += new System.EventHandler(this.btnEditAgreement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(85, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 55);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCurrentAgreement
            // 
            this.lblCurrentAgreement.AutoSize = true;
            this.lblCurrentAgreement.Location = new System.Drawing.Point(85, 39);
            this.lblCurrentAgreement.Name = "lblCurrentAgreement";
            this.lblCurrentAgreement.Size = new System.Drawing.Size(133, 20);
            this.lblCurrentAgreement.TabIndex = 3;
            this.lblCurrentAgreement.Text = "Current agreement";
            // 
            // EditAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 330);
            this.Controls.Add(this.lblCurrentAgreement);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditAgreement);
            this.Controls.Add(this.tbAgreementText);
            this.Name = "EditAgreement";
            this.Text = "EditAgreement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAgreementText;
        private System.Windows.Forms.Button btnEditAgreement;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrentAgreement;
    }
}