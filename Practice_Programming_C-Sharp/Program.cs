//built-in data types

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
            bool isTrueOrFalse = true; //valid

            //bool isBoolHoldNumericValue = 0; //invalid bcz bool contain either true or false

            int i = 0;

            int minValueOfInt = int.MinValue; //property of int (MinValue)
            int maxValueOfInt = int.MaxValue; //property of int (MaxValue)

            Console.WriteLine("min value = {0}", minValueOfInt);
            Console.WriteLine("max value = {0}", maxValueOfInt);
        }
    }
}