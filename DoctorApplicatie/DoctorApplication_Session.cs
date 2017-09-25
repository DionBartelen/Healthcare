using Healthcare_test.VR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace DoctorApplicatie
{
    public partial class DoctorApplication_Session : Form
    {
        DoctorApplication_Connection connection;
        public DoctorApplication_Session(DoctorApplication_Connection connection, List<Client> connected_clients)
        {
            InitializeComponent();
            this.connection = connection;
            foreach(Client c in connected_clients)
            {
                ConectedSessionsListCombo.Items.Add(c);
            }



        }

        private void TrainingLbl_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            connection.startTraining();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            connection.stopTraining();
        }

        private void sendToClientBtn_Click(object sender, EventArgs e)
        {
            connection.sendMessageToClient(messageTxt.Text);
        }

        private void toAllBtn_Click(object sender, EventArgs e)
        {
            connection.sendMessagetoAllClients(messageTxt.Text);
        }

        private void setPowerBtn_Click(object sender, EventArgs e)
        {
            connection.setPower(setPowerTxt.Text);
        }

        private void getPastDataBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
