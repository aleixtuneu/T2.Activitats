using System;
using activitiesUtils;

namespace T2.Activitats
{
    public class Program
    {
        // Ex19
        public static void Main()
        {
            const string MSGHELLO = "Introdueix una edat: ";
            const string MSGERROR = "Error. Introdueix un valor natural.";
            const string MSGRESULT = "Descompte aplicat: {0}%.";

            int edat = 0;

            Console.WriteLine(MSGHELLO);

            while (!int.TryParse(Console.ReadLine(), out edat) || edat < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            Console.WriteLine(MSGRESULT, Utils.AppliedDiscount(edat));
        }
    }
}