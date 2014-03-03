using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamReader myReader = new StreamReader("\\boo\\Values1.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }

                myReader.Close();

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file.  Are you sure you're looking for the right file?");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file.  Are you sure that directory exists?");
            }
            catch (Exception e)
            {
                //Console.WriteLine("We experienced a problem.  Sorry!");
                Console.WriteLine("We experienced a problem: {0}", e.Message);
            }
            finally
            {
                // Perform any cleanup to roll back the data or close connections to files, database, etc.
            }

            Console.ReadLine();

        }
    }
}
