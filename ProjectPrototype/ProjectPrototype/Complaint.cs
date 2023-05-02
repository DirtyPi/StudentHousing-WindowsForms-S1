using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectPrototype
{
    public class Complaint
    {

        //private Tenant owner;
        // For demo - use owner as a string / in production add owner as Tenant
        private int id;
        private string owner;
        private string complaint;
        private Boolean resolved;

        private static int globalId;

        public Complaint(string ownerToAdd, string complaintText)
        {
            this.owner = ownerToAdd;
            this.complaint = complaintText;
            this.resolved = false;
            this.id = Interlocked.Increment(ref globalId);
            
        }

        public void MarkAsResolved()
        {
            this.resolved = !this.resolved;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetInfo()
        {
            if (this.resolved)
            {
            return $"ID: {id} / {owner} - {complaint} - resolved";
            } else
            {
                return $"ID: {id} / {owner} - {complaint} - active";
            }
        }
    }
}
