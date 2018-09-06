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
            List<User> users = new List<User>();
            users.Add(new User { name = "<не указано>", ID = 0 });
            foreach (var user in Program.bridge.GetObject<List<User>>("ALLUSERS"))
            {
                users.Add(user);
            }

            return users;

        }

        public Dictionary<string, string> GetUserNames()
        {
            var userNames = new Dictionary<string, string>();
            userNames.Add("0", "<не указано>");

            foreach (var pair in Program.bridge.GetObject<Dictionary<string, string>>("USERNAMES"))
            {
                userNames.Add(pair.Key, pair.Value);
            }

            return userNames;

        }

        public User GetUser(string id)
        {
            return Program.bridge.GetObject<User>("GETUSER#" + id);
        }



        public List<Purchase> GetAllPurchases()
        {
            var purchases = new List<Purchase>();
            foreach (var pur in Program.bridge.GetObject<List<Purchase>>("ALLPURCHASES"))
            {
                purchases.Add(pur);
            }

            return purchases;
        }

        public Purchase GetPurchase(string id)
        {
            return Program.bridge.GetObject<Purchase>("GETPURCHASE#" + id);
        }

        public Calendar GetCalendar()
        {
            //возвращает все закупки из БД в виде календаря
            Calendar calendar = new Calendar();
            foreach (var purchase in GetAllPurchases())
            {
                calendar.Add(purchase);
            }

            return calendar;

        }

        public List<Purchase> GetReestr()
        {
            return Program.bridge.GetObject<List<Purchase>>("GETREESTR");

        }

        public void DeletePurchase(string id)
        {
            Program.bridge.SendMessage("DELETEPURCHASE#" + id);
        }



        public List<Organisation> GetAllOrganisations()
        {
            var list = new List<Organisation>();
            foreach (var org in Program.bridge.GetObject<List<Organisation>>("ALLORGANISATIONS"))
            {
                list.Add(org);
            }
            return list;
        }

        public Organisation GetOrganisation(string id)
        {
            return Program.bridge.GetObject<Organisation>("GETORGANISATION#" + id);

        }

        public List<Organisation> GetFilteredOrganisations(string filterQuery)
        {
            //запросить с сервера список организаций, отфильтрованных по усоловиям
            return Program.bridge.GetObject<List<Organisation>>("GETFILTEREDORGANISATIONS#" + filterQuery);



        }

        public void DeleteOrganisation(string id)
        {
            Program.bridge.SendMessage("DELETEORGANISATION#" + id);
        }


        public List<Report> GetAllReports()
        {
            var list = Program.bridge.GetObject<List<Report>>("ALLREPORTS");
            return list;
        }

    }
}