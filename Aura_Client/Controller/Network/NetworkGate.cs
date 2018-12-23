using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using LumiSoft.Net.UPnP.NAT; 

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
        private TcpClient tcpClient;
        private NetworkStream stream;

        private TcpListener tcpListener;
        private NetworkStream listeningStream;

        private UPnP_NAT_Client client = new UPnP_NAT_Client();
        



        public NetworkGate(string serverIPaddress, int serverPort, MessageHandler handler)
        {
            host = serverIPaddress;
            mainPort = serverPort;         
            messageHandler = handler;

            TryConnect();
        }

        private void TryConnect()
        {
            if (stream == null)
            {
                try
                {
                    StartGate();                 
                }
                catch
                {
                }
            }
        }

        private void StartGate()
        {
            tcpClient = new TcpClient();

            tcpClient.Connect(host, mainPort); //подключение клиента
            stream = tcpClient.GetStream(); // получаем поток  
            stream.ReadTimeout = 20000;


        }
              
        private void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();//отключение потока
                stream = null;
            }
            if (tcpClient != null)
            {
                tcpClient.Close();//отключение клиента
                tcpClient = null;
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
       
        protected internal void SendMessage(string message)
        {
            //отправить сообщение, не требующее ответа
            Console.WriteLine("\n###################\n"+message);
            byte[] data = Encoding.Unicode.GetBytes(message);
            Send(data);

        }

        protected internal void SendObject(object ob)
        {
            //сериализовать и отправить объект. Ответ не требуется
            Console.WriteLine("\n################\n" + ob.ToString());
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            bf.Serialize(ms, ob);
            Send(ms.GetBuffer());



        }

        protected internal string GetMessage(string request)
        {
            //отправить запрос, требующий ответа
            SendMessage(request);
            return ReceiveString(stream);



        }

        protected internal T GetObject<T>(string request)
        {
            //отправить запрос, предполагающий возвращение сериализованного объекта
            try
            {
                SendMessage(request);
                return (T)ReceiveObject(stream);
            }

            catch
            {
                return default(T);
            }

        }

        protected internal string GetFile(string request, string savingFilePath)
        {
            try
            {
                SendMessage(request);
                string response = ReceiveString(stream);
                ReceiveFile(stream, savingFilePath);
                return response;
            }

            catch (Exception ex)
            {
                return "Ошибка при получении файла: \n" + ex.Message;
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

                Disconnect();

                string message = sb.ToString();
                return message;

            }
            catch
            {
                return "ERROR";
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
                    ms.Seek(0, SeekOrigin.Begin);
                    Disconnect();
                    object ob = bf.Deserialize(ms);
                    return ob;
                }
                else
                {
                    Disconnect();
                    return null;
                }
            }

            catch 
            {
                Disconnect();
                TryConnect();
                return null;
            }

        }

        private void ReceiveFile(NetworkStream st, string filePath)
        {
            //получить бинарный файл и сохранить его на диск


            var ms = new MemoryStream();
            var binaryWriter = new BinaryWriter(ms);

            var data = new byte[64];
            var size = new byte[4];
            int readCount;
            int totalReadMessageBytes = 0;

            st.Read(size, 0, 4);
            int messageLenght = BitConverter.ToInt32(size, 0);

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
                ms.Seek(0, SeekOrigin.Begin);

                var buffer = ms.GetBuffer();
                using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    file.Write(buffer, 0, (int)ms.Length);
                    ms.Close();


                }

            }
            else
            {
                Disconnect();
                TryConnect();

            }

            Disconnect();
        }

       
        private void Send(byte[] data)
        {
            TryConnect();

            int size = data.Length;
            byte[] preparedSize = BitConverter.GetBytes(size);

            if (stream != null)
            {
                Console.WriteLine("Size = " + size);
                stream.Write(preparedSize, 0, preparedSize.Length);
                stream.Write(data, 0, data.Length);
            }   
            
        }



        private void HandleMessage(string message, object ob)
        {
            messageHandler.HandleMessage(message, ob);
        }        


    }

}

