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

            Console.WriteLine("Program liczy sumę cyfr rozwinięcia dziesiętnego podanej liczby naturalnej");
            Console.Write("Podaj liczbę naturalną: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = n; i > 0; i = i / 10)
            {
                sum = sum + i % 10;
            }

            Console.WriteLine("Suma cyfr tej liczby wynosi: " + sum);

            Console.ReadKey();

        }
    }
}
