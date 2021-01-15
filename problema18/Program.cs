using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema18
{
    class Program
    {
        static void Main(string[] args)
        {
            ///18.Afisati descompunerea in factori primi ai unui numar n.  
            ///De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 
            int n, x = 2, nr = 0;
            n = int.Parse(Console.ReadLine());
            while (n != 1)
            {
                if (n % x == 0)
                {
                    n = n / x;
                    nr++;
                }
                else
                {
                    if (nr != 0) Console.WriteLine(x + " la puterea " + nr);
                    x++;
                    nr = 0;
                }
            }
            if (nr > 0) Console.WriteLine(x + " la puterea " + nr);

            Console.ReadKey();
        }
    }
}
