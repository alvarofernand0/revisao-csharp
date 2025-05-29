using System;

namespace classe_musica
{
    public class Musica
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }

        public Musica(string titulo, string artista, int duracao)
        {
            Titulo = titulo;
            Artista = artista;
            Duracao = duracao;
        }

        public void MostrarInformacoes()
        { 
            System.Console.WriteLine($"Titulo: {Titulo}, Artista: {Artista}, {Duracao}s");
        }
    }
}