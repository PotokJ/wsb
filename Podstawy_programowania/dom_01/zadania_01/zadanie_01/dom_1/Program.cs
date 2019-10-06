using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zadanie 1

            Console.WriteLine("Program liczy wyrażenie (a^2+b)/(a+b)^2");

            int q = 0;

            do
            {

                Console.Write("Podaj pierwszą liczbę a: ");
                float a = float.Parse(Console.ReadLine());

                Console.Write("Podaj drugą liczbę b: ");
                float b = float.Parse(Console.ReadLine());

                float result = (a * a + b) / ((a + b) * (a + b));

                if ((a + b) * (a + b) == 0)
                    Console.WriteLine("Próba dzielenia przez 0");

                else
                    Console.WriteLine("Wynik wyrażenia to: " + result);
                Console.WriteLine("");

            } while (q < 1);

            Console.ReadKey();

        }
    }
}
