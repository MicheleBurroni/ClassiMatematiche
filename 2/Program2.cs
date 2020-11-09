using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 21;
            double n2 = 4.4;
            double somma = Matematica2.somma(n1, n2);
            Console.WriteLine($"La somma tra due numeri è: {somma}");
            Console.ReadLine();
        }
    }
}
