using System;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

namespace classe_circulo
{
    public class Circulo
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public void CalcularArea()
        {
            double Pi = Math.PI;
            double Area;
            Area = Pi * (Raio * Raio);
            System.Console.WriteLine($"A área do Circulo é: {Area:f2}");
        }

        public void CalcularCircunferencia()
        {
            double circunferencia;
            circunferencia = 2 * Math.PI * Raio;
            System.Console.WriteLine($"A circunferência é: {circunferencia:f2}");
        }
    }
}