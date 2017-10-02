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

        public DoctorApplication_Session(DoctorApplication_Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
            connected_clients = new List<string>();
            
        }

        private void TrainingLbl_Click(object sender, EventArgs e)
        {

        }


        

        private void getPastDataBtn_Click(object sender, EventArgs e)
        {
            connection.getOlderData(OlderDataComboBox.Text);
        }

        public void UpdateComboBox(List<String> new_Connected_Sessions)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                ConectedSessionsListCombo.Items.Clear();
            }));

            foreach (string c in new_Connected_Sessions)
            {
                if (c != null)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        ConectedSessionsListCombo.Items.Add(c);
                    }));
                }                
            }
        }

        public void UpdateOlderDataComboBox(List<string> users)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                OlderDataComboBox.Items.Clear();
            }));

            foreach (string c in users)
            {
                if (c != null)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        OlderDataComboBox.Items.Add(c);
                    }));
                }
            }
        }

        private void RefreshConnectedButton_Click(object sender, EventArgs e)
        {
            ConectedSessionsListCombo.Text = "";
            connection.getSessions();
        }

        private void RefreshHistoricUsers_Click(object sender, EventArgs e)
        {
            connection.GetUsers();
        }

        public void RunTrainSessionForm(DoctorApplication_Trainsessions session)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                session.Show();
            }));
        }

        private void followBtn_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                DoctorApplication_SessionClient session = new DoctorApplication_SessionClient(connection, ConectedSessionsListCombo.SelectedItem.ToString());
                session.Show();  
            }
            ));
            
        }
    }
}
