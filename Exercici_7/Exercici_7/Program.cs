using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.7
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un text: ";
            const string MSGOPTION = "Què vols fer? \n1.Passar a majúscules. \n2.Passar a Minúscules.";
            const string MSGKO = "Selecciona una opció vàlida.";
            const string MSGRESULT = "Resultat: ";

            string input = "";
            int option = 0;
            bool opcioValida;

            Console.WriteLine(MSGHELLO);
            input = Console.ReadLine();
            Console.WriteLine();

            do
            {
                Console.WriteLine(MSGOPTION);
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (option < 1 || option > 2);

            Console.Write(MSGRESULT);

            switch (option)
            {
                case 1:
                    Console.Write(input.ToUpper());
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write(input.ToLower());
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
