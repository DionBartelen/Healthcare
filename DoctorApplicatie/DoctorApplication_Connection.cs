using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoctorApplicatie
{
    public class DoctorApplication_Connection
    {
        NetworkStream stream;
        int port = 1234;
        TcpClient client;
        IPAddress localhost;
        SerialPort serialPort;
        Boolean isConnected;
        public DoctorApplication_Connection(string username, string password)
        {
            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);
            if (!ipIsOk) { Console.WriteLine("ip adres kan niet geparsed worden."); Environment.Exit(1); }
            client = new TcpClient(localhost.ToString(), port);
            stream = client.GetStream();
            isConnected = true;
            Thread read = new Thread(Read);
            read.Start();
            sendLogin(username, password);
        }

        public void Read()
        {
            while (isConnected)
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
                                if ((totalBytesreceived - 4) == lengthMessage)
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
                    ProcessAnswer(toReturn);

                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }
        public void ProcessAnswer(string information)
        {
            dynamic jsonData = JsonConvert.DeserializeObject(information);
            if(jsonData.id == "doctor/login")
            {
                new DoctorApplication_Session(this, null); 

            }

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

        public void sendLogin(string username, string password)
        {
            dynamic sendLogin = new
            {
                id = "doctor/login",
                data = new
                {
                    username = username,
                    password = password
                }

            };

            Send(JsonConvert.SerializeObject(sendLogin));
        }

        public void startTraining()
        {
            dynamic startTraining = new
            {
                id = "doctor/training/start",
                data = new
                {
                    
                }

            };

            Send(JsonConvert.SerializeObject(startTraining));

        }

        public void stopTraining()
        {
            dynamic stopTraining = new
            {
                id = "doctor/training/stop",
                data = new
                {


                }


            };
            Send(JsonConvert.SerializeObject(stopTraining));


        }

        public void sendMessageToClient(String message)
        {
            dynamic sendMessageToClient = new
            {
                id = "doctor/message/toClient",
                data = new
                {
                    messageId = message,

                }

            };
            Send(JsonConvert.SerializeObject(sendMessageToClient));


        }

        public void sendMessagetoAllClients(String message)
        {
            dynamic sendMessageToAllClients = new
            {
                id = "doctor/message/toAll",
                data = new
                {
                    messageId = message,

                }

            };
            Send(JsonConvert.SerializeObject(sendMessageToAllClients));

        }

        public void setPower(string power)
        {
            dynamic setPower = new
            {
                id = "doctor/setPower",
               data = new
               {
                   power = power,
               }

            };

            Send(JsonConvert.SerializeObject(setPower));

        }

        public void getOlderData()
        {
            
        }
    }

}

