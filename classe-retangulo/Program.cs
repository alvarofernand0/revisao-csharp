using System;
using classe_retangulo;

class Program
{
    static void Main(string[] args)
    {
        double largura = double.Parse(Console.ReadLine());
        double altura = double.Parse(Console.ReadLine());

        Retangulo r = new Retangulo(largura, altura);
        r.CalcularArea();
        r.CalcularPerimetro();
    }
}