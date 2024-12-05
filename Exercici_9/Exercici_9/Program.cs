using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.9
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número: ";
            const string MSGDIGITS = "Total de dígits: ";
            const string MSGSUMAPARELLS = "Suma dels dígits amb valor parell: ";
            const string MSGSUMASENARS = "Suma dels dígits amb valor senar: ";

            int input = 0;
            string stringInput = "";
            

            Console.WriteLine(MSGHELLO);
            input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            stringInput = input.ToString();

            Console.WriteLine(MSGDIGITS + TotalDigits(stringInput));
            Console.WriteLine();

            Console.WriteLine(MSGSUMAPARELLS + SumaDigitsParells(stringInput));
            Console.WriteLine();

            Console.WriteLine();

        }

        public static int TotalDigits(int input)
        {
            string inputString = input.ToString();
            return inputString.Length;
        }

        public static int SumaDigitsParells(int input)
        {
            string inputString = input.ToString();
            int sumaParells = 0;
            int num = 0;

            foreach(char digit in inputString)
            {
                num = Convert.ToInt32(digit);
                if (num % 2 == 0)
                {
                    sumaParells += num;
                }
            }
            return sumaParells;
        }

        public static int SumaDigitsSenars(int input)
        {
            int num = 0;
            int sumaSenars = 0;
            string inputString = input.ToString();

            foreach (int digit in inputString)
            {
                num = Convert.ToInt32(digit);
                if (num % 2 == 1)
                {
                    sumaSenars += num;
                }
            }
            return sumaSenars;
        }
    }
}
