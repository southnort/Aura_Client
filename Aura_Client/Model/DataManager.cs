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
        //  private Dictionary<string, Purchase> purchases = new Dictionary<string, Purchase>();
        private List<Purchase> purchases = new List<Purchase>();



        public void SetUserNames(Dictionary<string, string> users)
        {
            userNames = users;
            userNames.Add("0", "<не указано>");
        }

        public void SetPurchases(List<Purchase> purchases)
        {
            this.purchases = purchases;

        }

        public Calendar GetCalendar()
        {
            //возвращает все закупки из БД в виде календаря
            Calendar calendar = new Calendar();
            foreach (var pair in purchases)
            {
                calendar.Add(pair);
            }

            return calendar;

        }


        public void AddPurchase(Purchase pur)
        {
            lock (purchases)
            {
                purchases.Add(pur);
            }           

        }

        public void UpdatePurchase(Purchase pur)
        {
            lock (purchases)
            {
                for (int i = purchases.Count - 1; i >= 0; i--)
                {
                    if (purchases[i].id == pur.id)
                    {
                        purchases[i] = pur;
                        break;
                    }
                }
            }

        }

        public List<Purchase> GetAllPurchases()
        {
            return purchases;
        }

        public Purchase GetPurchase(string id)
        {
            //if (purchases.ContainsKey(id)) return purchases[id];

            //else throw new Exception("Нет закупки с ID= " + id);
            lock (purchases)
            {
                foreach (var item in purchases)
                {
                    if (item.id.ToString() == id)
                        return item;
                }

                throw new Exception("Нет закупки с ID= " + id);
            }
        }

    }
}
