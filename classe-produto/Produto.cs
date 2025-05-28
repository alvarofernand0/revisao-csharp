using System;

namespace classe_produto
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void AplicarDesconto(double percentual)
        {
            System.Console.WriteLine($"O novo preço é {Preco - (Preco *(percentual / 100))}");
        }
    }
}