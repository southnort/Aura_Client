using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Controller
{
    /// <summary>
    /// Класс предназначен для обработки полученных сообщений от клиентов.    /// 
    /// </summary>
    class MessageHandler
    {
        protected internal void HandleMessage(string message)
        {
            //обработать полученное сообщение и ответить клиенту
            List<string> arr = SplitString(message);
            switch (arr[0])
            {
                case "LOGINFAILED":
                    Program.SetLoginResult(arr[0]); break;

                case "LOGINSUCCESS":
                    LoginSuccess(arr); break;



                default: Console.WriteLine("ERROR#No such command " + arr[0]); break;
            }

        }

        private List<string> SplitString(string message)
        {
            List<string> result = new List<string>();
            message = message.Replace("<", "").Replace(">", "");
            foreach (var str in message.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries))
            {
                result.Add(str.Replace("#", ""));
            }

            return result;

        }


        private void LoginSuccess(List<string> str)
        {
            string userName = str[1];
            string userRoleID = str[2];
            Program.user.name = userName;
            Program.user.roleID = int.Parse(userRoleID);

            Program.SetLoginResult(str[0]);
        }


    }
}
