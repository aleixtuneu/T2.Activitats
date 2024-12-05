using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.4
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número: ";
            const string MSGOK = "El número introduït és positiu i menor que 100.";
            const string MSGKO = "El número introduït no és positiu i menor que 100.";

            double input = 0;

            Console.WriteLine(MSGHELLO);
            input = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(ValidarNumero(input)? MSGOK : MSGKO);
        }

        public static bool ValidarNumero(double input)
        {
            const int MAX = 100;
            const int MIN = 0;
            
            return ((input < 100) && (input > 0));
        }
    }
}
