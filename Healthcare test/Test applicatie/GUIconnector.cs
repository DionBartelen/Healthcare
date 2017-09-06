using Healthcare_test;
using Healthcare_test.test_applicatie;
using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Healthcare_test
{
    public partial class Form1 : Form
    {
        public ErgometerCOM ergometer;

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (String s in ports)
            {
                comPortText.Items.Add(s);
            }
            comPortText.SelectedItem = comPortText.Items[0];
        }

        private void connectSerial_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string comPort = comPortText.Text;
            string baudRate = baudRateText.Text;
            ergometer = new ErgometerCOM(comPort, baudRate);
            if (ergometer.serialPort.IsOpen)
                data_Collector.Enabled = true;
            else
                data_Collector.Enabled = false;

=======
            if (comPortText.Text == "Simulator")
            {
                new ErgometerSimulatie();
            }
            else
            {
                string comPort = comPortText.Text;
                string baudRate = baudRateText.Text;
                ergometer = new ErgometerCOM(comPort, baudRate);
>>>>>>> GUILinkToSimulation
                replyBoxText.Text = replyBoxText.Text + "\n" + "Gekozen COM poort: " + comPort + " gekozen baudrate: " + baudRate;
                comPortText.Text = "";
                baudRateText.Text = "";
            }
        }

        private void sendInput_Click(object sender, EventArgs e)
        {
            string command = commandInput.Text;

            if(ergometer.serialPort.IsOpen)
            {
                ergometer.serialPort.WriteLine(command);
                replyBoxText.Text = "Verzonden command: " + command;
                string reply = ergometer.serialPort.ReadLine();
                replyBoxText.Text += "\r\nReply: " + reply;
            } else
            {
                replyBoxText.Text = "COM poort is niet open";
            }

            commandInput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void data_Collector_Click(object sender, EventArgs e)
        {
            string command = "ST";
            if(ergometer.serialPort.IsOpen)
            {
                replyBoxText.Clear();
                ergometer.serialPort.WriteLine(command);
                ErgometerData ergometerData = ergometer.getData();
                replyBoxText.Text = ergometerData.toString();

            }

        }

        
    }
}
