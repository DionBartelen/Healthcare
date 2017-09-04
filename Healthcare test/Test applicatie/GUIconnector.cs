using System;
using System.IO.Ports;
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
        }

        private void connectSerial_Click(object sender, EventArgs e)
        {
            string comPort = comPortText.Text;
            string baudRate = baudRateText.Text;
            ErgometerCOM ergometer = new ErgometerCOM(comPort, baudRate);



                replyBoxText.Text = replyBoxText.Text + "\n" + "Gekozen COM poort: " + comPort + " gekozen baudrate: " + baudRate + "\r\nStatus verbonden: " + serialPort.IsOpen;

            comPortText.Text = "";
            baudRateText.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
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
