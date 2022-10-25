using System;

namespace PremierExercice
{
    public class Program
    {

        static void Main(string[] args)
        {

            int realNbr = CheckStrNumber();

            if (EstPremier(realNbr))
            {
                Console.WriteLine(realNbr+ " est premier");
            }
            else
            {
                Console.WriteLine(realNbr + " est non premier");
            }

            Console.ReadKey();
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
