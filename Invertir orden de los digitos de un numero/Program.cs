using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un numero entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            int numeroInvertido = InvertirNumero(numero);
            Console.WriteLine($"El número invertido es: {numeroInvertido}");
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número entero positivo válido.");
        }
    }
    public static int InvertirNumero(int n)
    {
        return InvertirRecursivo(n, 0);
    }
    private static int InvertirRecursivo(int n, int acumulado)
    {
        if (n == 0)
        {
            return acumulado;
        }

        int ultimoDigito = n % 10;
        int nuevoAcumulado = (acumulado * 10) + ultimoDigito;
        return InvertirRecursivo(n / 10, nuevoAcumulado);
    }
}
