using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_04
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zadanie 3

            Console.WriteLine("Program oblicza największy wspólny dzielnik dwóch podanych liczb");

            Console.Write("Podaj pierwszą liczbę: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Największy wspólny dzielnik podanych liczb to: " + GCD(x, y));

            Console.ReadKey();
        }

        //Szukanie

        static int GCD(int x, int y)
        {
            while (y != 0)
            {
                int tmp = x % y;
                x = y;
                y = tmp;
            }
            return x;
        }
    }
}
