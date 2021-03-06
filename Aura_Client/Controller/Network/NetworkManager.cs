﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Aura_Client.Network
{
    /// <summary>
    /// Связка между основной программой и модулем сетевого взаимодействия.
    /// Переводит методы в текст для запроса по сети.
    /// </summary>
    abstract class NetworkManager
    {
        protected NetworkGate gate;
        protected MessageHandler messageHandler;

        public NetworkManager()
        {
            messageHandler = new MessageHandler();

            gate = new NetworkGate(
                ConnectionSettings.serverAddress,
                ConnectionSettings.serverPort,
                messageHandler);

        }


        private string PrepareString(string original, string prefix)
        {
            /// <summary>
            /// подготовить строку к отправке на сервер
            /// prefix - тип запроса
            /// 
            /// 1. msg - сообщение не требующее ответа
            /// 2. rqst - сообщение требующее ответа с сервера
            /// 3. sobj - клиент посылает серверу объект
            /// 4. gobj - клиент запрашивает с сервера объект
            /// 5. gfl - клиент запрашивает с сервера файл
            /// </summary>
            /// <param name="original"></param>
            /// <param name="prefix"></param>
            /// <returns></returns>

            return "<#" + prefix + "#" + Program.user.ID + "#" + original + "#>";
        }


        public void SendMessage(string message)
        {
            gate.SendMessage(PrepareString(message, "msg"));
        }

        public string ReceiveMessage(string request)
        {
            return gate.GetMessage(PrepareString(request, "rqst"));
        }

        public void SendObject(string message, object ob)
        {
            gate.SendMessage(PrepareString(message, "sobj"));
            gate.SendObject(ob);
        }

        public T GetObject<T>(string request)
        {
            return gate.GetObject<T>(PrepareString(request, "gobj"));
        }

        public string GetFile(string request, string savingFilePath)
        {
            return gate.GetFile(PrepareString(request, "gfl"), savingFilePath);
        }

    }

}
