using System;
namespace T2.Activitats
{
    public class Program
    {
        // Ex16
        public static void Main()
        {
            const string MSGHELLO = "Introdueix un número romà: ";
            const string MSGRESULT = "Numeo romà en decimal: {0}.";

            string input = "";

            Console.WriteLine(MSGHELLO);
            input = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(MSGRESULT, RomanToDecimal(input));
        }

        public static int RomanToDecimal(string input)
        {
            int result = 0;

            foreach (char c in input.ToUpper())
            {
                switch (c)
                {
                    case 'I':
                        result += 1;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        result += 10;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        result += 100;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                    default:

                        break;
                }
            }

            return result;
        }
    }
}
