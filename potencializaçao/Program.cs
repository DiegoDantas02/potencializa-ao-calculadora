using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a base: ");
        double baseNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        double resultado = Math.Pow(baseNum, expoente);

        Console.WriteLine("O resultado de " + baseNum + " elevado a " + expoente + " é igual a " + resultado);

        Console.ReadLine();
    }
}
