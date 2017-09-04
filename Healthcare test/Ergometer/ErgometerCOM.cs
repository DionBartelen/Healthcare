using System;
using System.IO.Ports;

namespace Healthcare_test
{

    public class ErgometerCOM : Ergometer
    {
        public SerialPort serialPort;

        public ErgometerCOM(string comport, string baudRate)
        {
            try
            {
                serialPort = new SerialPort(comport);
                serialPort.BaudRate = Convert.ToInt32(baudRate);
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.ReadTimeout = 2000;
                serialPort.WriteTimeout = 500;
                serialPort.Open();
                serialPort.WriteLine("CM");
            }
            catch (Exception exception)
            {
                replyBoxText.Text = exception.ToString();
            }
        }

        override
        public ErgometerData getData()
        {
           
            serialPort.WriteLine("ST");
            String response = serialPort.ReadLine();
            String[] data = response.Split(' ');
            int pulse = Convert.ToInt32(data[0]);
            int rpm = Convert.ToInt32(data[1]);
            double speed = Convert.ToDouble(data[2]);
            double distance = Convert.ToDouble(data[3]);
            int requested_Power = Convert.ToInt32(data[4]);
            int energy = Convert.ToInt32(data[5]);
            int time = Convert.ToInt32(data[6]);
            int actual_Power = Convert.ToInt32(data[7]);
            return  new ErgometerData(pulse, rpm, speed, distance, time, energy, actual_Power, requested_Power);
        }

        override
        public void setDistance(double distance)
        {
            serialPort.WriteLine("PD " + distance);
        }

        override
        public void setTime(int time)
        {
            serialPort.WriteLine("PT " + time);
        }

        override
        public void setPower(int power)
        {
            serialPort.WriteLine("PW " + power);
        }

    }
}
