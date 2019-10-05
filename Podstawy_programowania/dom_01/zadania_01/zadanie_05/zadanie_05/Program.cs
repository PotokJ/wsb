using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program sprawdza czy podana liczba jest liczbą pierwszą");

            for (; ; )
            {

                Console.Write("Podaj liczbę: ");
                int n = int.Parse(Console.ReadLine());
                if (IsPrime(n))
                {
                    Console.WriteLine("{0} jest liczbą pierwszą", n);
                }
                else
                {
                    Console.WriteLine("{0} nie jest liczbą pierwszą", n);
                }
            }

            bool IsPrime(int n)
            {
                if (n > 1)
                {
                    return Enumerable.Range(1, n).Where(x => n % x == 0)
                                     .SequenceEqual(new[] { 1, n });
                }

                return false;
            }

        }
    }
}
