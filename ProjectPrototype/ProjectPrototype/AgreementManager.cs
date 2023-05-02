using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class AgreementManager
    {
        private static List<Agreement> agreementList = new List<Agreement>();

        public static void AddAgreement(Agreement agreementConditions)
        {
            agreementList.Add(agreementConditions);
        }

        public static bool RemoveAgreement(int id)
        {
            bool agreeementFound = false;
            Agreement agreementToRemove = null;
            foreach(Agreement a in agreementList)
            {
                if(a.GetId() == id)
                {
                    agreementToRemove = a;
                    agreeementFound = true;
                }
            }

            if (agreeementFound)
            {
                agreementList.Remove(agreementToRemove);
                return true;
            } else
            {
                return false;
            }
        }

        public static void EditAgreement(Agreement OldAgreement, Agreement newAgreement)
        {
            for (int i = agreementList.Count - 1; i >= 0; --i)
            {
                if (agreementList[i] == OldAgreement)
                {
                    agreementList.RemoveAt(i);
                    agreementList.Insert(i, newAgreement);
                }
            }
        }

        public static bool RequestAgreement(Agreement agreementToRequest, int room)
        {
            bool foundTenant = false;

            foreach(TenantAccount t in AccountsManager.ReturnTenantAccounts())
            {
                if(t.GetRoom() == room)
                {
                    t.AddAgreement(agreementToRequest);
                    foundTenant = true;
                }
            }

            if (foundTenant)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool SearchAgreement(int id, TenantAccount tenant)
        {
            Agreement agreementToConfirm = null;
            bool foundAgreement = false;
            foreach (Agreement a in tenant.ReturnUnconfirmedAgreements())
            {
                if (a.GetId() == id)
                {
                    foundAgreement = true;
                    agreementToConfirm = a;
                }
            }

            if (foundAgreement)
            {
                tenant.RemoveAgreement(agreementToConfirm);
                agreementList.Add(agreementToConfirm);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Agreement> ReturnAgreementList()
        {
            return agreementList;
        }

    }
}
