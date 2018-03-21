//string type in c#

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
            //without verbatim literal 
            string path = "c:\\something\\something else\\etc.";

            //with verbatim literal readibility increases
            string path1 = @"c:\something\something else\etc.";
            
        }
    }
}