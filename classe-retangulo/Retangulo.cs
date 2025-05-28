using System;

namespace classe_retangulo
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public void CalcularArea()
        {
            System.Console.WriteLine($"A área é {Largura * Altura}");
        }

        public void CalcularPerimetro()
        {
            System.Console.WriteLine($"O perímetro é {2 * (Largura + Altura)}");
        }
    }
}