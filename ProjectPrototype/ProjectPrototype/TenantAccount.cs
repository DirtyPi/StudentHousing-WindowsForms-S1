using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class TenantAccount
    {
        private int id;
        private string username;
        private string password;
        private string building;
        private int roomNo;

        private List<Agreement> unconfirmedAgreements = new List<Agreement>();

        private static int globalId = 1;

        public TenantAccount(string user, string pass, string buildingName, int roomNr)
        {
            this.id = globalId;
            this.username = user;
            this.password = pass;
            this.building = buildingName;
            this.roomNo = roomNr;

            globalId++;
        }

        public string Building
        {
            get { return this.building; }
            set { this.building = value; }
        }
        public int RoomNo
        {
            get { return this.roomNo; }
            set { this.roomNo = value; }
        }

        public string displayUser()
        {
            return this.username;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetBuilding()
        {
            return this.building;
        }

        public int GetRoom()
        {
            return this.roomNo;
        }

        public string GetUserInfo()
        {
            return $"ID {id} / {username} - Building {building} - Room {roomNo}";
        }

        public void AddAgreement(Agreement agreementToAdd)
        {
            unconfirmedAgreements.Add(agreementToAdd);
        }

        public List<Agreement> ReturnUnconfirmedAgreements()
        {
            return unconfirmedAgreements;
        }

        public  void RemoveAgreement(Agreement agreementToRemove)
        {
            unconfirmedAgreements.Remove(agreementToRemove);
        }

        public bool VerifyAccount(string user, string pass)
        {
            if(username == user && password == pass)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
