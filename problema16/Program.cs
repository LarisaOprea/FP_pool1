using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema16
{
    class Program
    {
        static void Main(string[] args)
        {
            //16.Se dau 5 numere, sa se afiseze in ordine crescatoare
            int[] v = new int[5];
            for (int i = 0; i < 5; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            //SORTARE
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux;
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
            ///16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
            for (int i = 0; i < 5; i++)
            {
                Console.Write(v[i] + " ");
            }
                Console.ReadKey();
            }
    }
}
