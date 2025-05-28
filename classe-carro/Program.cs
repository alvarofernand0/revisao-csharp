using System;
using classe_carro;

class Program
{
    static void Main(string[] args)
    {
        string modelo = Console.ReadLine();
        string cor = Console.ReadLine();
        bool ligado;

        Carro c1 = new Carro(modelo, cor);
        c1.MostrarStatus();
        c1.Ligar();
        c1.Desligar();
    }
}