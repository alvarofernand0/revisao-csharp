using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        int var1 = int.Parse(Console.ReadLine());
        int var2 = int.Parse(Console.ReadLine());

        int prod = var1 * var2;

        Console.WriteLine($"PROD = {prod}");
    }

}