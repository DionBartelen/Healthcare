using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Threading;

namespace Server
{
    class Session
    {
        TcpClient client;
        NetworkStream stream;
        static int port = 1234;

        public static void ListenToNewConnections(object o)
        {
            IPAddress localhost;
            if (IPAddress.TryParse("127.0.0.1", out localhost))
            {
                TcpListener listener = new TcpListener(localhost, port);
                listener.Start();
                Console.WriteLine("Klaar voor verbindingen...");
                Database.ReadSavedData();
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Thread thread = new Thread(HandleNewClient);
                    thread.Start(client);
                    Console.WriteLine("Verbonden met client: " + client.Client.AddressFamily.ToString());
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error:\r\nKan het IP-adres niet parsen.");
            }
        }

        public static void HandleNewClient(object client)
        {
            if (client == null)
            {
                return;
            }
            else if (!typeof(TcpClient).IsInstanceOfType(client))
            {
                return;
            }
            TcpClient clientTcp = (TcpClient)client;
            Session session = new Session(clientTcp);
            session.Read();
        }

        public Session(TcpClient client)
        {
            this.client = client;
            stream = client.GetStream();
        }

        public void Send(string message)
        {
            System.Diagnostics.Debug.WriteLine("Send: \r\n" + message);
            byte[] prefixArray = BitConverter.GetBytes(message.Length);
            byte[] requestArray = Encoding.Default.GetBytes(message);
            byte[] buffer = new Byte[prefixArray.Length + message.Length];
            prefixArray.CopyTo(buffer, 0);
            requestArray.CopyTo(buffer, prefixArray.Length);
            stream.Write(buffer, 0, buffer.Length);
        }

        public void Read()
        {
            while (true)
            {
                try
                {
                    StringBuilder response = new StringBuilder();
                    int numberOfBytesRead = 0;
                    int totalBytesreceived = 0;
                    int lengthMessage = -1;
                    byte[] receiveBuffer = new byte[1024];
                    bool messagereceived = false;

                    do
                    {
                        numberOfBytesRead = stream.Read(receiveBuffer, 0, receiveBuffer.Length);
                        totalBytesreceived += numberOfBytesRead;
                        string received = Encoding.ASCII.GetString(receiveBuffer, 0, numberOfBytesRead);
                        response.AppendFormat("{0}", received);
                        if (lengthMessage == -1)
                        {
                            if (receiveBuffer.Length >= 4)
                            {
                                Byte[] lengthMessageArray = new Byte[4];
                                Array.Copy(receiveBuffer, 0, lengthMessageArray, 0, 3);
                                lengthMessage = BitConverter.ToInt32(lengthMessageArray, 0);
                                if((totalBytesreceived - 4) == lengthMessage)
                                {
                                    messagereceived = true;
                                }
                            }
                        }
                        else if ((totalBytesreceived - 4) == lengthMessage)
                        {
                            messagereceived = true;
                        }
                    }
                    while (!messagereceived);
                    stream.Flush();
                    string toReturn = response.ToString().Substring(4);
                    System.Diagnostics.Debug.WriteLine("Received: \r\n" + toReturn);
                    ProcesAnswer(toReturn);
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }

        public void ProcesAnswer(dynamic answer)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject(answer);
            try
            {
                if (jsonObject.id == "session/start")
                {
                    Console.WriteLine("New session: " + jsonObject.data.username);
                    CreateNewSession(jsonObject);
                }
                else if (jsonObject.id == "data")
                {
                    Console.WriteLine("Data recieved");
                    DataRecieved(jsonObject);
                }
                else if (jsonObject.id == "start")
                {

                }
                else if (jsonObject.id == "pauze")
                {

                }
                else if (jsonObject.id == "session/end")
                {
                    Console.WriteLine("Session ended with client");
                    CloseSession(jsonObject);
                }
            }
            catch (Exception e)
            {
                dynamic error = new
                {
                    id = "session/start",
                    status = "Error",
                    error = e.Message
                };
                Send(JsonConvert.SerializeObject(error));
            }
        }

        public void CreateNewSession(dynamic jsonObject)
        {
            try
            {
                string username = jsonObject.data.username;
                if (Database.AddActiveSession(username))
                {
                    dynamic answer = new
                    {
                        id = "session/start",
                        data = new
                        {
                            status = "OK",
                            sessionID = username
                        }
                    };
                    Send(JsonConvert.SerializeObject(answer));
                }
                else
                {
                    dynamic answer = new
                    {
                        id = "session/start",
                        data = new
                        {
                            status = "ERROR",
                            error = "Username is al actief. Sluit eerst de andere sessie voor u een nieuwe opent."
                        }
                    };
                    Send(JsonConvert.SerializeObject(answer));
                }
            }
            catch (Exception e)
            {
                dynamic answer = new
                {
                    id = "session/start",
                    status = "Error",
                    error = e.Message
                };
                Send(JsonConvert.SerializeObject(answer));
            }
        }

        public void DataRecieved(dynamic jsonObject)
        {
            try
            {
                string session = jsonObject.session;
                int power = jsonObject.data.power;
                double speed = jsonObject.data.speed;
                int time = jsonObject.data.time;
                int rpm = jsonObject.data.RPM;
                double distance = jsonObject.data.distance;
                int pulse = jsonObject.data.pulse;
                Boolean added = Database.AddErgometerDataToSession(session, new ErgometerData(pulse, rpm, speed, distance, time, 0, 0, power));
                if (added)
                {
                    dynamic answer = new
                    {
                        id = "data",
                        data = new
                        {
                            status = "OK"
                        }
                    };
                    Send(JsonConvert.SerializeObject(answer));
                }
                else
                {
                    dynamic answer = new
                    {
                        id = "data",
                        data = new
                        {
                            status = "ERROR",
                            error = "Geen sessie voor username bekend"
                        }
                    };
                    Send(JsonConvert.SerializeObject(answer));
                }

            }
            catch (Exception e)
            {
                dynamic answer = new
                {
                    id = "data",
                    status = "Error",
                    error = e.Message
                };
                Send(JsonConvert.SerializeObject(answer));
            }
        }

        public void CloseSession(dynamic jsonObject)
        {
            try
            {
                string sessionID = jsonObject.data.session;
                Database.CloseActiveSession(sessionID);
                dynamic answer = new
                {
                    id = "session/end",
                    data = new
                    {
                        status = "OK"
                    }
                };
                Send(JsonConvert.SerializeObject(answer));
                Database.Close();
            }
            catch (Exception e)
            {
                dynamic answer = new
                {
                    id = "session/end",
                    status = "Error",
                    error = e.Message
                };
                Send(JsonConvert.SerializeObject(answer));
                stream.Close();
                client.Close();
            }
        }
    }
}
