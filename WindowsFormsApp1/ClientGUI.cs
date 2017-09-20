using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientGUI : Form
    {
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
                Client client = new Client(username.Text);
                SessionGUI sessionGUI = new SessionGUI(client);
                sessionGUI.Show();
                       }
            else
            {
                response.Text = "Not found";
                username.Text = "";
                password.Text = "";
            }


        }
        }
    }

