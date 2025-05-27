using System;
using classe_livro;

class Program
{
    static void Main(string[] args)
    {
        string titulo = Console.ReadLine();
        string autor = Console.ReadLine();
        int paginas = int.Parse(Console.ReadLine());

        Livro livro = new Livro(titulo, autor, paginas);
        livro.Sobrescrita();
    }
}