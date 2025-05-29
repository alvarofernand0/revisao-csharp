using System;
using classe_circulo;

class Program
{
    static void Main(string[] args)
    {
        Circulo c1 = new Circulo(30.0);
        c1.CalcularArea();
        c1.CalcularCircunferencia();
    }
}