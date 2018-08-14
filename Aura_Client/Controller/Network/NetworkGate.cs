using System;
using System.Text;
using System.Net;
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
        private int mainPort;       //порт клиента, направляющий запросы серверу         
        private TcpClient client;
        private NetworkStream stream;

        private TcpListener tcpListener;
        private int listenPort;                 //порт клиента, который нужно слушать  
        private NetworkStream listeningStream;




        public NetworkGate(string serverIPaddress, int serverPort, int broadcastPort, MessageHandler handler)
        {
            host = serverIPaddress;
            mainPort = serverPort;
            listenPort = broadcastPort;
            messageHandler = handler;
            StartGate();
            StartListen();
            Console.WriteLine(ToString() + " starting successfuly");

        }

        private void StartGate()
        {
            client = new TcpClient();
            try
            {
                client.Connect(host, mainPort); //подключение клиента
                stream = client.GetStream(); // получаем поток  
                stream.ReadTimeout = 5000;
                

                //// запускаем новый поток для получения данных
                //Thread receiveThread = new Thread(new ThreadStart(ReceivingMessages));
                //receiveThread.Start(); //старт потока




            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void StartListen()
        {
            // запускаем новый поток для получения оповещений от сервера
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, listenPort);
                tcpListener.Start();


                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                listeningStream = tcpClient.GetStream();
                Thread listeningThread = new Thread(new ThreadStart(ReceivingBroadcasts));
                listeningThread.Start();
            }

            catch (Exception ex)
            {
                throw ex;

            }

        }

        private void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();//отключение потока
                stream = null;
            }
            if (client != null)
            {
                client.Close();//отключение клиента
                client = null;
            }

            if (tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
            if (listeningStream != null)
            {
                listeningStream.Close();
                listeningStream = null;
            }
          //  Environment.Exit(0); //завершение процесса
        }

        private void ReceivingBroadcasts()
        {
            // метод постоянного прослушивания порта и получения сообщений без запросов
            while (true)
            {
                try
                {
                    string message = ReceiveBroadcast();
                    Console.WriteLine("Receive broadsactMessage " + message);
                    object ob = ReceiveBroadcastedObject();
                    Console.WriteLine("Receive broadsactObject " + ob.GetType());
                    HandleMessage(message, ob);

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.ToString());
                    Console.WriteLine("Connection closed!"); //соединение было прервано             
                    Disconnect();
                    break;
                    
                    throw ex;

                }
            }
        }

        



        protected internal void SendMessage(string message)
        {
            //отправить сообщение, не требующее ответа
            Console.WriteLine("Sending message: " + message);
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
                throw ex;
            }

        }

        protected internal string GetMessage(string request)
        {
            //отправить запрос, требующий ответа
            try
            {
                SendMessage(request);
                return ReceiveString(stream);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected internal T GetObject<T>(string request)
        {
            //отправить запрос, предполагающий возвращение сериализованного объекта
            try
            {
                SendMessage(request);
                return (T)ReceiveObject(stream);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }





        private string ReceiveString(NetworkStream st)
        {
            //метод получения одного сообщения
            try
            {
                StringBuilder sb = new StringBuilder();

                var data = new byte[64];
                var size = new byte[4];
                int readCount;
                int totalReadMessageBytes = 0;

                st.Read(size, 0, 4);
                int messageLenght = BitConverter.ToInt32(size, 0);

                while ((readCount = st.Read(data, 0, data.Length)) != 0)
                {
                    sb.Append(Encoding.Unicode.GetString(data, 0, readCount));
                    totalReadMessageBytes += readCount;
                    if (totalReadMessageBytes >= messageLenght)
                        break;
                }

                string message = sb.ToString();
                Console.WriteLine("Receive string "+message);
                return message;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object ReceiveObject(NetworkStream st)
        {
            //метод получения сериализованного объекта
            try
            {
                var ms = new MemoryStream();
                var binaryWriter = new BinaryWriter(ms);

                var data = new byte[64];
                var size = new byte[4];
                int readCount;
                int totalReadMessageBytes = 0;

                st.Read(size, 0, 4);
                int messageLenght = BitConverter.ToInt32(size, 0);
                Console.WriteLine("Object size -:" + messageLenght);

                while ((readCount = st.Read(data, 0, data.Length)) != 0)
                {
                    binaryWriter.Write(data, 0, readCount);
                    totalReadMessageBytes += readCount;
                    if (totalReadMessageBytes >= messageLenght)
                        break;
                }

                if (ms.Length > 0)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Console.WriteLine(ms.Length);
                    ms.Seek(0, SeekOrigin.Begin);
                    object ob = bf.Deserialize(ms);
                    Console.WriteLine("REceiving object "+ob.GetType());
                    return ob;
                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        private string ReceiveBroadcast()
        {
            //метод получения одного оповещения
            return ReceiveString(listeningStream);

        }


        private object ReceiveBroadcastedObject()
        {
            return
            ReceiveObject(listeningStream);

        }

        private void Send(byte[] data)
        {
            try
            {
                int size = data.Length;
                byte[] preparedSize = BitConverter.GetBytes(size);

                stream.Write(preparedSize, 0, preparedSize.Length);
                stream.Write(data, 0, data.Length);

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }



        private void HandleMessage(string message, object ob)
        {
            Console.WriteLine("HandleMessage " + message + " " + ob.GetType());
            messageHandler.HandleMessage(message, ob);
        }        


    }

}

