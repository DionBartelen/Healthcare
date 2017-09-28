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
using System.Windows.Forms;

namespace DoctorApplicatie
{
    public class DoctorApplication_Connection
    {
        NetworkStream stream;
        int port = 1234;
        TcpClient client;
        IPAddress localhost;
        Boolean isConnected;
        DoctorApplication_Session doctorApplication_Session;
        DoctorAplicatie application;
        public DoctorApplication_Connection(string username, string password, DoctorAplicatie application)
        {
            this.application = application;
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
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }
        public void ProcessAnswer(string information)
        {
            dynamic jsonData = JsonConvert.DeserializeObject(information);
            if (jsonData.id == "doctor/login")
            {
                if (jsonData.data.status == "ok")
                {
                    doctorApplication_Session = new DoctorApplication_Session(this);
                    application.RunSessionForm(doctorApplication_Session);
                }
            }
            else if (jsonData.id == "doctor/sessions")
            {
                List<String> connected_Sessions = new List<string>();
                foreach (dynamic d in jsonData.data.sessions)
                {
                    connected_Sessions.Add((string)d);
                }
                doctorApplication_Session.UpdateComboBox(connected_Sessions);
            } else if(jsonData.id == "doctor/sessions/users")
            {
                List<string> users = new List<string>();
                foreach (dynamic e in jsonData.data.users)
                {
                    if (e != null)
                    {
                        users.Add((string)e);
                    }
                }
                doctorApplication_Session.UpdateOlderDataComboBox(users);
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

        public void startTraining(String patientID)
        {
            dynamic startTraining = new
            {
                id = "doctor/training/start",
                data = new
                {
                    patientId = patientID
                }

            };

            Send(JsonConvert.SerializeObject(startTraining));

        }

        public void stopTraining(String patientID)
        {
            dynamic stopTraining = new
            {
                id = "doctor/training/stop",
                data = new
                {
                    patientId = patientID

                }


            };
            Send(JsonConvert.SerializeObject(stopTraining));


        }

        public void sendMessageToClient(String message, String patientID)
        {
            dynamic sendMessageToClient = new
            {
                id = "doctor/message/toClient",
                data = new
                {
                    messageId = message,
                    patientiD = patientID


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

        public void setPower(string power, String patientID)
        {
            dynamic setPower = new
            {
                id = "doctor/setPower",
                data = new
                {
                    power = power,
                    patientId = patientID
                }

            };

            Send(JsonConvert.SerializeObject(setPower));

        }
        public void getSessions()
        {
            dynamic getSessions = new
            {
                id = "doctor/sessions"

            };
            Send(JsonConvert.SerializeObject(getSessions));
        }

        public void GetUsers()
        {
            dynamic request = new
            {
                id = "doctor/sessions/users"
            };
            Send(JsonConvert.SerializeObject(request));
        }

        public void getOlderData(string username)
        {
            dynamic request = new
            {
                id = "session/data/historic",
                data = new
                {
                    patientID = username
                }
            };
            Send(JsonConvert.SerializeObject(request));
        }

        public void close()
        {
            stream.Close();
            client.Close();
        }
    }

}

