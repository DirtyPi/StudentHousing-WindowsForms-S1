using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class AddRuleForm : Form
    {
        HouseRules newHouseRule = null;
        public AddRuleForm()
        {
            InitializeComponent();
        }

        private AdminForm mainForm = null;
        public AddRuleForm(AdminForm form, HouseRules houseRules)
        {
            mainForm = form;
            newHouseRule = houseRules;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            if(tbRule.Text != "")
            {
                HouseRules.AddHouseRule(tbRule.Text);
                mainForm.IterateOverRules(newHouseRule);

                this.Hide();
            }
        }
    }
}
