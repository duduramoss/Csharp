using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {

            int Numero = 0;
            int contador = 1;
            int contadorPrimo = 0;


            Console.Write(" Digite um para começar: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(contador);
                if (Numero % contador == 0)
                {
                    contadorPrimo++;
                }
                contador++;
            }
            while (contador <= Numero);
            Console.WriteLine(" Ao todo existem " + contadorPrimo + " valores divisiveis");
            if (contadorPrimo <= 2)
            {
                Console.WriteLine( Numero + " Esse é um numero primo!");
            }

            else
            {
                Console.WriteLine( Numero + " Não é um numero primo");
            }




            //  if (NumeroPrimo > contador)
            //  {
            //      Console.WriteLine(Numero + " Esse é um numero primo!");
            //  }


        }
    }
}
