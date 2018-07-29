using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aura_Client.Network;
using System.IO;


namespace Aura_Client.Controller
{
    /// <summary>
    /// Мост между основной программой и модулем сетевого взаимодействия.
    /// Переводит методы в текст для запроса по сети.
    /// Обрабатывает поступившие сетевые запросы и выполняет необходимые методы.
    /// </summary>
    public static class NetworkBridge
    {
        private static NetworkGate gate;       


        public static void  CreateConnection()
        {
            //вместо конструктора
            try
            {
                //прочитать указанный файл и взять настройки для подключения к серверу   
                List<string> connectionSettings = new List<string>();
                using (StreamReader sr = new StreamReader("connect settings.txt"))
                {
                    while (!sr.EndOfStream)
                        connectionSettings.Add(sr.ReadLine());
                }
                    
                gate = new NetworkGate(connectionSettings[0],
                    int.Parse(connectionSettings[1]));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
               
            }
        }



        
        public static string Send(string message)
        {
            //подготовить сообщение и передать воротам для отправки на сервер
            return gate.SendMessage("<#" + message + "#>");
        }

        private static string[] SplitString(string str)
        {
            //разбить полученную от сервера строку на подстроки
            str = str.Replace("<", "").Replace(">", "");

            if (str.Contains("#"))
            {
                return str.Split('#');
            }

            else
            {
                return new string[] { str, };
            }

        }



        public static int TryLogin(string login, string password)
        {
            //запрос серверу на логин            
            var request = "LOGIN#" + login + "#" + password;
            var response = SplitString(Send(request));
            if (response[0] == "-1")
            {
                //ошибочный запрос
                return -1;
            }

            else if (response[0] == "0")
            {
                //неправильный пароль
                return 0;
            }

            else
            {
                //аутентификация успешна. Присвоить имя и права доступа
                int id = int.Parse(response[0]);
                int roleID = int.Parse(response[1]);
                InitializeUser(response[1], id, roleID);
                return id;

            }

        }

        private static void InitializeUser(string userName, int userID, int roleID)
        {
            //в случае успешного логина
            Program.user.name = userName;
            Program.user.ID = userID;
            Program.user.roleID = roleID;

        }

    }
}
