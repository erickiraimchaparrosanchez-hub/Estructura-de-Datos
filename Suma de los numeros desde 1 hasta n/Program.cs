//Programa 10.- Este programa trata sobre la suma de numeros desde 1 hasta n
using System;
class Program
{
    static int MetodoA(int n)
    {
        if (n <= 0) return 0;
        return n + MetodoB(n - 1);
    }

    static int MetodoB(int n)
    {
        if (n <= 0) return 0;
        return n + MetodoA(n - 1);
    }
    static void Main()
    {
        Console.Write("Ingresa un numero n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            int suma = MetodoA(n);
            Console.WriteLine($"La suma de los números de 1 a {n} es: {suma}");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
    }
}
