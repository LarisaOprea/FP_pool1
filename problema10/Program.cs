using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            ///10.Test de primalitate: determinati daca un numar n este prim.
            int n;
            bool prim = true;
            n = int.Parse(Console.ReadLine());
            if ((n == 1) || (n == 0)) Console.WriteLine("Numarul nu este prim");
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0) prim = false;
                }
                if (prim == true) Console.WriteLine("Numarul este prim");
                else Console.WriteLine("Numarul nu este prim");
            }

            Console.ReadKey();
            }
    }
}
