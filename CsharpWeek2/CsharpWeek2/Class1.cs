using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpWeek2FileIO
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.ProcessorCount);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.SpecialFolder.MyPictures);


            List<string> mySystemProperties = new List<string>
            {
                Environment.MachineName,
                Environment.OSVersion.ToString(),
                Environment.ProcessorCount.ToString(),
                Environment.UserName,
                Environment.CurrentDirectory,
                Environment.SpecialFolder.MyPictures.ToString()
            };

            File.WriteAllLines(Environment.CurrentDirectory + @"\Systemproperties1.txt", mySystemProperties);
            string properties = String.Join("\t\n", mySystemProperties);
            File.WriteAllText(Environment.CurrentDirectory + @"\Systemproperties2.txt", properties);

            List<string> results = File.ReadAllLines(Environment.CurrentDirectory + @"\Systemproperties2.txt").ToList();
            Console.WriteLine(results.Count);




        }
    }
}
