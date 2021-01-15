using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: 
            ///ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.
            float a, b, c, delta;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if (a == 0) Console.WriteLine("Ecuatia nu este de gradul 2");
            else
            {
                delta = b * b - 4 * a * c;
                if (delta == 0) Console.WriteLine("x=" + (-b / (2 * a)));
                else if (delta > 0)
                {
                    Console.WriteLine(("x1=" + ((-b + Math.Sqrt(delta)) / (2 * a))));
                    Console.WriteLine(("x2=" + ((-b - Math.Sqrt(delta)) / (2 * a))));
                }
                else Console.WriteLine("Nu exista solutie reala!");
                }

                Console.ReadKey();
            }
    }
}
