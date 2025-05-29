using System;
using classe_estudante;

class Program
{
    static void Main(string[] args)
    {
        // string nome = "Antonio"; //Console.ReadLine();
        // string matricula = "784934938"; //Console.ReadLine();
        // double notas = 8.5; //double.Parse(Console.ReadLine());

        Estudante estd = new Estudante("Antonio", "784934938");
        estd.AdicionarNota(8.5);
        estd.AdicionarNota(7.8);
        estd.AdicionarNota(7.5);
        estd.AdicionarNota(9.4);
        estd.CalcularMedia();
    }
}