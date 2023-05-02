using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class EditRuleForm : Form
    {
        public EditRuleForm()
        {
            InitializeComponent();
        }

        private AdminForm mainForm = null;
        private string initialValue;
        private string oldRule;
        public EditRuleForm(AdminForm form, string ruleToEdit)
        {
            InitializeComponent();
            mainForm = form;
            tbEditRule.Text = ruleToEdit;
            initialValue = ruleToEdit;
            oldRule = ruleToEdit;
        }

        private void EditRuleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            // Delete rule from the list object as well as from the listbox
            HouseRules.RemoveHouseRule(tbEditRule.Text);
            mainForm.DeleteRule(tbEditRule.Text);
            this.Hide();
        }

        private void btnUpdateRule_Click(object sender, EventArgs e)
        {
            HouseRules.EditRule(oldRule, tbEditRule.Text);
            mainForm.UpdateRule(initialValue, tbEditRule.Text);
            this.Hide();
        }
    }
}
