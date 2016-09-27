using System;

namespace Integer_to_Hex_and_Binary
{
    class Integer_to_Hex_and_Binary
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            string outputHex = Convert.ToString(integer, 16).ToUpper();
            string outputBin = Convert.ToString(integer, 2).ToUpper();
            Console.WriteLine(outputHex);
            Console.WriteLine(outputBin);
        }
    }
}