using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ConsoleApp1
{
    struct ibantest
    {
        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static void Main(String []args)
        {
            Console.WriteLine(BerekenControleGetal("INGB0001234567", "NL"));
            Console.WriteLine(BerekenControleGetal("INGB0748919457", "NL"));
        }
        public static string BerekenControleGetal(String rekeningIdentificatie, String landcode)
        {
            String bankref = rekeningIdentificatie.Substring(0, 4);
            bankref += landcode;
            char[] split  = bankref.ToCharArray(0,6);
            
            char[] alphabetchars = alphabet.ToCharArray(0, 26);
            string result = "";
            foreach(Char c in split)
            {
                for(int i = 0; i< alphabetchars.Length; i++)
                {
                    char current = alphabetchars[i];
                    if (current.Equals(c))
                        result += (i + 10) + "";
                   
                }
                if (split[3].Equals(c))
                    result += rekeningIdentificatie.Substring(4, rekeningIdentificatie.Length - 4) + "";

            }
            result += "00";
            BigInteger numbertoDivide = BigInteger.Parse(result);
            BigInteger safetynumber = 98 - (numbertoDivide % 97);
            return landcode + safetynumber + rekeningIdentificatie;

        }
    }
}
