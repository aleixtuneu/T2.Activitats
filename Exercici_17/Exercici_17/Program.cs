using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex17
        public static void Main()
        {
            const string MSGHELLO = "Quants números vols introduïr?";
            const string MSGINPUT = "Introdueix el valor #{0}: ";
            const string MSGERROR = "Error. Has d'introduïr un número natural.";
            const string MSGRESULT = "Números introduïts: ";

            int size = 0;
            int input = 0;
            int[] valors;

            Console.WriteLine(MSGHELLO);
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            valors = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(MSGINPUT, i+1);

                while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(MSGERROR);
                }

                valors[i] = input;

                Console.WriteLine();
            }

            Console.WriteLine(MSGRESULT);
            foreach (int num in valors)
            {
                Console.WriteLine(num);
            }
        }
    }
}
