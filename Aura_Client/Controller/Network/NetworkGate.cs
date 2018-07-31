using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Aura_Client.Network
{
    /// <summary>
    /// Предназначен для клиент-серверного взаимодействия.
    /// Устанавливается в программу-клиент.
    /// Передает запросы на сервер. Получает от него ответы.
    /// Передает ответы сервера в MessageHandler
    /// </summary>
    class NetworkGate
    {
        protected internal MessageHandler messageHandler;

        private string host;        //IP-адрес сервера
        private int port;           //порт клиента, который нужно слушать       
        private TcpClient client;
        private NetworkStream stream;
        


        public NetworkGate(string serverIPaddress, int serverPort, MessageHandler handler)
        {
            host = serverIPaddress;
            port = serverPort;
            messageHandler = handler;
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
                Console.WriteLine(ToString() + " starting successfuly");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                Disconnect();
            }

        }

        private void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }

        private void ReceivingMessages()
        {
            // метод постоянного прослушивания порта и получения сообщений без запросов
            while (true)
            {
                try
                {
                    string message = ReceiveString();
                    HandleMessage(message);

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.ToString());
                    Console.WriteLine("Connection closed!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                    throw ex;

                }
            }
        }





        protected internal void SendMessage(string message)
        {
            //отправить сообщение, не требующее ответа
            byte[] data = Encoding.Unicode.GetBytes(message);
            Send(data);

        }

        protected internal void SendObject(object ob)
        {
            //сериализовать и отправить объект. Ответ не требуется
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            try
            {
                bf.Serialize(ms, ob);
                Send(ms.GetBuffer());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ToString() + ".SendObject Exception: " + ex.Message);
            }

        }

        protected internal string GetMessage(string request)
        {
            //отправить запрос, требующий ответа
            try
            {
                SendMessage(request);
                return ReceiveString();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ToString() + ".GetMessage Exception: " + ex.Message);
                return "ERROR";
            }

        }

        protected internal T GetObject<T>(string request)
        {
            //отправить запрос, предполагающий возвращение сериализованного объекта
            try
            {
                SendMessage(request);
                return (T)ReceiveObject();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ToString() + ".GetObject Exception: " + ex.Message);
                return default(T);
            }
        }





        private void Send(byte[] data)
        {
            try
            {
                stream.Write(data, 0, data.Length);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ToString() + ".Send Exception: " + ex.Message);

            }

        }

        private string ReceiveString()
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

        private object ReceiveObject()
        {
            //метод получения сериализованного объекта
            byte[] data = new byte[64];
            int bytes = 0;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            //получаем
            try
            {
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    ms.Write(data, 0, bytes);
                }
                while (stream.DataAvailable);

                ms.Seek(0, SeekOrigin.Begin);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ToString() + "ReceiveObject Exception: " + ex.Message);
                return null;
            }

            //десериализуем
            try
            {
                object ob = bf.Deserialize(ms);
                return ob;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ToString() + "ReceiveObject.Deserialize Exception: " + ex.Message);
                return null;
            }


        }



        private void HandleMessage(string message)
        {
            messageHandler.HandleMessage(message);
        }




    }

}

