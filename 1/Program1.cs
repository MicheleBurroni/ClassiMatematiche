using System;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            int somma = Matematica.Somma(14, 21);
            Console.WriteLine($"La somma tra due questi numeri è: {somma}");

            double sommaDouble = Matematica.SommaDouble(14.1, 21.6);
            Console.WriteLine($"La somma tra due questi numeri è: {sommaDouble}");

            double sottrazione = Matematica.Sottrazione(14.1, 21.6);
            Console.WriteLine($"La differenza tra questi due numeri è: {sottrazione}");

            double moltiplicazione = Matematica.Moltiplicazione(14.1, 21.6);
            Console.WriteLine($"La moltiplicazione tra questi due numeri è: {moltiplicazione}");

            double divisione = Matematica.Divisione(14.1, 21.6);
            Console.WriteLine($"La divisione tra questi due numeri è: {divisione}");

            long potenza = Matematica.Potenza(14, 21);
            Console.WriteLine($"La potenza tra questi due numeri è: {potenza}");

            long moltf = Matematica.Fattoriale(16);
            Console.WriteLine($"Il fattoriale due numeri è:{moltf}");



        }
        
    }
}

