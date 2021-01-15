using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema15
{
    class Program
    {
        static void Main(string[] args)
        {
            ///15.Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && b > c) Console.WriteLine(c + " " + b + " " + a);
            else if (a > c && c > b) Console.WriteLine(b + " " + c + " " + a);
            else if (b > a && a > c) Console.WriteLine(c + " " + a + " " + b);
            else if (b > c && c > a) Console.WriteLine(a + " " + c + " " + b);
            else if (c > a && a > b) Console.WriteLine(b + " " + a + " " + c);
            else if (c > b && b > a) Console.WriteLine(a + " " + b + " " + c);

            Console.ReadKey();
        }
    }
}
