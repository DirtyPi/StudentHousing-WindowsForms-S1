using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class ChoreManager
    {
        private static List<Chore> choreList = new List<Chore>();

        public static void AddChore(Chore choreToAdd)
        {
            choreList.Add(choreToAdd);
        }

        public static bool RemoveChore(int id)
        {
            bool foundChore = false;
            Chore choreToRemove = null;

            foreach(Chore c in choreList)
            {
                if(c.GetId() == id)
                {
                    choreToRemove = c;
                    foundChore = true;
                }
            }

            if (foundChore)
            {
                choreList.Remove(choreToRemove);
                return true;
            } else
            {
                return false;
            }
        }

        public static List<Chore> ReturnChoreList()
        {
            return choreList;
        }
    }
}
