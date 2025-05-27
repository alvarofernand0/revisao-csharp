using System;
using classe_carro;

class Program
{
    static void Main(string[] args)
    {
        string modelo = Console.ReadLine();
        string cor = Console.ReadLine();
        bool ligado;

        Carro c1 = new Carro(modelo, cor, ligado);
        c1.MostrarStatus();
    }
}