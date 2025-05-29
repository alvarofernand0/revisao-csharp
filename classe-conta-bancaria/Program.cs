using System;
using classe_conta_bancaria;

class Program
{
    static void Main(string[] args)
    {
        string nConta = Console.ReadLine();
        string nome = Console.ReadLine();
        double saldo; // = double.Parse(Console.ReadLine());
        double valor; //= double.Parse(Console.ReadLine());

        ContaBancaria conta1 = new ContaBancaria(nConta, nome, 550);

        conta1.ConsultarSaldo();
        conta1.Sacar(150);
        conta1.ConsultarSaldo();
        conta1.Depositar(50);
        conta1.ConsultarSaldo();
    }
}