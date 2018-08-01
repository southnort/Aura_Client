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
        public static Dictionary<string, string> users;
        public static Dictionary<string, Purchase> purchases;





        static void Main()
        {
            user.ID = -1;
            try
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                if (user.roleID > -1)
                {
                    Console.WriteLine("Аутентификация успешна!");
                    Console.Read();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }

            Console.Read();
        }





    }

}
