using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema19
{
    class Program
    {
        static void Main(string[] args)
        {
            ///19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
            ///De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

            int n, a = 0, b = 0, nr;
            n = int.Parse(Console.ReadLine());
            a = n % 10;
            nr = 1;
            while (n > 9)
            {
                n = n / 10;
                if ((n % 10 != a) && (nr == 1))
                {
                    b = n % 10;
                    nr = 2;
                }
                if ((nr == 2) && (n % 10 != a) && (n % 10 != b))
                {
                    nr++; Console.WriteLine(n % 10);
                }
            }
            if (nr == 2) Console.WriteLine("Numarul are in scriere doar 2 cifre");
            else Console.WriteLine("Numarul nu are in scriere doar 2 cifre");

            Console.ReadKey();
        }
    }
}
