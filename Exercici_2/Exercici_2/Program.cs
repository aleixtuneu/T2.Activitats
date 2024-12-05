using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.2
        public static void Main()
        {
            const string MSGBASE = "Introdueix la base d'un número per calcular la seva potència: ";
            const string MSGEXPONENT = "Introdueix l'exponent: ";
            const string MSGRESULT = "Resultat de la potència: ";

            double numBase = 0;
            int numExp = 0;           


            Console.WriteLine(MSGBASE);
            numBase = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(MSGEXPONENT);
            numExp = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(MSGRESULT + CalcularPotencia(numBase, numExp));
        }

        public static double CalcularPotencia(double numBase, int numExp)
        {
            double result = 1;
            int expAbs = (numExp < 0) ? (-1) * numExp : numExp;

            if (numExp == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < expAbs; i++)
                {
                    result *= numBase;
                }
                result = (numExp > 0) ? result : 1 / result;
            }

            return result;
        }
    }
}
