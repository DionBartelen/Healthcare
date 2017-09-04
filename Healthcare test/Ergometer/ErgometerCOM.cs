using System;
using System.IO.Ports;

namespace Healthcare_test
{

    public class ErgometerCOM : Ergometer
    {
        public SerialPort serialPort;

        public ErgometerCOM(string comport)
        {
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
            }
            catch (Exception exception)
            {
                replyBoxText.Text = exception.ToString();
            }
        }

        public ErgometerData getData()
        {

        serialPort.WriteLine("ST");
        String response = serialPort.ReadLine();
        String[] data = response.Split(" ");
            return null;
        }

        public void setDistance(double distance)
        {
            serialPort.WriteLine("PD " + distance);
        }

        public void setTime(int time)
        {
            serialPort.WriteLine("PT " + time);
        }

        public void setPower(int power)
        {
            serialPort.WriteLine("PW " + power);
        }

    }
}
