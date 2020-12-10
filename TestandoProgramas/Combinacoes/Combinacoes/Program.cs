using System;

namespace Combinacoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int c1 = 0;
            int c2 = 0;
            int resultado = 0;

            for (c1 = 1; c1 <= 4; c1++)
            {

                for (c2 = 1; c2 <= 4; c2++)
                { 
                    resultado = c1 + c2;
                    Console.Write(c1 + " & " + c2 + " = " + resultado + "\n");
                   
                }


            }


        }
    }
}
