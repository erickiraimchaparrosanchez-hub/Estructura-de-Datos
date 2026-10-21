//Programa 3.- Programa sobre la suma de enteros del 1 al n
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un numero entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los números del 1 al {n} es: {suma}");
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número entero positivo válido.");
        }
    }
}
