using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_test
{
    abstract class Ergometer
    {
        abstract public ErgometerData getData();

        abstract public void setRpm(int rpm);
        abstract public void setSpeed(int speed);
        abstract public void setDistance(int distance);
        abstract public void setPulse(int pulse);
        abstract public void setTime();
        abstract public void setEnergy();
        abstract public void setPower();
    }
}
