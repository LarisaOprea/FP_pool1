using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Detreminati daca un an y este an bisect. 
            int y;
            int bisect = 0;
            y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0) && (y % 100 != 0)) bisect = 1;
            if (y % 400 == 0) bisect = 1;
            if (bisect == 1) Console.WriteLine("Anul este bisect");
            else Console.WriteLine("Anul nu este bisect");

            Console.ReadKey();
        }
    }
}
