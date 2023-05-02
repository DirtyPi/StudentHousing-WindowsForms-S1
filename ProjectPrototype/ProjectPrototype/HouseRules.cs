using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPrototype
{
    public class HouseRules
    {
        static List<string> rules = new List<string>();

        public HouseRules()
        {
            ReloadRules();
        }

        public static void AddHouseRule(string rule)
        {
            System.IO.File.AppendAllText(@"database/Rules.txt", rule + Environment.NewLine);
            ReloadRules();
        }
        private static void ReloadRules()
        {
            List<string> temp = System.IO.File.ReadLines(@"database/Rules.txt").ToList();
            rules.Clear();
            foreach (string a in temp)
            {
                rules.Add(a);
            }
        }

        public static void RemoveHouseRule(string rule)
        {
            rules.Remove(rule);
        }

        public static void EditRule(string oldRule, string newRule)
        {
            for (int i = rules.Count - 1; i >= 0; --i)
            {
                if(rules[i] == oldRule)
                {
                    rules.RemoveAt(i);
                    rules.Insert(i, newRule);
                }
            }
        }

        public static List<string> GetHouseRules()
        {
            return rules;
        }
    };
}
