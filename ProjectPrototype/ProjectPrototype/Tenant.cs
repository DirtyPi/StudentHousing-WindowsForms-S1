using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class Tenant
    {

        private int id;
        private string name;
        private int room;
        private string building;

        private static int globalId = 1;

        public Tenant(string givenName, string givenBuilding, int givenRoom)
        {
            this.id = globalId;
            this.name = givenName;
            this.building = givenBuilding;
            this.room = givenRoom;

            globalId++;
        }

        public string GetTenantName()
        {
            return this.name;
        }

        public int GetRoom()
        {
            return this.room;
        }

        public string GetBuilding()
        {
            return this.building;
        }


        public string displayValue()
        {
            return $"ID {id} - {name} - Building {building} - Room {room}";
        }
    }
}
