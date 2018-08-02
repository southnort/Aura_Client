using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Model;

namespace Aura_Client.Model
{
    class DataManager
    {
        public Dictionary<string, string> userNames = new Dictionary<string, string>();
        public Dictionary<string, Purchase> purchases = new Dictionary<string, Purchase>();
       

        public void SetUserNames(Dictionary<string, string> users)
        {
            userNames = users;
            userNames.Add("0", "<не указано>");
        }

        public void SetPurchases(Dictionary<string, Purchase> purchases)
        {
            this.purchases = purchases;
            purchases.Add("0", null);
           
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


       

    }
}
