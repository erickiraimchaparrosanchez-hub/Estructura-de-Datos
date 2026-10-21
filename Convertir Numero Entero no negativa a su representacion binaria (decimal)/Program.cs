//Programa 9.- Programa sobre convertir un numero entero a su forma binaria
using System;
class Program
{
    static string ConvertirABinario(int n)
    {
        if (n == 0)
            return "0";
        if (n == 1)
            return "1";

        return ProcesarCociente(n);
    }

    static string ProcesarCociente(int n)
    {
        int cociente = n / 2;
        int residuo = n % 2;

        return ConvertirABinario(cociente) + residuo;
    }

    static void Main()
    {
        Console.Write("Ingrese un número entero no negativo: ");

        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            Console.WriteLine($"{numero} en binario es: {ConvertirABinario(numero)}");
        }
        else
        {
            Console.WriteLine("Error: Ingresa un número entero no negativo.");
        }
    }
}
