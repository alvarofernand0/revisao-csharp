using System;
using System.Net.Http.Headers;
using classe_musica;

class Program
{
    static void Main(string[] args)
    {
        Musica musica = new Musica("Mistérios da Meia Noite", "Zé Ramalho", 180);
        musica.MostrarInformacoes();
    }
}