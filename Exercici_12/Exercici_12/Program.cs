using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex12
        public static void Main()
        {
            const string MSGHELLO = "Introdueix els graus en Celsius: ";
            const string MSGRESULT = "Graus en Fahrenheit: {0}FF";
            const string MSGERROR = "Error. Introdueix un valor vàlid.";

            double input = 0;

            Console.WriteLine(MSGHELLO);
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            Console.WriteLine(MSGRESULT, CelsiusToFahrenheit(input));
        }

        public static double CelsiusToFahrenheit(double input)
        {
            double result = 0;
            double fahrenheit = 0;

            fahrenheit = (input * 9 / 5) + 32;
            result = Math.Round(fahrenheit, 2);

            return result;
        }
    }
}