using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema14
{
    class Program
    {
        static void Main(string[] args)
        {
            ///14.Determianti daca un numar n este palindrom. 
            ///(un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            int n, palindrom = 0, x;
            n = int.Parse(Console.ReadLine());
            //in x salvam n-ul initial
            x = n;
            while (n != 0)
            {
                palindrom = palindrom * 10 + n % 10;
                n = n / 10;
            }
            if (palindrom == x) Console.WriteLine("Numarul este palindrom");
            else Console.WriteLine("Numarul nu este palindrom");

            Console.ReadKey();
        }
    }
}
