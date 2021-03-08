using System;
using System.IO;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating:
            var timespan = new TimeSpan(1,2,3);
            System.Console.WriteLine(timespan);  // 01:02:03

            var timespan1 = new TimeSpan(1,0,0);
            System.Console.WriteLine(timespan1);  // 01:00:00

            var timespan2 = TimeSpan.FromHours(1);
            System.Console.WriteLine(timespan2);  // 01:00:00

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(10);
            var duration = end - start ;
            System.Console.WriteLine(duration);  // 00:10:00.0017853

            
            //Property:

            System.Console.WriteLine(timespan.Minutes);   // 2 Minutes Property
            System.Console.WriteLine(timespan.TotalMinutes); // 62.05  : Total (1 Hours 2 Mins 3 Sec)

            //Add
            System.Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(8))); // 01:10:03

            //Substract
            System.Console.WriteLine(timespan.Subtract(TimeSpan.FromMinutes(8))); // 00:54:03

            //ToString
            System.Console.WriteLine(timespan.ToString()); // 01:02:03

            //Parse
            System.Console.WriteLine(TimeSpan.Parse("02:02:02")); // 02:02:02
        }
    }
}
