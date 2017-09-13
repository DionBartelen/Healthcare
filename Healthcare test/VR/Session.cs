using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Healthcare_test.VR
{
    public class Session
    {
        VRgui gui;
        TcpClient client;
        NetworkStream stream;

        public Session(string ip, int port, VRgui gui)
        {
            client = new TcpClient();
            client.ReceiveTimeout = 20000;
            client.SendTimeout = 20000;
            client.Connect(ip, port);
            stream = client.GetStream();
            this.gui = gui;
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
            if(jsonData.id == "session/list")
            {
                ProcessSessionList(jsonData.data);
            } else if(jsonData.id == "tunnel/create")
            {
                ProcessTunnelCreate(jsonData.data);
            } else if(jsonData.id == "tunnel/send")
            {

            } else if(jsonData.id == "packetid")
            {

            } else
            {
                System.Diagnostics.Debug.WriteLine("Else: \r\n" + information);
            }
        }

        public void ProcessSessionList(dynamic information)
        {
            dynamic sessions = information;
            List<ClientInfo> clientinfoList = new List<ClientInfo>();
            foreach (dynamic d in sessions)
            {
                clientinfoList.Add(new ClientInfo((string)d.clientinfo.host, (string)d.id));
            }
            gui.AddOptions(clientinfoList);
        }

        public void ProcessTunnelCreate(dynamic information)
        {
            dynamic status = information.status;
            gui.UpdateTunnelStatus((string)status);
            gui.tunnel = information.id;
        }

        public void Close()
        {
            stream.Close();
            client.Close();
        }
    }
}
