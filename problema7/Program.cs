using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
            ///Se cere sa se inverseze valorile lor.
            int a, b, aux;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

            Console.ReadKey();
        }
    }
}
