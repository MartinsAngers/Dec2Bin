using System;

namespace d2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal: "); // uzrakstīs tekstu Decimal:
            int decimalNumber = int.Parse(Console.ReadLine()); // aiz teksta Decimal: pieprasīs ierakstīt skaitli

            int trying; //integer modulis 
            string result = String.Empty;
            while (decimalNumber > 0)
            {
                trying = decimalNumber % 2;
                decimalNumber /= 2;
                result = trying.ToString() + result;
            }
            Console.WriteLine("Binary: {0}",result);
        }
    }
}
