using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///3.Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (n % k == 0) Console.WriteLine("n este divizibil cu k");
            else Console.WriteLine("n nu este divizibil cu k");

            Console.ReadKey();
        }
    }
}
