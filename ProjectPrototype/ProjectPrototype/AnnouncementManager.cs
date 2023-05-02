using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    class AnnouncementManager
    {
        private static List<Announcement> announcements = new List<Announcement>();

        public static void Add(Announcement announcement)
        {
            announcements.Add(announcement);
        }

        public static void Remove(int index)
        {
            announcements.RemoveAt(index);
        }

        public static List<Announcement> GetAll()
        {
            return announcements;
        }
    }
}
