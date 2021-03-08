using System;
using System.IO;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2021,12,21); 
            System.Console.WriteLine(dateTime);       // 21-Dec-21 12:00:00 AM

            var now = DateTime.Now;
            System.Console.WriteLine(now);      // 08-Mar-21 8:25:07 PM  // Current Date and Time

            var today = DateTime.Today;
            System.Console.WriteLine(today);   //08-Mar-21 12:00:00 AM
            System.Console.WriteLine(today.Day);  // 8 
            System.Console.WriteLine(today.Month);  // 3

            var tomorrow = today.AddDays(1);
            System.Console.WriteLine(tomorrow);   // 09-Mar-21 12:00:00 AM

            var yesterday = today.AddDays(-1);
            System.Console.WriteLine(yesterday);  // 07-Mar-21 12:00:00 AM

            System.Console.WriteLine(now.ToLongDateString());  // Monday, March 8, 2021
            System.Console.WriteLine(now.ToShortDateString()); // 08-Mar-21
            System.Console.WriteLine(now.ToLongTimeString());  // 8:33:23 PM
            System.Console.WriteLine(now.ToShortTimeString()); // 8:33 PM
            System.Console.WriteLine(now.ToString()); // 8:33 PM
            
        }
    }
}
