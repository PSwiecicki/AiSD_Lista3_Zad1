using System;

namespace AiSD_Lista3_Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz implementację w jezyku C# funkcji rekurencyjnych, które wyznaczają:
            Console.WriteLine(Geometryczny(3, 2, 4));
        }

        //a) n-ty wyraz ciągu fibonacciego
        static int Fibo(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return (Fibo(n - 1) + Fibo(n - 2));
        }

        //b) a do potęgi n
        static int Potega(int a, int n)
        {
            if (a == 0 & n == 0)
                return -1;
            if (n == 0)
                return 1;
            if (n == 1)
                return a;
            return a * Potega(a, n - 1);
        }

        //c)n!
        static int Silnia(int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return 1;
            return n * Silnia(n - 1);
        }

        //d)n-ty wyraz ciągu arytmetycznego
        static int Arytmetyczny(int a1, int r, int n)
        {
            if (n < 1)
                return -1;
            if (n == 1)
                return a1;
            return r + Arytmetyczny(a1, r, n - 1);
        }

        //e)n-ty wyraz ciągu geometrycznego
        static int Geometryczny(int a1, int q, int n)
        {
            if (n < 1)
                return -1;
            if (n == 1)
                return a1;
            return q * (Geometryczny(a1, q, n - 1));
        }
    }
}
