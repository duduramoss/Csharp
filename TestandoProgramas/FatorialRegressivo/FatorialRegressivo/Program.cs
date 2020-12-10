using System;

namespace FatorialRegressivo
{
    class Program
    {
        static void Main(string[] args)
        {

            int c = 0;
            int n = 0;
            int f = 0;
            try
            {
                Console.Write(" Digite o numero que vc quer calcular o fatorial: ");
                n = Convert.ToInt32(Console.ReadLine());
                c = n;
                f = 1;
                do
                {
                    Console.WriteLine(n + " x " + c);
                    f = f * c;
                    c -= 1;
                            
                }
                while (c >= 1);
                Console.WriteLine(" O valor do fatorial de " + n + " e igual a " + f);


            }
            catch
            {
                Console.WriteLine(" Digite um numero de valor inteiro");
            }
        }
    }
}
