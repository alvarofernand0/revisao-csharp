using System;

namespace classe_cachorro
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public string Raca { get; set; }

        public Cachorro(string nome, string raca)
        {
            Nome = nome;
            Raca = raca;
        }

        public void Latir()
        {
            System.Console.WriteLine($"Nome: {Nome}, Raça: {Raca}");
            System.Console.WriteLine("Au Au!");
        }
    }
}