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

        public override void Close()
        {
            s.CountThread.Abort();
            s.Close();
        }

        public override void ErgometerCommandMode()
        {   
        }

        public override ErgometerData GetData()
        {
            // 0-en moeten nog ingevoerd worden!!!
            return new ErgometerData(s.Pulse, (int)s.RPM, s.Speed, s.Distance,  (s.CurrentTime.Minute * 100) + s.CurrentTime.Second, 0, s.Power, 0);
        }

        public override bool IsConnected()
        {
            return true;
        }

        public override void SetDistance(double distance)
        {
            s.Distance = (float)distance;
        }

        public override void SetPower(int power)
        {
            s.Power = power;
        }

        public override void SetTime(int time)
        {
            s.CurrentTime.Minute = time / 100;
            s.CurrentTime.Second = time % 100;
        }
    }
}
