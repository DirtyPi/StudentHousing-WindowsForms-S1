using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPrototype
{
    public partial class AddComplaint : Form
    {
        TenantForm mainForm = null;
        public AddComplaint(TenantForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        public AddComplaint()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Complaint newComplaint = new Complaint(tbOwner.Text, tbComplaint.Text);
            ComplaintManager.AddComplaint(newComplaint);

            if (mainForm != null)
            {
                mainForm.RefreshListbox("complaint");
                this.Hide();
            }
        }

    }
}
