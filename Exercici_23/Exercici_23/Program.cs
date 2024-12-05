using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex23
        public static void Main()
        {
            const string MSGHELLO = "Quantes temperatures vols introduïr?";
            const string MSGINPUT = "Introdueix la temperatura #{0}: ";
            const string MSGERROR = "Error. Introdueix un valor vàlid.";
            const string MSGOPTION = "Què vols fer? \n1. Mostrar temperatures ordenades ascendentment. \n2. Buscar temperatura.";
            const string MSGVALORSORDENATS = "Temperatures ordenades ascendentment: ";
            const string MSGSEARCH = "Quina temperatura vols buscar? ";
            const string MSGOK = "La temperatura està dins dels valors introduïts.";
            const string MSGKO = "La temperatura no està dins dels valors introduïts.";

            int size = 0;
            int option = 0;
            double input = 0;
            double search = 0;
            double[] temperatures;
            double[] valorsOrdenats;
            

            Console.WriteLine(MSGHELLO);
            while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            temperatures = new double[size];
            valorsOrdenats = new double[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(MSGINPUT, i+1);
                while (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine();
                    Console.WriteLine(MSGERROR);
                }
                Console.WriteLine();
                temperatures[i] = input;
            }

            Console.WriteLine(MSGOPTION);
            while(!int.TryParse(Console.ReadLine(), out option) || (option != 1 && option != 2))
            {
                Console.WriteLine();
                Console.WriteLine(MSGERROR);
            }
            Console.WriteLine();

            switch (option)
            {
                case 1:
                    valorsOrdenats = OrdenarValors(temperatures);

                    Console.WriteLine(MSGVALORSORDENATS);
                    foreach (double valor in valorsOrdenats)
                    {
                        Console.Write(valor + " ");
                    }
                    Console.WriteLine();

                    break;

                case 2:
                    Console.WriteLine(MSGSEARCH);
                    while (!double.TryParse(Console.ReadLine(), out search))
                    {
                        Console.WriteLine();
                        Console.WriteLine(MSGERROR);
                    }
                    Console.WriteLine();

                    Console.WriteLine(BuscarValor(temperatures, search) ? MSGOK : MSGKO);
                    break;

                default:
                    Console.WriteLine();
                    break;
            }

        }

        public static double[] OrdenarValors(double[] temperatures)
        {
            double aux = 0;

            for (int i = 0; i < temperatures.Length - 1; i++)
            {
                for (int j = i + 1; j < temperatures.Length; j++)
                {
                    if (temperatures[i] > temperatures[j])
                    {
                        aux = temperatures[i];
                        temperatures[i] = temperatures[j];
                        temperatures[j] = aux;
                    }
                }
            }

            return temperatures;
        }

        public static bool BuscarValor(double[] temperatures, double search)
        {
            int i = 0;
            bool found = false;

            while ((i < temperatures.Length) && (!found))
            {
                if (temperatures[i] == search)
                {
                    found = true;
                }
                i++;
            }
            return found;
        }
    }
}
