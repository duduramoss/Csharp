using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            Console.WriteLine(" Digite qualquer número ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0)
            {
                Console.WriteLine(" Esse é um número par !");
            }
            else
            {
                Console.WriteLine(" Esse é um número ímpar !");
            }
        }
    }
}
