using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */

            /*
            // ArrayLists are dynamically sized, and support other cool features like Sorting, removing items, etc.
            System.Collections.ArrayList myArrayList = new System.Collections.ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            // However, everything is stored as an Object ... which introduces potential problems
            foreach (object o in myArrayList)
            {
                Console.WriteLine(((Car)o).Make);
            }
*/

            /*
            System.Collections.Specialized.ListDictionary myDictionary = new System.Collections.Specialized.ListDictionary();

            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);
            myDictionary.Add(b1.Author, b1);

            // Easy to access an element using its key
            Console.WriteLine(((Car)myDictionary["Geo"]).Model);

            // But since its not strongly typed, we can easily break it
            // by adding a different type to the dictionary
            Console.WriteLine(((Car)myDictionary["Robert Tabor"]).Model);

            */

            /*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);

            Console.WriteLine(myDictionary["Geo"].Model);
            */


            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };


            // Object initializers
            /*
            Car car1 = new Car() { Make = "Oldsmobile", Model = "Cutlas Supreme" };
            Car car2 = new Car() { Make = "Geo", Model = "Prism" };
            Car car3 = new Car() { Make = "Nissan", Model = "Altima" };
            */

            // Collection Initializers
            List<Car> myList = new List<Car>() {
                new Car { Make = "Oldsmobile", Model= "Cutlas Supreme" },
                new Car { Make = "Geo", Model = "Prism" },
                new Car { Make = "Nissan", Model = "Altima" }
            };


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }


    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
