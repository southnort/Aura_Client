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
        private List<Purchase> purchases = new List<Purchase>();
        private List<Organisation> organisations = new List<Organisation>();



        public void SetUserNames(Dictionary<string, string> users)
        {
            userNames.Add("0", "<не указано>");
            foreach (var us in users)
            {
                userNames.Add(us.Key, us.Value);
            }

        }

        public void SetPurchases(List<Purchase> purchases)
        {
            this.purchases = purchases;

        }

        public void SetOrganisations(List<Organisation> organisations)
        {
            this.organisations.Add(new Organisation() { id = 0, name = "<не указано>", });
            foreach (var org in organisations)
            {
                this.organisations.Add(org);
            }
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



        public void AddOrganisation(Organisation organisation)
        {
            lock (organisations)
            {
                organisations.Add(organisation);
            }
        }

        public void UpdateOrganisation(Organisation organisation)
        {
            lock (organisations)
            {
                for (int i = organisations.Count - 1; i >= 0; i--)
                {
                    if (organisations[i].id == organisation.id)
                    {
                        organisations[i] = organisation;
                        break;
                    }
                }
            }
        }

        public List<Organisation> GetAllOrganisations()
        {
            return organisations;
        }

        public Organisation GetOrganisation(string id)
        {
            lock (organisations)
            {
                foreach (var item in organisations)
                {
                    if (item.id.ToString() == id)
                        return item;
                }

                throw new Exception("Нет организации с ID= " + id);
            }
        }

    }
}