//nullable type in c#

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
            //now value type can declared as nullable using ( ? ) 

            bool? areYouMajor = null;

            if(areYouMajor == true)
                Console.WriteLine("true");
            else if (areYouMajor == false)
                Console.WriteLine("false");
            else
                Console.WriteLine("null");

            Console.WriteLine("\n\n");

            //use of nullable coalescing operator ( ?? ) 

            int? ticketsOnSale = 10;
            int availableTickets = ticketsOnSale ?? 0;  //effiecient use of ( ?? ) instead of writing more code 

            // or

            //int availableTickets;

            //if (ticketsOnSale == null)
            //    availableTickets = 0;
            //else
            //    availableTickets = ticketsOnSale.Value;

            Console.WriteLine("available tickets = {0}", availableTickets);
            Console.WriteLine("\n\n");
        }
    }
}