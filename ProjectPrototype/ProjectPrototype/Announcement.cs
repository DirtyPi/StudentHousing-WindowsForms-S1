using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
   public class Announcement
    {
        private string tenant;
        private string announcement;

        public Announcement(string tenant, string announcement)
        {
            this.tenant = tenant;
            this.announcement = announcement;
        }

        public string GetInfo()
        {
            return $"{tenant} - {announcement}";
        }
    }
}
