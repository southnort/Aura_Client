using System.IO;
using System.Collections.Generic;


public class ConnectionSettings
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

    }




}

