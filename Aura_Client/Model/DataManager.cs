using Aura.Model;
using System.Collections.Generic;
using System.Data;


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

        public List<Purchase> GetFilteredPurchases(string filterQuery)
        {
            //Запросить с сервера список закупок, отфильтрованных по условиям

            var dataTable = Program.bridge.GetObject<DataTable>("GETDATATABLE#" + filterQuery);
            List<Purchase> purchases = new List<Purchase>();

            foreach (DataRow row in dataTable.Rows)
            {
                purchases.Add(new Purchase(row));
            }

            return purchases;
        }

        public Purchase GetPurchase(string id)
        {
            return Program.bridge.GetObject<Purchase>("GETPURCHASE#" + id);
        }        

        public List<Purchase> GetReestr(string filterQuery)
        {
            return Program.bridge.GetObject<List<Purchase>>("GETREESTR#" + filterQuery);

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


        public ReportsList GetReportsList()
        {
            var list = Program.bridge.GetObject<ReportsList>("ALLREPORTS");

            return list;
        }

        public Contract GetContract(string id)
        {
            string query = "SELECT * FROM Contracts WHERE id = '" + id+"'";

            var table = GetDataTable(query);
            var row = table.Rows[0];

            return new Contract(row);

        }
           
        public DataTable GetDataTable(string query)
        {
            //запрос от сервера любой информации
            return Program.bridge.GetObject<DataTable>("GETDATATABLE#" + query);

        }

        public T GetValue<T>(string query)
        {
            //запрос с сервера одиночного значения
            return Program.bridge.GetObject<T>("GETITEM#" + query);
        }


        public DataTable GetLogs(string query)
        {
            //запросить с сервера журнал обработки документа в виде таблицы
            return Program.bridge.GetObject<DataTable>("GETLOGS#" + query);
        }



        public void DeleteContract(string id)
        {
            Program.bridge.SendMessage("EXECUTECOMMAND#DELETE FROM Contracts WHERE id ='" + id + "'");
        }

        public string GetExcelFile(string filePath, string sqlCommand)
        {            
           return Program.bridge.GetFile("GETXLFILE#" + sqlCommand, filePath);
        }

    }
}