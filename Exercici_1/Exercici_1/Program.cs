using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.1
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número: ";
            const string MSGOK = "El número introduït és natural.";
            const string MSGKO = "El número introduït no és natural.";

            double input = 0.00;

            Console.WriteLine(MSGHELLO);
            input = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ValidarInput(input))
            {
                Console.WriteLine(MSGOK);
            }
            else
            {
                Console.WriteLine(MSGKO);
            }
        }

        public static bool ValidarInput(double input)
        {
            int dif = Convert.ToInt32(input);
            double decim = input - dif;

            if ((input > 0) && (decim == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
