using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aura_Client.Network;


namespace Aura_Client.Controller
{
    /// <summary>
    /// Мост между основной программой и модулем сетевого взаимодействия.
    /// Переводит методы в текст для запроса по сети.
    /// </summary>
    public static class NetworkBridge
    {       
        private static NetworkGate gate;
        


        public static void CreateConnection()
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


        public static void Send(string message)
        {
            //подготовить сообщение и передать воротам для отправки на сервер
            gate.SendMessage("<#" + message + "#>");
        }









        public static void TryLogin(string login, string password)
        {
            //запрос серверу на логин            
            var request = "LOGIN#" + login + "#" + password;
            Send(request);


        }


    }
}
