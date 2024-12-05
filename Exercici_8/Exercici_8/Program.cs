using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.8
        public static void Main()
        {
            const string MSGONE = "Introdueix el primer valor: ";
            const string MSGTWO = "Introdueix el segon valor: ";
            const string MSGRESULT = "Valors intercanviats: ";

            string inputOne = "";
            string inputTwo = "";

            Console.WriteLine(MSGONE);
            inputOne = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(MSGTWO);
            inputTwo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(MSGRESULT);
            Console.WriteLine(MostrarValorsIntercanviats(inputOne, inputTwo));
        }

        public static string MostrarValorsIntercanviats(string inputOne, string inputTwo)
        {
            string result = $"Valor 1: {inputTwo} \nValor 2: {inputOne}";
            return result;
        }
    }
}
