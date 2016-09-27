using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer
{
    class Thea_the_Photographer
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int FT = int.Parse(Console.ReadLine());
            int FF = int.Parse(Console.ReadLine());
            int UT = int.Parse(Console.ReadLine());
            double percentage = FF / 100.0;
            int uploadPictures = (int)Math.Ceiling(N * percentage);
            long updatePictures = N * (long)FT;
            long uploadedPictures = uploadPictures * (long)UT;
            long totalPictures = updatePictures + uploadedPictures;
            Console.WriteLine(TimeSpan.FromSeconds(totalPictures).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }
    }
}