using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Strings_and_Objects
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string two = "World";
            object three = first + ' ' + two;
            Console.WriteLine((string)three);
        }
    }
}