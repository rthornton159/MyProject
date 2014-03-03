using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToShortTimeString());

            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthdate = new DateTime(1969, 12, 7);
            DateTime myBirthdate = DateTime.Parse("12/7/1969");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            Console.WriteLine(myAge.TotalDays.ToString());

            Console.ReadLine();

        }
    }
}
