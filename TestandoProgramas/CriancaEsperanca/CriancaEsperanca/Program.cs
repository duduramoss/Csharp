using System;

namespace CriancaEsperanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("CRIANCA ESPERANCA");
            Console.WriteLine("------------------");
            Console.WriteLine(" Muito obrigado por ajudar ");
            Console.WriteLine(" [1] para doar R$10 ");
            Console.WriteLine(" [2] para doar R$20 ");
            Console.WriteLine(" [3] para doar R$30 ");
            Console.WriteLine(" [4] para doar outros valores ");
            Console.WriteLine(" [5] para CANCELAR ");
            int doacao = Convert.ToInt32(Console.ReadLine());
            int valor = 0;

            switch (doacao)
            {
                case 1:
                    valor = 10;
                    break;

                case 2:
                    valor = 20;
                    break;

                case 3:
                    valor = 30;
                    break;

                case 4:
                    Console.WriteLine(" Qual o valor da doação?");
                    valor = Convert.ToInt32(Console.ReadLine());
                    break;

                case 5:
                    Console.WriteLine(" Saindo...");
                    valor = 0;
                    break;

                default:
                    Console.WriteLine(" Tente novamente");
                    break;
            }
            Console.WriteLine(" Sua doação foi de R$" + valor + ". \n Muito obrigado pela doação!");

        }
    }
}
