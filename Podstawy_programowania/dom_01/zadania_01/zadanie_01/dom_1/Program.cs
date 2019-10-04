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
            Console.Write("Podaj liczbę a: ");
            float bokA = float.Parse(Console.ReadLine());

            Console.Write("Podal liczbę b: ");
            float bokB = float.Parse(Console.ReadLine());

            float result = (bokA * bokA + bokB) / ((bokA + bokB) * (bokA + bokB));

            //float zero = (bokA + bokB) * (bokA + bokB);
            //if (zero == 0)
            if ((bokA + bokB) * (bokA + bokB) == 0)
                Console.WriteLine("Próba dzielenia przez 0");
            else
                Console.WriteLine("Wynik wyrażenia to: " + result);


            Console.ReadKey();

        }
    }
}
