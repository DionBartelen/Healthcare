using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpWeek2
{
    struct Fraction
    {
        int num { get; set; }
        int den { get; set; }

        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }

        public static Boolean operator <(Fraction a, Fraction b)
        {
            return (a.num / (double)a.den) < (b.num / (double)b.den);
        }
        public static Boolean operator >(Fraction a, Fraction b)
        {
            return (a.num / (double)a.den) > (b.num / (double)b.den);
        }
        public static Boolean operator ==(Fraction a, Fraction b)
        {
            return (a.num / (double)a.den) == (b.num / (double)b.den);
        }

        public static Boolean operator !=(Fraction a, Fraction b)
        {
            return (a.num / (double)a.den) != (b.num / (double)b.den);
        }

        public override bool Equals(Object o)
        {
            Fraction f = (Fraction) o;
            return  (this.num / (double)this.den) == (f.num / (double)f.den);
        }
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(2, 4);
            Fraction c = a + b;
            Console.WriteLine(a.Equals(b));


        }
    }
}
