using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_test
{
    public abstract class Ergometer
    {
        abstract public ErgometerData getData();

        abstract public void setDistance(double distance);
        abstract public void setTime(int time);
        abstract public void setPower(int power);
    }
}
