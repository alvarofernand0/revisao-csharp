using System;

namespace classe_carro
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        private bool Ligado { get; set; }

        public Carro(string modelo, string cor)
        {
            Modelo = modelo;
            Cor = cor;
        }

        public void Ligar()
        {
            Ligado = true;
            System.Console.WriteLine("Carro ligado!");
        }

        public void Desligar()
        {
            Ligado = false;
            System.Console.WriteLine("Carro desligado!");
        }

        public void MostrarStatus()
        {
            System.Console.WriteLine($"Carro Modelo: {Modelo}, da Cor {Cor}");

            if (Ligado == false)
            {
                Desligar();
            }
            else
            {
                Ligar();
            }
        }
    }
}