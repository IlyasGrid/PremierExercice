using System;

namespace PremierExercice
{
    public class Program
    {

        static void Main(string[] args)
        {
            /*Console.WriteLine("table demension est  10  est suffisant ? (Y/N)");*/
            int max=10;
            int[] table = new int[max];

            table[0] = 1;
            table[1] = 2;
            table[2] = 3;
            table[3] = 4;

            ShowTable(table);
            int i=0;
            while (table[i])
            {
                i++;
            }

            for (int i = 9; i >= 0; i--)
            {


                int nbr = CheckStrNumber();
               
                {
                    table[i] = nbr;
                }
                


            }

            /*int realNbr = CheckStrNumber();

            if (EstPremier(realNbr))
            {
                Console.WriteLine(realNbr+ " est premier");
            }
            else
            {
                Console.WriteLine(realNbr + " est non premier");
            }*/

            Console.ReadKey();
        }
        public static void ShowTable(int[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }
        public static int CheckStrNumber()
        {
            bool isNumeric;
            int realNbr; // ou on va stocker le nbr
            /*bool estPremier = true;*/
            do
            {
                Console.WriteLine("Entrez un nombre");
                string strnumber = Console.ReadLine();
                isNumeric = int.TryParse(strnumber, out realNbr);

                Console.WriteLine();

            } while (!isNumeric);
            return realNbr;
        }
        public static bool EstPremier(int number)
        {
            if (number <= 2)
            {
                return true;
            }
            else
            {

                double sqrtNbr = Math.Sqrt(number);

                for (int i = 2; i <= sqrtNbr; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
