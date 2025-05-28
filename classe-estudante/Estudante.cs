using System;

namespace classe_estudante
{
    public class Estudante
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public List<double> Notas { get; set; }

        public Estudante(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
            Notas = new List<double>();
        }

        public void AdicionarNota(double notas)
        {
            Notas.Add(notas);
        }

        public void CalcularMedia()
        {
            if (Notas.Count == 0)
            {
                Console.WriteLine("A lista tem 0 notas!");
            }
            else
            {
                Console.WriteLine($"A média das notas é {Notas.Sum() / Notas.Count()}");
            }
        }
    }
}