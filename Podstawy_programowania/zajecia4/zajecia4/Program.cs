using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int[,] values = new int[,]
           
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    Console.Write("{0}\t", values[i,j]);
                    
                    
                }
                Console.WriteLine();
            }
            */






            /*
            int[,] values = new int[3,3];
                for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    values[i, j] = i * 3 + j;
                    Console.Write("{0}\t", values[i, j]);
                }
                Console.WriteLine();
            }
            */



            //TABLICE NIEREGULARNE

            /*
            string[][] country = new string[4][];

            Console.WriteLine("Rozmiar zewnętrznego wymiaru tablicy nieregularnej: {0}\n", country.Length);
            */




            int[][] number = new int[3][]
            {
                new int[] {1, 2},
                new int[] {3, 4, 5, 6},
                new int[] {7}
            };

            /*
             * wyświetl zawartość tablicy number
             * 
             * number[0, 0] = 1
             * number[0, 1] = 2
             * 
             * number[1, 0] = 3
             * number[1, 1] = 4
             * number[1, 2] = 5
             * number[1, 3] = 6
             * 
             * number[2, 0] = 7
             */



            for (int i = 0; i < number.GetLength(0); i++) 
            {
                for (int j = 0; j < number[i].Length; j++) 
                {
                    Console.WriteLine("number[{0}][{1}]={2}", i, j, number[i][j]);
                }
                Console.WriteLine();
            }



            //uproszczone wyrażenia inicjalizacji tablic

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine(vowels[0]); //a

            
            byte[,] age = 
            {
                {20, 30},
                {15, 35},
                {25, 35}
            };
            Console.WriteLine(age[2,0]); //25


            string[][] name =
            {
                new string[] {"Katarzyna"},
                new string[] {"Krzysztof", "Anna"},
                new string[] {"Paweł"}
            };
            Console.WriteLine(name[1][1]); //Anna



            //ilość wymiarów
            /*
            Console.WriteLine("Samogłoski: {0}", vowels.Rank); //1 wymiar
            Console.WriteLine("Wiek: {0}", age.Rank); // 2 wymiary 
            Console.WriteLine("Imię: {0}", name.Rank); // 1 wymiar
            */


            /*
             * Zapisz w tablicy tłumaczenia słow:
             * 
             * 1    Poniedziałek    Monday
             * 2    Wtorek          Tuesday
             * 
             * Użytkownik wprowadzenie z klawiatury polskie słowo i angielskie tłumaczenie
             */


            string[,] values = new string[7,2];
            
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Podaj {0} dzień tygodnia po polsku: ", i);
                    string dzien1polski = Console.ReadLine();
                    Console.Write("Podaj {0} dzień tygodnia po angielsku: ", i);
                    string dzien1angielski = Console.ReadLine();
                    values[i, j] = dzien1polski;
                    values[i, j] = dzien1angielski;
                    
                }
            }





            Console.ReadKey();
                

        }
    }
}
