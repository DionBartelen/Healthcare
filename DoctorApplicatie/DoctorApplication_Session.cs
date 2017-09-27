﻿using Healthcare_test.VR;
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
        List<String> connected_clients;
        public DoctorApplication_Session(DoctorApplication_Connection connection, List<String> connected_clients)
        {
            InitializeComponent();
            this.connection = connection;
            UpdateComboBox(connected_clients);
        }

        private void TrainingLbl_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            connection.startTraining(ConectedSessionsListCombo.SelectedItem.ToString());
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            connection.stopTraining(ConectedSessionsListCombo.SelectedItem.ToString());
        }

        private void sendToClientBtn_Click(object sender, EventArgs e)
        {
            connection.sendMessageToClient(messageTxt.Text, ConectedSessionsListCombo.SelectedItem.ToString());
        }

        private void toAllBtn_Click(object sender, EventArgs e)
        {
            connection.sendMessagetoAllClients(messageTxt.Text);
        }

        private void setPowerBtn_Click(object sender, EventArgs e)
        {
            connection.setPower(setPowerTxt.Text, ConectedSessionsListCombo.SelectedItem.ToString());
        }

        private void getPastDataBtn_Click(object sender, EventArgs e)
        {

        }

        public void UpdateComboBox(List<String> new_Connected_Sessions)
        {
            foreach (String c in connected_clients)
            {
                ConectedSessionsListCombo.Items.Add(c);
            }
        }
    }
}