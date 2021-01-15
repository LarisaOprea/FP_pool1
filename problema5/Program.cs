using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            ///5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. 
            ///Cifrele se numara de la dreapta la stanga.
            int nr = 0, n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (n == 0) Console.WriteLine(n);
            else
                while (n != 0)
                {
                    if (nr == k)
                        Console.WriteLine(n % 10);
                    nr++;
                    n = n / 10;
                }
                    Console.ReadKey();
                }
    }
}
