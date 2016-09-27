using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Comparing_Floats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool check = Math.Abs((int)(a * 1000000) - (int)(b * 1000000)) < 1;
            Console.WriteLine(check);
        }
    }
}