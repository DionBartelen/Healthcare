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
                Console.WriteLine(exception.StackTrace);
            }
        }

        override
        public ErgometerData getData()
        {

            serialPort.WriteLine("ST");
            String response = serialPort.ReadLine();
            response = serialPort.ReadLine();
            String[] data = response.Split('\t');
            int pulse, rpm, time, energy, actual_Power, requested_Power;
            double speed, distance;
            foreach(String datas in data)
            {
                System.Diagnostics.Debug.WriteLine(datas);
            }
            Int32.TryParse(data[0], out pulse);
            Int32.TryParse(data[1], out rpm);
            Double.TryParse(data[2], out speed);
            Double.TryParse(data[3], out distance);
            Int32.TryParse(data[4], out time);
            Int32.TryParse(data[5], out energy);
            Int32.TryParse(data[6], out actual_Power);
            Int32.TryParse(data[7], out requested_Power);
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
