using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            //Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Color);

            //determineMarketValue(myNewCar);

            double myValue = myNewCar.DetermineMarketValue();

            Console.ReadLine();

        }

        /*
        private static double determineMarketValue(Car car)
        {

            return 100.0;
        }
         */

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            return 0.0;
        }

    }

}
