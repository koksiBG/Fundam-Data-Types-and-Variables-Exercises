using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Print_Part_of_the_ASCII__Table
{
    class Print_Part_of_the_ASCII__Table
    {
        static void Main(string[] args)
        {
            int firstCharNumber = int.Parse(Console.ReadLine());
            int secondCharNumber = int.Parse(Console.ReadLine());
            if ((firstCharNumber >= 0 & firstCharNumber < 256) & (secondCharNumber >= 0 & secondCharNumber < 256))
            {
                for (int i = firstCharNumber; i <= secondCharNumber; i++)
                {
                    System.Text.Encoding.GetEncoding(1252);
                    if (i < secondCharNumber) Console.Write(new string(Convert.ToChar(i), 1) + ' ');
                    else Console.Write(new string(Convert.ToChar(i), 1));
                } 
            }
        }
    }
}