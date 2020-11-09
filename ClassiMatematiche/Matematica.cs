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
            double somma = n1 + n2;
            return somma;
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
        public static long Potenza(int n1, int n2)
        {
            int i;
            long potenza = 1;
            for (i = 0; i < n2; i++)
            {
                potenza *= n1;
            }
            return potenza;
        }
        public static long Fattoriale(int n1)
        {
            long fattoriale = 1;
            for (int i = 2; i <= n1; i++)
            {
                fattoriale = fattoriale * i;
            }
            return fattoriale;
        }
        public static int MinorTra(int n1, int n2, int n3)
        {
            int Min = Math.Min(n1, Math.Min(n2, n3));
            return Min;
        }
        public static int MaggioreTra(int n1, int n2, int n3)
        {
            int max = Math.Max(n1, Math.Max(n2, n3));
            return max;
        }
        public static double Inverso(double n1)
        {
            double inverso = n1 * -1;
            return inverso;
        }
        public static bool IsPari(int n1)
        {
            return n1 % 2 == 0;
        }
        public static bool IsDispari(int n1)
        {
            return !IsPari(n1);
        }
        public static bool IsPositivo(int n1)
        {
            return n1 > 0;
        }
        public static bool IsNegativo(int n1)
        {
            return n1 < 0;
        }
        public static bool IsIntero(double n1)
        {
            return n1 == (int)n1;
        }
    }
}
