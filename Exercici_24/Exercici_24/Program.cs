using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex24
        public static void Main()
        {
            const string MSGONE = "Introdueix el primer valor: ";
            const string MSGTWO = "Introdueix el segon valor: ";
            const string MSGERROR = "Error. Introdueix un valor vàlid.";
            const string MSGRESULT = "Resultat del producte: {0}";

            int inputOne = 0;
            int inputTwo = 0;
            int result = 0;

            Console.WriteLine(MSGONE);
            while (!int.TryParse(Console.ReadLine(), out inputOne))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            Console.WriteLine(MSGTWO);
            while (!int.TryParse(Console.ReadLine(), out inputTwo))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            result = MetodeRus(inputOne, inputTwo);

            Console.WriteLine(MSGRESULT, result);
        }

        public static int MetodeRus(int inputOne, int inputTwo)
        {
            if (inputOne == 1) return 0;

            return MetodeRus(inputTwo * 2) + MetodeRus(inputOne / 2);
        }
    }
}
