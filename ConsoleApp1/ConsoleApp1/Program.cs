using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Time
    {
        private readonly int minutes;
        public int Minute { get; set; }
        public int Hour { get; set; }

        public Time(int hh, int mm)
        {
            minutes = hh * 60 + mm;
            Minute = mm;
            Hour = hh;
            
        }
        public override string ToString()
        {
            return Hour.ToString("00") + ":" + Minute.ToString("00");
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine(new Time(7,5));
        }
    }
}
