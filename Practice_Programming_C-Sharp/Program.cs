//data type conversion in c#

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
            /*
             * NOTE:
             * implicit conversion can be done automatically by Compiler 
             */

            float fNumber = 123.45f;
            float fNumber1 = 456.22f;
            int iNumber;
            int iNumber1;

            Console.WriteLine("\nactual value before using cast operator : " + fNumber);
            //use of cast opertaor () for conversion
            //does not throw exception 
            iNumber = (int)fNumber;
            Console.WriteLine("\nvalue after using cast operator : " + iNumber);

            Console.WriteLine("\nactual value before using convert class : " + fNumber1);
            //use of convert class for conversion
            //this throws exception if value is large enough
            iNumber1 = Convert.ToInt32(fNumber1);
            Console.WriteLine("\nvalue after using convert class : " + iNumber1);

            //use of parse for conversion
            //cannot tell about conversion success
            string sNumber = "999";
            int iNumber3 = int.Parse(sNumber);
            Console.WriteLine("\nvalue after using parse : " + iNumber3);

            //use of try-parse for conversion
            //tell about conversion success
            string sNumber1 = "755";
            int iNumber4;

            if (int.TryParse(sNumber1, out iNumber4))
                Console.WriteLine("\nafter successfull conversion : " + iNumber4);
            else
                Console.WriteLine("\nstring does not contain valid number");

            Console.WriteLine("\n");
        }
    }
}