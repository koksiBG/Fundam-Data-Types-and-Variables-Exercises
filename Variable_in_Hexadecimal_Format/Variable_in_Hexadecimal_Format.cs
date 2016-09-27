using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Variable_in_Hexadecimal_Format
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimal, 16));
        }
    }
}