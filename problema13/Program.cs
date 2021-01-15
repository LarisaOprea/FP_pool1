using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema13
{
    class Program
    {
        static void Main(string[] args)
        {
            ///13.Determianti cati ani bisecti sunt intre anii y1 si y2.
            int y1, y2, nr = 0;
            bool bisect;
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            for (int i = y1; i <= y2; i++)
            {
                bisect = false;
                if ((i % 4 == 0) && (i % 100 != 0)) bisect = true;
                if (i % 400 == 0) bisect = true;
                if (bisect == true) nr++;
            }
            Console.WriteLine("Sunt " + nr + " ani bisecti");

            Console.ReadKey();
        }
    }
}
