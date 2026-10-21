//Programa 8.- Programa trata de una cuenta regresiva desde un numero hasta 0
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un número para la cuenta regresiva:");
        int numero = int.Parse(Console.ReadLine());

        MetodoA(numero);
    }
    static void MetodoA(int n)
    {
        if (n < 0) return;
        Console.WriteLine(n);

        if (n == 0)
        {
            Console.WriteLine("¡Cuenta regresiva completa!");
            return;
        }
        MetodoB(n - 1);

    }
    static void MetodoB(int n)
    {
        if (n < 0) return;

            Console.WriteLine(n);

            if (n == 0)
            {
                Console.WriteLine("¡Cuenta regresiva completa!");
                return;
            }
            MetodoA(n - 1);
    }
}
