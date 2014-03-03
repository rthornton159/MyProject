using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Tabor;


namespace NamespacesAndReferencingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.StreamReader myStreamReader = new System.IO.StreamReader();

            //StreamReader myStreamReader = new StreamReader();

            Bob myBob = new Bob();
            Console.WriteLine(myBob.Lookup("http://www.learnvisualstudio.net"));
            Console.ReadLine();

        }
    }
}
