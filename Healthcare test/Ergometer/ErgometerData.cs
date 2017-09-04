using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_test
{
    class ErgometerData
    {
        public int rpm { get; set; }
        public int speed { get; set; }
        public double distance { get; set; }
        public int pulse { get; set; }
        public int time { get; set; }
        public int energy { get; set; }
        public int power { get; set; }

        public ErgometerData(int rpm, int speed, double distance,int pulse, int time, int energy, int power)
            {
            this.rpm = rpm;
            this.speed = speed;
            this.distance = distance;
            this.pulse = pulse;
            this.time = time;
            this.energy = energy;
            this.power = power;

         }

    }
}
