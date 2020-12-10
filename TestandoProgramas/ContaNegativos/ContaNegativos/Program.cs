using System;

namespace ContaNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int c = 1;
            int totn = 0;

            // adicionei o trycatch para treinar
            try
            {
                do
                {
                    Console.WriteLine("Digite um numero: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0)
                    {
                        totn++;
                    }
                    c++;
                }
                while (!(c > 10));
                Console.WriteLine("Foram digitados " + totn + " valores negativos");
            }
         catch
            {
                Console.WriteLine(" Erro ao digitar, tente novamente");
                Console.WriteLine("Foram digitados " + totn + " valores negativos");
            }
          
            
        }
    }
}
