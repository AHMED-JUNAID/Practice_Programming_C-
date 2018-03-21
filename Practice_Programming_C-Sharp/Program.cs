//reading and writing from console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_Programming_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //write to console
            Console.Write("Enter your Name : ");
            string userName = Console.ReadLine(); //read from console

            //write to console using concatination
            Console.WriteLine("\n\tHello " + userName);

            //write to console using place holder syntax
            Console.WriteLine("\n\tHELLO {0}", userName);

            Console.WriteLine();
        }
    }
}
