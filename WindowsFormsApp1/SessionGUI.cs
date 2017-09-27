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
    public partial class SessionGUI : Form
    {
        Client client; 
        public SessionGUI(Client client )
        {
            InitializeComponent();
            this.client = client;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            client.close();
            this.Close();
        }
    }
}
