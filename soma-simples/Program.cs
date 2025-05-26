class Program
{
    static void Main()
    {
        Console.Write("Digite o 1° Número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o 2°: ");
        int b = int.Parse(Console.ReadLine());

        int X = a + b;

        Console.WriteLine($"X = {X}");

    }
}