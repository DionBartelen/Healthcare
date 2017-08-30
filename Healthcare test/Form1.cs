﻿using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Healthcare_test
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = null;

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

            try
            {
                serialPort = new SerialPort(comPort);
                serialPort.BaudRate = Convert.ToInt32(baudRate);
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.ReadTimeout = 2000;
                serialPort.WriteTimeout = 500;
                serialPort.Open();
            } catch (Exception exception)
            {
                replyBoxText.Text = exception.ToString();
            }

                replyBoxText.Text = replyBoxText.Text + "\n" + "Gekozen COM poort: " + comPort + " gekozen baudrate: " + baudRate + "\r\nStatus verbonden: " + serialPort.IsOpen;

            comPortText.Text = "";
            baudRateText.Text = "";
        }

        private void sendInput_Click(object sender, EventArgs e)
        {
            string command = commandInput.Text;

            if(serialPort.IsOpen)
            {
                serialPort.WriteLine(command);
                replyBoxText.Text = "Verzonden command: " + command;
                string reply = serialPort.ReadLine();
                replyBoxText.Text += "\r\nReply: " + reply;
            } else
            {
                replyBoxText.Text = "COM poort is niet open";
            }

            commandInput.Text = "";
        }
    }
}
