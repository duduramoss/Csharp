using System;

namespace QuantosEntre0e10
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int v = 0;
            int tot010 = 0;
            int somaImp = 0;
            int somaP = 0;

            try
            {
                //para  
                for (c = 0; c < 6; c++)

                {
                    Console.WriteLine("DIGITE UM VALOR: ");
                    v = Convert.ToInt32(Console.ReadLine());
                    if (v >= 0 && v <= 10)
                    {
                        tot010++;                      
                    }
                    if (v % 2 == 1)
                    {
                        somaImp = somaImp + v;
                    }
                    else
                    {
                        somaP = somaP + v;
                    }
                }
                Console.WriteLine("AO TODO FORAM " + tot010 + " VALORES ENTRE 0 E 10");
                Console.WriteLine("NESSE INTERVALO, A SOMA DOS IMPARES FOI " + somaImp);
                Console.WriteLine("NESSE INTERVALO, A SOMA DOS PARES FOI " + somaP);
            }
            catch
            {
                Console.WriteLine(" Algo deu errado, tente novamente .");
            }

        }
    }
}
