using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aura.Model;
using Aura_Client.Model;
using Aura_Client.View;
using Aura_Client.Network;


namespace Aura_Client
{
    class Program
    {
        public static User user = new User();
        public static NetworkBridge bridge = new NetworkBridge();
        public static List<IShowable> openedForms = new List<IShowable>();
        public static DataManager dataManager = new DataManager();
        
        static void Main()
        {
            user.ID = -1;
            try
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                if (user.ID != -1)
                {
                    Console.WriteLine("Autentification successful");
                    var users = bridge.GetObject<Dictionary<string, string>>("USERNAMES");                   
                    var purchases = bridge.GetObject<List<Purchase>>("ALLPURCHASES");
                    var organisations = bridge.GetObject<List<Organisation>>("ALLORGANISATIONS");

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }                

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }

        }





    }

}
