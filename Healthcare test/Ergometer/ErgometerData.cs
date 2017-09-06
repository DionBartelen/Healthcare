using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_test
{
    public class ErgometerData
    {
        public int rpm { get; set; }
        public double speed { get; set; }
        public double distance { get; set; }
        public int pulse { get; set; }
        public int time { get; set; }
        public int energy { get; set; }
        public int actual_Power { get; set; }
        public int requested_Power { get; set; }

        public ErgometerData(int pulse, int rpm, double speed, double distance, int time, int energy, int actual_Power, int requested_Power)
            {
            this.rpm = rpm;
            this.speed = speed;
            this.distance = distance;
            this.pulse = pulse;
            this.time = time;
            this.energy = energy;
            this.actual_Power = actual_Power;
            this.requested_Power = requested_Power;
           
         }

        public String toString()
        {
            return "rpm: " + rpm + "\r\n" + "speed: " + speed + "\r\n" + "distance: " + distance + "\r\n" + "pulse: " + pulse + "\r\n" + "time: " + time + "\r\n" + "energy: " + energy + "\r\n" + "actual_Power: " + actual_Power + "\r\n" + "requested_Power: " + requested_Power + "\r\n";
        }

    }
}
