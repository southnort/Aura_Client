using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Model;

namespace Aura_Client.Model
{
    class DataManager
    {
        public List<User> GetAllUsers()
        {
            return Program.bridge.GetObject<List<User>>("ALLUSERS");
        }

        public Dictionary<string, string> GetUserNames()
        {
            return Program.bridge.GetObject<Dictionary<string, string>>("USERNAMES");
        }

        public User GetUser(string id)
        {

        }
       

        public List<Purchase> GetAllPurchases()
        {
            return Program.bridge.GetObject<List<Purchase>>("ALLPURCHASES");

        }

        public Purchase GetPurchase(string id)
        {
           
        }

        public Calendar GetCalendar()
        {
            //возвращает все закупки из БД в виде календаря
            Calendar calendar = new Calendar();
            foreach (var pair in GetAllPurchases())
            {
                calendar.Add(pair);
            }

            return calendar;

        }


        public List<Organisation> GetAllOrganisations()
        {
            return Program.bridge.GetObject<List<Organisation>>("ALLORGANISATIONS");
        }       
        
        public Organisation GetOrganisation(string id)
        {
           

        }

    }
}