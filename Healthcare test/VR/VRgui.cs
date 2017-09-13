using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_test.VR
{
    public partial class VRgui : Form
    {
        Session session;
        List<ClientInfo> clients;
        ClientInfo currentClient;
        public string tunnel { get; set; }
        Thread Reading;

        public VRgui()
        {
            InitializeComponent();
            session = new Session("145.48.6.10", 6666, this);
            Reading = new Thread(session.Read);
            Reading.IsBackground = true;
            Reading.Start();
            GetClientList();
        }

        private void VRgui_Load(object sender, EventArgs e)
        {

        }

        public void GetClientList()
        {
            if (session != null)
            {
                session.Send(JsonConvert.SerializeObject(Commands.SessionList()));
            }
        }

        public void CreateTunnel()
        {
            session.Send(JsonConvert.SerializeObject(Commands.CreateTunnel(currentClient.ID)));
        }

        public void AddOptions(List<ClientInfo> clients)
        {
            this.clients = clients;
            foreach (ClientInfo c in clients)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    sessions.Items.Add(c.HostName);
                });
            }
        }

        public void UpdateTunnelStatus(string status)
        {
            this.Invoke((MethodInvoker)delegate ()
           {
               TunnelStatus.Text = status;
           });
        }

        private void VRgui_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reading.Abort();
        }

        private void VRgui_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reading.Abort();
        }

        private void connect_Button_Click(object sender, EventArgs e)
        {
            string selectedName = sessions.Text;
            foreach (ClientInfo c in clients)
            {
                if (c.HostName == selectedName)
                {
                    currentClient = c;
                    CreateTunnel();
                }
            }
        }

        private void ChangeTerain_Click(object sender, EventArgs e)
        {
            try
            {
                double receiving = Convert.ToDouble(((textBox1.Text)));
                session.Send(JsonConvert.SerializeObject(Commands.SetTime(tunnel, receiving)));
            }
            catch(Exception x)
            {
                System.Windows.Forms.MessageBox.Show("Not a valid number" + x.Message);
            }
        }

        private void RefreshClients_Click(object sender, EventArgs e)
        {
            sessions.Items.Clear();
            session.Send(JsonConvert.SerializeObject(Commands.SessionList()));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if(receiving > 24)
            //    {
            //        return;
            //    }
            System.Diagnostics.Debug.WriteLine("test");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void set_Ground_Terrain_256_256_Click(object sender, EventArgs e)
        {
            session.Send(JsonConvert.SerializeObject(Commands.CreateGroundTerrain(tunnel)));
        }

        private void remove_Terrain_Button_Click(object sender, EventArgs e)
        {
            //session.Send(JsonConvert.SerializeObject(Commands.RemoveTerrain(tunnel)));
        }

        private void Buttonobject_Click(object sender, EventArgs e)
        {
            session.Send(JsonConvert.SerializeObject(Commands.AddObject(tunnel)));
        }

        private void terrainWH_Click(object sender, EventArgs e)
        {
            session.Send(JsonConvert.SerializeObject(Commands.CreateGroundTerrainWithHeights(tunnel)));
        }
    }
}
