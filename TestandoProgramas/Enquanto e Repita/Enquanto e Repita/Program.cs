using System;

namespace Enquanto_e_Repita
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            // Enquanto
            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //Repita
            int contadore = 0;
            do
            {
                Console.WriteLine(contadore);
                contadore++;
            }
            while (contadore < 10);

            //Para
            int contad = 0;
            for(contad = 1; contad <= 20; contad++)
            {
                Console.WriteLine(contad);
            }
        }
    }
}
