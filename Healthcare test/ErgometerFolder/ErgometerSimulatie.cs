using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthcare_test.test_applicatie;

namespace Healthcare_test
{
    class ErgometerSimulatie : Ergometer
    {
        Simulation s;

        public ErgometerSimulatie()
        {
            s = new Simulation();
            s.Show();
        }

        public override ErgometerData getData()
        {
            // 0-en moeten nog ingevoerd worden!!!
            return new ErgometerData(s.Pulse, (int)s.RPM, s.Distance, s.Speed,  s.CurrentTime.Minute + s.CurrentTime.Second, 0, s.Power, 0);
        }

        public override void setDistance(double distance)
        {
            s.Distance = (float)distance;
        }

        public override void setPower(int power)
        {
            s.Power = power;
        }

        public override void setTime(int time)
        {
            s.CurrentTime.Minute = time / 100;
            s.CurrentTime.Second = time % 100;
        }
    }
}
