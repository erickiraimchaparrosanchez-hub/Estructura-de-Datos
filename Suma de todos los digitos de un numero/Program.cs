//Programa 6.- Este programa trata de sumar todos los digitos de un numero entero
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            int suma = SumarDigitos(numero);
            Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número entero positivo válido.");
        }
    }

    public static int SumarDigitos(int n)
    {

        if (n == 0)
        {
            return 0;
        }

        return (n % 10) + SumarDigitos(n / 10);
    }
}
