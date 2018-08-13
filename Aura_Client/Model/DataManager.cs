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
            var dictionary = Program.bridge.GetObject<Dictionary<string, string>>("USERNAMES");
            dictionary.Add("0", "<не указано>");
            return dictionary;
        }

        public User GetUser(string id)
        {
            return Program.bridge.GetObject<User>("GETUSER#"+id);
        }

       

        public List<Purchase> GetAllPurchases()
        {
            return Program.bridge.GetObject<List<Purchase>>("ALLPURCHASES");

        }

        public Purchase GetPurchase(string id)
        {
            return Program.bridge.GetObject<Purchase>("GETPURCHASE#" + id);
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
            var list = Program.bridge.GetObject<List<Organisation>>("ALLORGANISATIONS");
            list.Insert(0, new Organisation { name = "<не указано>" });
            return list;
        }       
        
        public Organisation GetOrganisation(string id)
        {
            return Program.bridge.GetObject<Organisation>("GETORGANISATION#" + id);

        }

    }
}