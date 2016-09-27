using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Different_Integers_Size
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                long N = long.Parse(number);
                Console.WriteLine($"{N} can fit in:");
                if (N >= sbyte.MinValue && N <= sbyte.MaxValue) Console.WriteLine("* sbyte");
                if (N >= byte.MinValue && N <= byte.MaxValue) Console.WriteLine("* byte");
                if (N >= short.MinValue && N <= short.MaxValue) Console.WriteLine("* short");
                if (N >= ushort.MinValue && N <= ushort.MaxValue) Console.WriteLine("* ushort");
                if (N >= int.MinValue && N <= int.MaxValue) Console.WriteLine("* int");
                if (N >= uint.MinValue && N <= uint.MaxValue) Console.WriteLine("* uint");
                if (N >= long.MinValue && N <= long.MaxValue) Console.WriteLine("* long");
            }
            catch
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}