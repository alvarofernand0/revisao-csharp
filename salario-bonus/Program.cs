using System;

class Program
{
    static void Main()
    {
        string nomeVendedor = Console.ReadLine();
        double salarioFixo = double.Parse(Console.ReadLine());
        double totalVendas = double.Parse(Console.ReadLine());

        double total = salarioFixo + (totalVendas * 0.15);

        Console.WriteLine($"TOTAL = R$ {total:f2}");
    }
}