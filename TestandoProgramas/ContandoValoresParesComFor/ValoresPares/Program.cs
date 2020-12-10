using System;

namespace ValoresPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int v = 0;

            Console.WriteLine(" Digite um valor: ");
            v = Convert.ToInt32(Console.ReadLine());

            for (cont = 0; cont <= v; cont += 2)
            {
                Console.WriteLine(cont);
            }


        }
    }
}
