using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static int port = 1234;
        static void Main(string[] args)
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
            } else
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
    }
}
