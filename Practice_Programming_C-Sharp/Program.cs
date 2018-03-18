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
            int num1 = 0;
            int num2 = 0;

            Console.Write("enter any number : ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("enter another number : ");
            num2 = Convert.ToInt16(Console.ReadLine());
            
            //multiplication of two numbers
            //Console.WriteLine("the result is {0}", num2*num1);
 
            //division of two numbers
            Console.WriteLine("the number {0} divides with {1} is equal to {2}", num1, num2, num1/num2);

            Console.ReadKey();

        }
    }
}
