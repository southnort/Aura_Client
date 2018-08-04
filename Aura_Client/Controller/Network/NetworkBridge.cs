using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aura_Client.Network;


namespace Aura_Client.Network
{
    /// <summary>
    /// Мост между основной программой и модулем сетевого взаимодействия.
    /// Переводит методы в текст для запроса по сети.
    /// </summary>
    class NetworkBridge : NetworkManager
    {


        public string TryLogin(string login, string password)
        {
            //запрос серверу на логин            
            var request = "LOGIN#" + login + "#" + password;
            return messageHandler.HandleMessage(ReceiveMessage(request), null);

        }

        public void SendUser(Aura.Model.User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("USER#");
            sb.Append(user.ID);
            sb.Append("#");
            sb.Append(user.name);
            sb.Append("#");
            sb.Append(user.login);
            sb.Append("#");
            sb.Append(user.password);
            sb.Append("#");
            sb.Append(user.roleID);

            SendMessage(sb.ToString());

        }
    }
}
