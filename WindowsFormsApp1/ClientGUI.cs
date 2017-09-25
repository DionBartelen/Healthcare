using Healthcare_test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientGUI : Form
    {
        public Ergometer ergometer;
        List<ClientData> client_data_list;
        public TextBox username { get; set; }
        public TextBox password { get; set; }


        public ClientGUI()
        {
            InitializeComponent();
            client_data_list = new List<ClientData>();
            username = usernameTxt;
            password = passwordTxt;
            ClientData client1 = new ClientData("", "");
            ClientData client2 = new ClientData("test1", "test2");
            client_data_list.Add(client1);
            client_data_list.Add(client2);
            string[] ports = SerialPort.GetPortNames();
            foreach (String s in ports)
            {
                comportCombo.Items.Add(s);
            }
            comportCombo.Items.Add("Simulator");
            comportCombo.SelectedItem = comportCombo.Items[0];


        }

        private void sign_in_Btn_Click(object sender, EventArgs e)
        {
            ClientData currentClient = new ClientData(username.Text, password.Text);
            Boolean foundInList = false;

            foreach (ClientData client in client_data_list)
            {
                if (currentClient.password == client.password && currentClient.username == client.username)
                {
                    foundInList = true;

                }
            }
            if (foundInList)
            { 
                response.Text = "connected";
                

                if (ergometer != null)
                {
                    ergometer.Close();
                }
                if (comportCombo.SelectedItem.ToString() == "Simulator")
                {
                    ErgometerSimulatie ergometersimulatie = new ErgometerSimulatie();
                    Client client = new Client(username.Text, ergometersimulatie, null);
                    SessionGUI sessionGUI = new SessionGUI(client);
                    sessionGUI.Show();

                }
                else
                {
                    string comPort = comportCombo.SelectedItem.ToString();
                    Client client = new Client(username.Text , null, comPort);
                    SessionGUI sessionGUI = new SessionGUI(client);
                    sessionGUI.Show();
                   
                }
            }
            else
            {
                response.Text = "Not found";
                username.Text = "";
                password.Text = "";
            }

        }


        private void comportCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    }
  

