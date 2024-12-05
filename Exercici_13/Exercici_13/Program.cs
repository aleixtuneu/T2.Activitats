using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex13
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número enter (minuts): ";
            const string MSGRESULT = "Resultat en segons: {0}";
            const string MSGERROR = "Error. Introdueix un valor vàlid.";

            double input = 0;

            Console.WriteLine(MSGHELLO);

            while (!double.TryParse(Console.ReadLine(), out input) || input < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            Console.WriteLine(MSGRESULT, MinutesToSeconds(input));
        }

        public static double MinutesToSeconds(double input)
        {
            double result = input*60;

            return result;
        }
    }
}
