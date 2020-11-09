using System;

namespace Matematica
{
    class Program
    {
        public static void Main(string[] args)
        {

            int somma =Matematica.Somma(3, 4);
            Console.WriteLine($"la somma intera è: {somma}");

            double sommaDouble = Matematica.SommaDouble(14.0, 21.0);
            Console.WriteLine($"la somma decimale è: {sommaDouble}");

            double moltiplicazione =Matematica.Moltiplicazione(14, 21);
            Console.WriteLine($"la moltiplicazione è: {moltiplicazione}");

            double divisione = Matematica.Divisione(14, 21);
            Console.WriteLine($"la divisione è: {divisione}");

            long potenza = Matematica.Potenza(14, 21);
            Console.WriteLine($"la potenza è: {potenza}");

            long molt = Matematica.Fattoriale(16);
            Console.WriteLine($"il fattoriale è {molt}");

            int min = Matematica.MinorTra(14, 21, 13);
            Console.WriteLine($"il minimo è {min}");

            int max = Matematica.MaggioreTra(14, 21, 13);
            Console.WriteLine($"il massimo è {max}");

            double inverso = Matematica.Inverso(14);
            Console.WriteLine($"il numero inverso è {inverso}");

            bool pari = Matematica.IsPari(21);
            Console.WriteLine($"il numero è pari {pari}");

            bool dispari = Matematica.IsDispari(21);
            Console.WriteLine($"il numero è dispari{dispari}");

            bool positivo = Matematica.IsPositivo(21);
            Console.WriteLine($"il numero è positivo: {positivo}");

            bool negativo = Matematica.IsNegativo(21);
            Console.WriteLine($"il numero è positivo: {negativo}");

            bool intero = Matematica.IsIntero(21);
            Console.WriteLine($"il numero è intero: {intero}");


        }
    }
}

