using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectPrototype
{
    public class Agreement
    {
        private int id;
        private string tenant1;
        private string tenant2;
        private int room;
        private string agreement;

        private static int globalId = 1;

        public Agreement(string tenantOne, string tenantTwo, int agreementRoom, string agreementText)
        {
            this.tenant1 = tenantOne;
            this.tenant2 = tenantTwo;
            this.room = agreementRoom;
            this.agreement = agreementText;

            this.id = 1;
            globalId++;
        }

        public string GetText()
        {
            return this.agreement;
        }

        public int GetId()
        {
            return this.id;
        }

        public string ReturnFirstTenant()
        {
            return this.tenant1;
        }

        public string ReturnSecondTenant()
        {
            return this.tenant2;
        }

        // Placeholder, should include all info realted to tenant such as building, name and room
        public string GetInfo()
        {
            return $"ID: {id} / {tenant1} (Room 33) - {tenant2} (Room 29) / {agreement}";
        }
    }
}
