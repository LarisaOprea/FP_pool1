using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            ///6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Se poate forma un triunghi");
            }
            else Console.WriteLine("Nu se poate forma un triunghi");

            Console.ReadKey();
        }
    }
}
