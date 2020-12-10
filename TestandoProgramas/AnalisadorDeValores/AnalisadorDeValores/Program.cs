using System;

namespace AnalisadorDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int soma = 0;


            int digitar = 0;

            while (digitar < 6)
            {
                Console.Write("Digite o " + digitar + "° valor : ");
                digitar++;
                valor = Convert.ToInt32(Console.ReadLine());
            }
           

        }
    }
}
