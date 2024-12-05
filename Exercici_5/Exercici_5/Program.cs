using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex.5
        public static void Main()
        
        {
            const string MSGHELLO = "Introdueix un número: ";
            const string MSGOK = "El número introduït és natural.";
            const string MSGKO = "El número introduït no és natural.";
            const string MSGINTENT = "Intent ";
            const string MSGEND = "Has acabat els intents.";
            const int MAXINTENTS = 3;

            int intent = 0;
            double input = 0.00;

            while (intent < MAXINTENTS)
            {
                Console.WriteLine(MSGINTENT + $"{intent + 1}");
                Console.WriteLine(MSGHELLO);
                input = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (ValidarInput(input))
                {
                    Console.WriteLine(MSGOK);
                    intent = MAXINTENTS;
                }
                else
                {
                    Console.WriteLine(MSGKO);
                    Console.WriteLine();
                    intent++;
                }
            }

            if ((intent >= MAXINTENTS) && (!ValidarInput(input)))
            {
                Console.WriteLine(MSGEND);
            }
            
        }

        public static bool ValidarInput(double input)
        {
            int dif = Convert.ToInt32(input);
            double decim = input - dif;

            if ((input > 0) && (decim == 0))
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
