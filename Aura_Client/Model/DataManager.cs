using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Model;

namespace Aura_Client.Model
{
    class DataManager
    {
        private Dictionary<string, string> userNames = new Dictionary<string, string>();
        private Dictionary<string, Purchase> purchases = new Dictionary<string, Purchase>();
       

        public void SetUserNames(Dictionary<string, string> users)
        {
            userNames = users;
            
        }

        public void SetPurchases(Dictionary<string, Purchase> purchases)
        {
            this.purchases = purchases;
           
        }

        public Calendar GetCalendar()
        {
            //возвращает все закупки из БД в виде календаря
            Calendar calendar = new Calendar();
            foreach (var pair in purchases)
            {
                calendar.Add(pair.Value);
            }

            return calendar;

        }


        public List<string> UserNames()
        {
            return userNames.Values.ToList<string>();
        }

        public List<Purchase> Purchases()
        {
            return purchases.Values.ToList<Purchase>();
        }

    }
}
