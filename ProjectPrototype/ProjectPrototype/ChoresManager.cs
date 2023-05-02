using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    class ChoresManager
    {
        private static List<Chore> chores = new List<Chore>();

        public static void Add(Chore chore)
        {
            chores.Add(chore);
        }

        public static void Remove(int index)
        {
            chores.RemoveAt(index);
        }

        public static List<Chore> GetAll()
        {
            return chores;
        }

        public static void Update(Chore chore, int index)
        {
            chores[index] = chore;
        }

        public static Chore Get(int index)
        {
            return chores[index];
        }
    }
}