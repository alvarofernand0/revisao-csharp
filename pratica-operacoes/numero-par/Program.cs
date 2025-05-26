using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string opcao = Console.ReadLine();
        if (int.TryParse(opcao, out int num))
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} É Par");
            }
            else
            {
                Console.WriteLine($"{num} Não é Par");
            }
        }
        else
        {
            Console.WriteLine("Digite um Número!");
        }
    }
}