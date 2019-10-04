using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Przykład 1:

            Console.WriteLine("a) Program liczy wartość wyrażenia: a^2+b, dla c>0");

            Console.Write("Podaj liczbę a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę c: ");
            double c = double.Parse(Console.ReadLine());

            double result = a * a + b;

            if (c <= 0)
                Console.WriteLine("Podane c jest mniejsze lub równe 0");
            else
                Console.WriteLine("Wartość wyrażenia wynosi: " + result);

            Console.WriteLine("");


            //Przykład 2

            Console.WriteLine("b) Program liczy wartość wyrażenia: a-b^2, dla c<0");

            Console.Write("Podaj liczbę a: ");
            double a1 = double.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę b: ");
            double b1 = double.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę c: ");
            double c1 = double.Parse(Console.ReadLine());

            double result1 = a1 - b1 * b1;

            if (c1 >= 0)
                Console.WriteLine("Podane c jest większe lub równe 0");
            else
                Console.WriteLine("Wartość wyrażenia wynosi: " + result1);

            Console.WriteLine("");


            //Przykład 3

            Console.WriteLine("c) Program liczy wartość wyrażenia: 1/a-b, dla c=0");

            Console.Write("Podaj liczbę a: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę b: ");
            double b2 = double.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę c: ");
            double c2 = double.Parse(Console.ReadLine());

            double result2 = 1 / (a2 - b2);

            if (c2 != 0)
                Console.WriteLine("Podane c jest rózne od 0");
            else
                 if (a2 - b2 == 0)
                Console.WriteLine("Próba dzielenia przez 0");
                 else
                Console.WriteLine("Wartość wyrażenia wynosi: " + result2);


            Console.ReadKey();
        }
    }
}
