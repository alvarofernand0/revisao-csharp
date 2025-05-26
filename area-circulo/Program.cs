using System;

class Program
{
    static void Main()
    {
        double raio1 = double.Parse(Console.ReadLine());
        double n = 3.14159;

        double raio = raio1 * raio1;

        double area = raio * n;
        Console.WriteLine($"A={area:f4}");
    }
}
