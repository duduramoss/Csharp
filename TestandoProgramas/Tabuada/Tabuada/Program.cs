using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int n = 0;
            int r = 0;

            cont = 1;
            Console.WriteLine(" Quer ver a tabuada de qual número?");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                r = n * cont;
                Console.WriteLine(n + " x " + cont + " = " + r);
                cont++;
            }
            while (cont <= 10);


           //   while (!(cont > 10));
           // pode-se utilizar a forma acima, com o operador de negação (!)

        }
    }
}
