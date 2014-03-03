using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Type in a super hero's name to see his nickname:");
            string userValue = Console.ReadLine();

            Superhero myValue;
            if (Enum.TryParse<Superhero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case Superhero.Batman:
                        Console.WriteLine("Caped crusader");
                        break;
                    case Superhero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case Superhero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not compute");
            }

            Console.ReadLine();
        }
    }

    enum Superhero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
