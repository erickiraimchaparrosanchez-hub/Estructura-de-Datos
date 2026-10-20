using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculo de potencia (recursivo) ===");

        Console.Write("Ingrese la base (numero entero): ");
        int baseNumero = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el exponente (entero no negativo): ");
        int exponente = int.Parse(Console.ReadLine());

        if (exponente < 0)
        {
            Console.WriteLine("Error: El exponente debe ser un entero no negativo.");
        }
        else
        {
            long resultado = CalcularPotencia(baseNumero, exponente);
            Console.WriteLine($"{baseNumero}^{exponente} = {resultado}");
        }
    }
    static long CalcularPotencia(int b, int e)
    {
        if (e == 0)
        {
            return 1;
        }
        return b *CalcularPotencia(b, e - 1);
    }
}
