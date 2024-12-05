using System;
using activitiesUtils;

namespace T2.Activitats
{
    public class Program
    {
        // Ex18
        public static void Main()
        {
            const string MSGHELLO = "Introdueix una edat: ";
            const string MSGERROR = "Error. Has d'introduir un valor enter entre 0 i 120.";

            int edat = 0;

            Console.WriteLine(MSGHELLO);

            while(!int.TryParse(Console.ReadLine(), out edat) || !Utils.IsValidAge(edat))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
        }
    }
}
