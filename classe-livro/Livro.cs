
using System;
using System.Security.Cryptography;

namespace classe_livro
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public Livro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public void Sobrescrita()
        {
            System.Console.WriteLine($"Titulo:{Titulo}, Autor: {Autor}, Páginas: {Paginas}");
        }
    }
}