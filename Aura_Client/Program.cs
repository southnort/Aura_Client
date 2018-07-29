using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aura_Client.Model;
using Aura_Client.View;
using Aura_Client.Controller;


namespace Aura_Client
{
    class Program
    {
        public static User user;

        static void Main()
        {
            try
            {
                NetworkBridge.CreateConnection();

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
