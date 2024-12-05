using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.6
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número: ";
            const string MSGRESULT = "El valor absolut del número introduït és: ";

            double input = 0;

            Console.WriteLine(MSGHELLO);
            input = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(MSGRESULT + ValorAbsolut(input));
        }

        public static double ValorAbsolut(double input)
        {
            double result = (input < 0) ? (-1) * input : input;

            return result;
        }
    }
}