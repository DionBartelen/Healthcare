using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorApplicatie
{
    public partial class DoctorApplication_Trainsessions : Form
    {
        List<TrainSession> AllSessions;

        public DoctorApplication_Trainsessions()
        {
            InitializeComponent();
            AllSessions = new List<TrainSession>();
        }

        public void SetAllSessions(List<TrainSession> sessions)
        {
            AllSessions = sessions;
            ShowComboBox.Items.Clear();
            foreach(TrainSession s in AllSessions)
            {
                ShowComboBox.Items.Add(s);
            }
        }

        private void ShowTrainSessionButton_Click(object sender, EventArgs e)
        {
            dataGUI dataGui = new dataGUI();
            dataGui.SetTrainSession((TrainSession)ShowComboBox.SelectedItem);
            RunDataGUI(dataGui);
        }

        public void RunDataGUI(dataGUI dataGUI)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                dataGUI.Show();
            }));
        }
    }
}
