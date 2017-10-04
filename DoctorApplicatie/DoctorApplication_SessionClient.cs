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
    public partial class DoctorApplication_SessionClient : Form
    {
        DoctorApplication_Connection connection;
        public String sessionID;
        public List<ErgometerData> currentData;
        public Boolean sessionStarted;

        public DoctorApplication_SessionClient(DoctorApplication_Connection connection, String sessionID)
        {
            InitializeComponent();
            this.connection = connection;
            this.sessionID = sessionID;
            this.Text = sessionID;
            sessionStarted = false;
            currentData = new List<ErgometerData>();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (sessionID != null)
            {
                connection.startTraining(sessionID);
                sessionStarted = true;

            }
        }


        private void StopBtn_Click(object sender, EventArgs e)
        {
            connection.stopTraining(sessionID);
            sessionStarted = false;
        }

        private void sendToClientBtn_Click(object sender, EventArgs e)
        {
            if (messageTxt.Text != null)
            {
                connection.sendMessageToClient(messageTxt.Text, sessionID);
            }
        }

        private void toAllBtn_Click(object sender, EventArgs e)
        {
            if (messageTxt.Text != null)
            {
                connection.sendMessagetoAllClients(messageTxt.Text);
            }
        }

        private void setPowerBtn_Click(object sender, EventArgs e)
        {
            if (setPowerTxt.Text != null && sessionID != null)
            {
                connection.setPower(setPowerTxt.Text, sessionID);
            }
        }

        private void unFollowBtn_Click(object sender, EventArgs e)
        {
            connection.UnFollowPatient(sessionID);
            Close();
        }

        public void updateChart()
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                chart1.Series.Clear();
                chart2.Series.Clear();
                chart1.Series.Add(@"Speed in KM/h");
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series.Add(@"RPM");
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series.Add(@"Distance in KM");
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart2.Series.Add(@"Power in Watt");
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart2.Series.Add(@"heart pulse");
                chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                //chart2.Series.Add(@"");
                //chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                foreach (ErgometerData data in currentData)
                {
                    chart1.Series[0].Points.AddXY(data.Time, data.Speed);
                    chart1.Series[1].Points.AddXY(data.Time, data.RPM);
                    chart1.Series[2].Points.AddXY(data.Time, data.Distance);
                    chart2.Series[0].Points.AddXY(data.Time, data.Requested_Power);
                    chart2.Series[1].Points.AddXY(data.Time, data.Pulse);
                }
            }));
            
        }

        private void DoctorApplication_SessionClient_Load(object sender, EventArgs e)
        {

        }
    }
}
