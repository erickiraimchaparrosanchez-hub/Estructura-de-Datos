//Progrma 2.- Este programa se encarga de calcular el factorial de un numero por el metodo de fibonacci
using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static Dictionary<int, BigInteger> memo = new Dictionary<int, BigInteger>();

    static BigInteger Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("n debe ser >= 0");
        if (n <= 1) return 1;

        BigInteger cached;
        if (memo.TryGetValue(n, out cached)) return cached;

        BigInteger result = n * Factorial(n - 1);
        memo[n] = result;
        return result;
    }

    static BigInteger FactorialIterativo(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n + "! (recursivo) = " + Factorial(n));
        Console.WriteLine(n + "! (iterativo) = " + FactorialIterativo(n));
    }
}
