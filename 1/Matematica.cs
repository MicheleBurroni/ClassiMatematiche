using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
    class Matematica
    {
        public static int Somma(int n1, int n2)
        {
            int somma = n1 + n2;
            return somma;
        }
        public static double SommaDouble(double n1, double n2)
        {
            double sommaDouble = n1 + n2;
            return sommaDouble;
        }
        public static double Sottrazione(double n1, double n2)
        {
            double sottrazione = n1 - n2;
            return sottrazione;
        }
        public static double Moltiplicazione(double n1, double n2)
        {
            double moltiplicazione = n1 * n2;
            return moltiplicazione;
        }
        public static double Divisione(double n1, double n2)
        {
            double divisione = n1 / n2;
            return divisione;
        }

        public static long Potenza(long n1, long n2)
        {
            int i;
            long = potenza = 1;
            for (i = 0; i < n1; i++)
            {
                potenza *= n1;
            }
            return potenza;
        }
        public static long fattoriale(int n1)
        {
            int fattoriale = 1;
            for (i = 2; i <= n1; i++)
            {
                fattoriale = fattoriale * 1;
            }
            return fattoriale;
        }
    }
}
