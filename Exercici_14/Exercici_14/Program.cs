using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex14
        public static void Main()
        {
            const string MSGONE = "Introdueix el primer número enter: ";
            const string MSGTWO = "Introdueix el segon valor enter: ";
            const string MSGERROR = "Error. Introdueix un número vàlid.";
            const string MSGRESULT = "Màxim: {0}. Mínim: {1}.";
            const string MSGSAME = "Els números introduïts tenen el mateix valor.";

            int numberOne = 0;
            int numberTwo = 0;

            Console.WriteLine(MSGONE);
            while (!int.TryParse(Console.ReadLine(), out numberOne))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            Console.WriteLine(MSGTWO);
            while (!int.TryParse(Console.ReadLine(), out numberTwo))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            if (numberOne > numberTwo)
            {
                Console.WriteLine(MSGRESULT, numberOne, numberTwo);
            }
            else if (numberTwo < numberOne)
            {
                Console.WriteLine(MSGRESULT, numberTwo, numberOne);
            }
            else
            {
                Console.WriteLine(MSGSAME);
            }
        }
    }
}
