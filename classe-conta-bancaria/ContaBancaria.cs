using System;

namespace classe_conta_bancaria
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        private double Saldo { get; set; }

        public ContaBancaria(string nConta, string nome, double saldo)
        {
            NumeroConta = nConta;
            NomeTitular = nome;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (Saldo < valor)
            {
                System.Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque concluido");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"O Saldo atual é: {Saldo}");
        }
    }
}