using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.2
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número per validar si es negatiu: ";
            const string MSGOK = "El número introduït és negatiu.";
            const string MSGKO = "El número introduït no és negatiu.";

            double input = 0;

            Console.WriteLine(MSGHELLO);
            input = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(EsNegatiu(input) ? MSGOK : MSGKO);
        }

        public static bool EsNegatiu(double input)
        {
            if (input < 0)
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