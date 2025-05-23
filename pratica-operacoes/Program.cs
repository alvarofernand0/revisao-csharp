using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        string opcao = Console.ReadLine();
        if (int.TryParse(opcao, out int num))
        {
            int contador = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % num == 0 && num % num == 0)
                {
                    contador++;
                    //break;
                }
            }

            if (contador == 2)
            {
                Console.WriteLine($"{num} É primo!");
            }
            else
            {
                Console.WriteLine($"{num} Não é primo!");
            }
        }
        
       




    }
}