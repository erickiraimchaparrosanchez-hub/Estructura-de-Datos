//Programa 7.- Este programa trata sobre clasificar un numero entero positivo si es par o impar
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un numero entero no negativo: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero) && numero >= 0)
        {
            if (numero % 2 == 0)
                Console.WriteLine($"{numero} es par.");
            else
                Console.WriteLine($"{numero} es impar.");
        }
        else
        {
            Console.WriteLine("Error: debes ingresar un numero entero no negativo.");
        }
    }
}
