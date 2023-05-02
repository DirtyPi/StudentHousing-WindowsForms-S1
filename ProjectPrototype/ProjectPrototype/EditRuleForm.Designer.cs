
namespace ProjectPrototype
{
    partial class EditRuleForm
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
            this.tbEditRule = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnUpdateRule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEditRule
            // 
            this.tbEditRule.Location = new System.Drawing.Point(83, 86);
            this.tbEditRule.Name = "tbEditRule";
            this.tbEditRule.Size = new System.Drawing.Size(254, 27);
            this.tbEditRule.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(154, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 46);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(83, 134);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(112, 49);
            this.btnDeleteRule.TabIndex = 2;
            this.btnDeleteRule.Text = "Delete";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnUpdateRule
            // 
            this.btnUpdateRule.Location = new System.Drawing.Point(234, 134);
            this.btnUpdateRule.Name = "btnUpdateRule";
            this.btnUpdateRule.Size = new System.Drawing.Size(103, 49);
            this.btnUpdateRule.TabIndex = 3;
            this.btnUpdateRule.Text = "Update";
            this.btnUpdateRule.UseVisualStyleBackColor = true;
            this.btnUpdateRule.Click += new System.EventHandler(this.btnUpdateRule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Rule";
            // 
            // EditRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateRule);
            this.Controls.Add(this.btnDeleteRule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbEditRule);
            this.Name = "EditRuleForm";
            this.Text = "EditRuleForm";
            this.Load += new System.EventHandler(this.EditRuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEditRule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnUpdateRule;
        private System.Windows.Forms.Label label1;
    }
}