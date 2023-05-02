using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class TenantManager
    {
        private static List<Tenant> tenants = new List<Tenant>();


        public static void AddTenant(Tenant tenantToAdd)
        {
            tenants.Add(tenantToAdd);
        }

        public static void RemoveTenant(Tenant tenantToRemove)
        {
            tenants.Remove(tenantToRemove);
        }

        public static void EditTenant(Tenant OldTenant, Tenant newTenant)
        {
            for (int i = tenants.Count - 1; i>=0; --i)
            {
                if(tenants[i] == OldTenant)
                {
                    tenants.RemoveAt(i);
                    tenants.Insert(i, newTenant);
                }
            }
        }

        //public static bool SearchTenant(int room)
        //{
        //    bool foundTenant = false;
        //    foreach(Tenant t in tenants)
        //    {
        //        if(t.GetRoom() == room)
        //        {
        //            foundTenant = true;
        //        }
        //    }

        //    if (foundTenant)
        //    {
        //        return true;
        //    } else
        //    {
        //        return false;
        //    }
        //}

        public List<Tenant> ReturnTenants()
        {
            return tenants;
        }
    }
}
