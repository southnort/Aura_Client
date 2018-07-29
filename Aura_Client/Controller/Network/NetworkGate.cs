using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace Aura_Client.Network
{
    /// <summary>
    /// Предназначен для клиент-серверного взаимодействия.
    /// Отправляет запросы и получает ответы от сервера
    /// </summary>
    class NetworkGate
    {
        private string host;        //IP-адрес сервера
        private int port;     //порт клиента, который нужно слушать       
        private TcpClient client;
        private NetworkStream stream;

        public NetworkGate(string serverIPaddress, int serverPort)
        {
            host = serverIPaddress;
            port = serverPort;
            StartGate();

        }

        private void StartGate()
        {
            client = new TcpClient();
            try
            {
                client.Connect(host, port); //подключение клиента
                stream = client.GetStream(); // получаем поток                

                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(new ThreadStart(ReceivingMessages));
                receiveThread.Start(); //старт потока
                Console.WriteLine("\n" + ToString() + " starting successfuly");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                Disconnect();
            }

        }



        public string SendMessage(string message)
        {
            //отправка сообщений  
            try
            {
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                return ReceiveMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                return "-1";
            }

        }

        private void ReceivingMessages()
        {
            // метод прослушивания порта и получения сообщений
            while (true)
            {
                try
                {
                    string message = ReceiveMessage();
                    HandleMessage(message);

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Connection closed!"); //соединение было прервано
                    Console.ReadLine();                    
                    Disconnect();
                    throw ex;

                }
            }
        }

        private string ReceiveMessage()
        {
            //метод получения одного сообщения
            byte[] data = new byte[64]; // буфер для получаемых данных
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            string message = builder.ToString();

            return message;
        }

        private void HandleMessage(string message)
        {
            Console.WriteLine(message);
        }

        private void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }
    }

}

