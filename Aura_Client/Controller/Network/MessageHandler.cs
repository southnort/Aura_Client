using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Network
{
    /// <summary>
    /// Класс предназначен для обработки полученных сообщений от клиентов.     
    /// </summary>
    class MessageHandler
    {
        protected internal string HandleMessage(string message, object ob)
        {
            Console.WriteLine("HandleMessage " + message);
            //обработать полученное сообщение и ответить клиенту
            List<string> arr = SplitString(message);
            switch (arr[0])
            {
                case "LOGINFAILED": break;

                case "LOGINSUCCESS":
                    LoginSuccess(arr); break;

                case "NEWPURCHASE":
                    NewPurchase(ob); break;

                case "UPDATEPURCHASE":
                    UpdatePurchase(ob); break;


                default: Console.WriteLine("ERROR string is incorrect:\n " + message); break;
            }

            return arr[0];

        }

        private List<string> SplitString(string message)
        {
            //разделить строку и убрать служебные символы
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
            lock (Program.user)
            {
                string userName = str[1];
                string userRoleID = str[2];
                string userID = str[3];
                Program.user.name = userName;
                Program.user.roleID = int.Parse(userRoleID);
                Program.user.ID = int.Parse(userID);
            }

        }

        private void NewPurchase(object ob)
        {
            var pur = (Aura.Model.Purchase)ob;
            Program.dataManager.AddPurchase(pur);

        }

        private void UpdatePurchase(object ob)
        {
            var pur = (Aura.Model.Purchase)ob;
            Program.dataManager.UpdatePurchase(pur);

        }


    }

}
