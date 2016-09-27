using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Boolean_Variable
    {
        static void Main(string[] args)
        {
            string imputboolean = Console.ReadLine();
            if (Convert.ToBoolean(imputboolean)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}