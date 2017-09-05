using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_test.test_applicatie
{
    class Time
    {
        public int Second { get; set; }
        public int Minute { get; set; }

        public Time(int ss, int mm)
        {
            this.Second = ss;
            this.Minute = mm;
        }

        public void timer ()
        {
            Second++;
            if (Second == 60)
            {
                Second = 0;
                Minute++;
            }

        }


        public override String ToString()
        {
            return $"{Minute:D2}:{Second:D2}";                     // string interpolatie
        }
    }
}
