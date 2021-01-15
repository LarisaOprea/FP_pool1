using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema17
{
    class Program
    {
        static void Main(string[] args)
        {
            //17.CMMDC a 2 numere, a si b (folosind Algoritmul lui Euclid)
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            Console.WriteLine("CMMDC este " + a);

            Console.ReadKey();
        }
    }
}
