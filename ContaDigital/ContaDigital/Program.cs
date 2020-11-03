using System;
using System.Linq;

namespace ContaDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito = 0;

            double saque = 0;
            var opcao = "";

            double[] operacoesConta = new double[20];
            operacoesConta [0] = - 100.00;
            operacoesConta [1] = + 1000.00;
            operacoesConta [2] = - 400.00;
          

            Console.WriteLine("Bem vindo  !\n" + "Digite seu nome para começar");
            string[] nomes = new string[10];
            Console.ReadLine();

            do
            {

                Console.WriteLine(" Escolha uma opção:\n" + "1:Consultar Saldo| 2:Depositar | 3:Consultar Extrato| 4:Realizar Saque| 5:Sair");

                opcao = Console.ReadLine();
                switch (opcao)

                {
                    case "1":

                        double saldoconta = CalcularSaldo(operacoesConta);

                        Console.WriteLine(nomes[0] + "Seu saldo é de: " + saldoconta + ",00 R$");
                        break;

                    case "2":
                        Console.WriteLine(" Digite um valor para depósito: ");
                        deposito = Convert.ToDouble(Console.ReadLine());

                        operacoesConta = operacoesConta.Append(deposito).ToArray();

                        double saldo1 = CalcularSaldo(operacoesConta);

                        for (int i = 0; i < operacoesConta.Length; i++)
                        {
                            saldo1 = operacoesConta[i] + saldo1;
                        }
                        
                        break;

                    case "3":
                        Console.WriteLine(DateTime.Now);
                         double saldo2 = CalcularSaldo(operacoesConta);

                        for (int i = 0; i < operacoesConta.Length; i++)
                        {
                            if (operacoesConta[i] != 0)
                            {
                                Console.WriteLine(operacoesConta[i]);
                                
                            }
                        }

                        break;

                    case "4":
                        Console.WriteLine(" Digite um valor para Saque ");
                        saque = Convert.ToDouble(Console.ReadLine());

                        operacoesConta = operacoesConta.Append(saque *-1).ToArray();

                        double saldo3 = CalcularSaldo(operacoesConta);
                        
                        Console.WriteLine("Seu saldo é de: " + (saldo3) + ",00 R$");
                        Console.WriteLine("Saque realizado");
                        break;

                    default:
                        Console.WriteLine(" Dados inválidos ");
                        break;

                }

                Console.WriteLine("Enter para reiniciar...");
                Console.ReadLine();
                Console.Clear();
            }
            while (opcao != "5");

        }
        public static double CalcularSaldo(double[] extrato)
        {
            double saldo = 0;

            for (int i = 0; i < extrato.Length; i++)
            {
                saldo = extrato[i] + saldo;
            }

            return saldo;
        }
    }
}





