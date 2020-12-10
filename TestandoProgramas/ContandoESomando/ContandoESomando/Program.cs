using System;

namespace ContandoESomando
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int number = 0;
            int soma = 0;
            int sub = 0;
            int maior = 0;
            int menor = int.MaxValue;
            while (contador <= 10)
            {
                Console.WriteLine(" Digite o " + contador + " ° valor: ");

                number = Convert.ToInt32(Console.ReadLine());

                if (number > maior)
                {
                    maior = number;
                }


                if (number < menor)
                {
                    menor = number;
                }

                soma = soma + number;
                sub = Math.Abs(sub - number);
                contador++;
            }
            Console.WriteLine(" A soma de todos os valores é : " + soma);
            Console.WriteLine(" A subtração de todos os valores é : " + sub);
            Console.WriteLine(" O maior número é : " + maior);


            Console.WriteLine(" O menor número é : " + menor);

    











        }
    }
}
