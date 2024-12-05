using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex15
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número amb decimals: ";
            const string MSGRESULT = "Part entera: {0}. Part decimal: {1}.";
            const string MSGERROR = "Error. Introdueix un número vàlid.";

            double input = 0;
            string inputString = "";
            string partEntera = "";
            string partDecimal = "";

            Console.WriteLine(MSGHELLO);
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            inputString = input.ToString();
            partEntera = ObtenirPartEntera(inputString);
            partDecimal = ObtenirPartDecimal(inputString);

            Console.WriteLine(MSGRESULT, partEntera, partDecimal);
        }

        public static string ObtenirPartEntera(string inputString)
        {
            string[] inputSplit = inputString.Split(",");
            string result = inputSplit[0];
            return result;
        }

        public static string ObtenirPartDecimal(string inputString)
        {
            string[] inputSplit = inputString.Split(",");
            string result = inputSplit[1];
            return result;
        }
    }
}
