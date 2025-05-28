using System;
using classe_produto;

class Program
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        double preco = double.Parse(Console.ReadLine());

        Produto p = new Produto(nome, preco);
        p.AplicarDesconto(double.Parse(Console.ReadLine()));
    }
}