using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
   public class Chore
    {
        private int id;
        private string tenant;
        private string day;
        private string task;

        public static int globalId = 1;

        public Chore(string day, string task, string currentTenant)
        {
            this.id = globalId;
            this.tenant = currentTenant;
            this.day = day;
            this.task = task;
            globalId++;

        }

        public int GetId()
        {
            return id;
        }

        public string GetInfo()
        {
            return $"ID {id} / {tenant} does {task} on {day}";
        }
    }
}
