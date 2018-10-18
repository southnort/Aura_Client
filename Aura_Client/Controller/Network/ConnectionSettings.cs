﻿using System.Collections.Generic;
using System.IO;

namespace Aura_Client.Network
{
    internal static class ConnectionSettings
    {
        // настройки соединения с сервером

        private static string _serverAddress;
        internal static string serverAddress
        {
            get
            {
                if (_serverAddress == null || _serverAddress == string.Empty)
                    ReadConnectSettingsFile();

                return _serverAddress;
            }
        }


        private static int _serverPort;
        internal static int serverPort
        {
            get
            {
                if (_serverPort == 0)
                    ReadConnectSettingsFile();

                return _serverPort;
            }
        }


        private static int _broadcastPort;
        internal static int broadcastPort
        {
            get
            {
                if (_broadcastPort == 0)
                    ReadConnectSettingsFile();

                return _broadcastPort;
            }

        }



        //прочитать указанный файл и взять настройки для подключения к серверу  
        private static void ReadConnectSettingsFile()
        {
            List<string> connectionSettings = new List<string>();
            using (StreamReader sr = new StreamReader("connect settings.txt"))
            {
                while (!sr.EndOfStream)
                    connectionSettings.Add(sr.ReadLine());
            }

            _serverAddress = connectionSettings[0];
            _serverPort = int.Parse(connectionSettings[1]);
            _broadcastPort = int.Parse(connectionSettings[2]);
            
        }



    }
}
