using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        int num2 = int.Parse(Console.ReadLine());

        // Menu
        Console.WriteLine("===== MENU DE OPERAÇÕES =====\n");
        Console.WriteLine("1 - + Somar");
        Console.WriteLine("2 - - Subtrair");
        Console.WriteLine("3 - x Multiplicar");
        Console.WriteLine("4 - ÷ Dividir\n");

        Console.WriteLine("Escolha uma das operações...");
        int opcao = int.Parse(Console.ReadLine());
        int resultado;

        switch (opcao)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"A soma é: {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"A subtração é: {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"A multiplicação é: {resultado}");
                break;
            case 4:
                if (num1 % num2 != 0)
                {
                    Console.WriteLine("A divisão não é exata!");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"A divisão é {resultado}");
                }
                break;
            default:
                Console.WriteLine("Esta não é uma opção válida!");
                break;
        }
    }
}