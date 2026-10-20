using System;
class Program
{
    static long Factorial(int n)
    {
        long resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("El número debe ser positivo.");
        }
        else
        {
            long resultado = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {resultado}");
        }
    }
}
