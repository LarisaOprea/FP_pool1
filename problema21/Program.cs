using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema21
{
    class Program
    {
        static void Main(string[] args)
        {
            ///21.Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"
            int st, dr, mij, rasp;
            bool ghicit = false;
            st = 1;
            dr = 1024;
            mij = (st + dr) / 2;
            while (ghicit == false)
            {
                Console.WriteLine("Este numarul mai mare decat " + mij + "?");
                Console.WriteLine("1.Numarul este " + mij);
                Console.WriteLine("2.Numarul este mai mic decat " + mij);
                Console.WriteLine("3.Numarul este mai mare decat" + mij);
                rasp = int.Parse(Console.ReadLine());
                if (rasp == 1)
                {
                    ghicit = true;
                    Console.WriteLine("Ai ghicit nr!");
                }
                else if (rasp == 2) { dr = mij; mij = (st + mij) / 2; }
                else if (rasp == 3) { st = mij; mij = (dr + mij) / 2; }
            }

        }
    }
}
