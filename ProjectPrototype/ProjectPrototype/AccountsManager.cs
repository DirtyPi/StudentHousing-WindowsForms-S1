using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPrototype
{
    public class AccountsManager
    {
        private static List<TenantAccount> tenantAccounts = new List<TenantAccount>();
        private static List<AdminAccount> adminAccounts = new List<AdminAccount>();


        public static void AddTenantAccount(TenantAccount accountToAdd)
        {
            tenantAccounts.Add(accountToAdd);
        }
        public static void AddAdminAccount(AdminAccount accountToAdd)
        {
            adminAccounts.Add(accountToAdd);
        }

        public static bool RemoveTenantAccount(int id)
        {
            TenantAccount tenantToRemove = null;
            bool foundTenant = false;
            foreach (TenantAccount t in tenantAccounts)
            {
                if(t.GetId() == id)
                {
                    tenantToRemove = t;
                    foundTenant = true;
                }
            }

            if (foundTenant)
            {
                tenantAccounts.Remove(tenantToRemove);
                return true;
            } else
            {
                return false;
            }
        }

        public static bool UpdateTenant(int id, string building, int room)
        {
            bool wasUpdated = false;
            foreach(TenantAccount t in tenantAccounts)
            {
                if(t.GetId() == id)
                {
                    t.Building = building;
                    t.RoomNo = room;
                    wasUpdated = true;
                }
            }

            if (wasUpdated)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool SearchTenant(int room)
        {
            bool foundTenant = false;
            foreach (TenantAccount t in tenantAccounts)
            {
                if (t.GetRoom() == room)
                {
                    foundTenant = true;
                }
            }

            if (foundTenant)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static TenantAccount SearchById(int id)
        {
            bool foundTenant = false;
            TenantAccount tenantSelected = null;
            foreach (TenantAccount t in tenantAccounts)
            {
                if (t.GetId() == id)
                {
                    tenantSelected = t;
                    foundTenant = true;
                }
            }

            if (foundTenant)
            {
                return tenantSelected;
            }
            else
            {
                return null;
            }
        }

        public static List<TenantAccount> ReturnTenantAccounts()
        {
            return tenantAccounts;
        }
        
        public static List<AdminAccount> ReturnAdminAccounts()
        {
            return adminAccounts;
        }

        public static TenantAccount ReturnTenantWithAgreements(string name)
        {
            foreach(TenantAccount t in tenantAccounts)
            {
                if(t.displayUser() == name)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
