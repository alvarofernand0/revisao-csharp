using System;
using classe_estudante;

class Program
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        string matricula = Console.ReadLine();
        double notas = double.Parse(Console.ReadLine());

        Estudante estd = new Estudante(nome, matricula);
        estd.AdicionarNota(notas);
        estd.CalcularMedia();
    }
}