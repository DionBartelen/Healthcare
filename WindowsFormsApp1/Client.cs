using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public class Client
    {
        NetworkStream stream;
        int port = 1234;
        TcpClient client;
        IPAddress localhost;
        SerialPort serialPort;
        Healthcare_test.ErgometerCOM ergometerCOM;
        string sessionID;
        Thread read;
        Thread getData;
        Boolean isConnected;


        public Client(String username)
        {
            System.Diagnostics.Debug.WriteLine("what up ");
            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);
             if (!ipIsOk) { Console.WriteLine("ip adres kan niet geparsed worden."); Environment.Exit(1); }
            client = new TcpClient(localhost.ToString(), port);
              stream = client.GetStream();
            isConnected = true;
              Send(startSession(username));
              ergometerCOM = new Healthcare_test.ErgometerCOM("COM8", "9600");
           read = new Thread(Read);
           read.Start();

            getData = new Thread(GetData);
            getData.Start();




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
                                if((totalBytesreceived - 4 ) == lengthMessage)
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
            if (jsonData.id == "session/start")
            {
                sessionID = (String)jsonData.data.sessionID;
                System.Diagnostics.Debug.WriteLine("sessionID: " + sessionID);
            }
            if (jsonData.id == "session/end")
            {
                System.Diagnostics.Debug.WriteLine("its ye boi");
                isConnected = false;
                stream.Close();
                client.Close();
                ergometerCOM.Close();
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

        public void GetData()
        {
            while (sessionID == null)
            {
                Thread.Sleep(100);
            }
            while (isConnected)
            {
                System.Diagnostics.Debug.WriteLine(isConnected);
                Healthcare_test.ErgometerData ergometerData = ergometerCOM.GetData();
                //String ergometerData2 = ergometerData.ToString();
                //System.Diagnostics.Debug.WriteLine(ergometerData2);
                dynamic ergometerdata = new
                {
                    id = "data",
                    session = sessionID,
                    data = new
                    {
                        power = ergometerData.Actual_Power,
                        speed = ergometerData.Speed,
                        time = ergometerData.Time,
                        RPM = ergometerData.RPM,
                        distance = ergometerData.Distance,
                        pulse = ergometerData.Pulse
                    }

                };
                Send(JsonConvert.SerializeObject(ergometerdata));
                Thread.Sleep(1000);
            }


        }

        // public dynamic sendLogin()
        //{ 
        //   dynamic sendLogin = new
        //  {
        //   id = "log in",
        //   data = new 
        //    {

        //    }

        //  }

        public dynamic startSession(String usernameid)
        {
            dynamic startSession = new
            {
                id = "session/start",
                data = new
                {
                    username = usernameid
                }

            };
            return JsonConvert.SerializeObject(startSession);


        }

        public void closeSession()
        {
            dynamic closeSession = new
            {
                id = "session/end",
                data = new
                {
                    session = sessionID
                }

            };
            Send(JsonConvert.SerializeObject(closeSession));
        }

    }
}

