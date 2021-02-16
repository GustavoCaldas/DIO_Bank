using System;
using DIO_Bank.Classes;

namespace DIO_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(Enum.TipoConta.PessoaFisica, 100, 200, "Gustavo");
            

            Console.WriteLine("Hello World!");
        }
    }
}
