using System;

namespace Conta2
{
    class Program
    {
        static void Main(string[] args)
        {

            int deposito = 0;

            int saque = 0;

            int transferencia = 0;

            int valorInicial = 0;

            int valorAtual = 0;

            Console.WriteLine(" Bem vindo ");
            Console.WriteLine(" Qual o seu nome? ");
            string nick = Console.ReadLine();

            Console.WriteLine(" Escolha uma opção : 1-Saldo 2-Saque 3-Transferência 4-Depósito ");
            string escolha = Console.ReadLine( );

            if (escolha == "1" )
            {
                Console.WriteLine(" Seu saldo atual é de : " + valorAtual);
            }

            else
            {
                Console.WriteLine(" Digite um valor para saque : ");
            }


        }
    }
}
