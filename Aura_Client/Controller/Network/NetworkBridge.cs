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


        public void TryLogin(string login, string password)
        {
            //запрос серверу на логин            
            var request = "LOGIN#" + login + "#" + password;
            messageHandler.HandleMessage(ReceiveMessage(request));

        }


    }
}
