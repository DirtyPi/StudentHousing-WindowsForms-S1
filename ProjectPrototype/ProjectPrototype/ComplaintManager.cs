using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class ComplaintManager
    {
        private static List<Complaint> complaintList = new List<Complaint>();

        public static void AddComplaint(Complaint complaintToAdd)
        {
            complaintList.Add(complaintToAdd);
        }

        public static bool MarkComplaint(int id)
        {
            bool complaintFound = false;
            foreach(Complaint c in complaintList)
            {
                if(c.GetId() == id)
                {
                    c.MarkAsResolved();
                    complaintFound = true;
                }
            }

            if(complaintFound)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool RemoveComplaint(int id)
        {
            bool complaintFound = false;
            Complaint complaintToRemove = null;
            foreach (Complaint c in complaintList)
            {
                if (c.GetId() == id)
                {
                    complaintToRemove = c;
                    complaintFound = true;
                }
            }

            if (complaintFound)
            {
                complaintList.Remove(complaintToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UpdateList(List<Complaint> newCompList)
        {
            complaintList = newCompList;
        }

        public static List<Complaint> ReturnComplaintList()
        {
            return complaintList;
        }
    }


}
