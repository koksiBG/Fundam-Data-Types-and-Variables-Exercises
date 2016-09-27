using System;

namespace Reverse_Characters
{
    class Reverse_Characters
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            Console.WriteLine($"{three}{two}{one}");
        }
    }
}