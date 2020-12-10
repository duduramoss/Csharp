using System;

namespace TrocarMao
{
    class Program
    {
        static void Main(string[] args)
        {
            int mao = 0;

            int contador = 0;

            do
            {
                Console.WriteLine(" Troca");
                mao++;
            }
            while (mao <= 5);
            Console.WriteLine(" Terminei de trocar a mao");



            contador = 0;
            while (contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.WriteLine(" Terminei de contar");

            contador = 0;
            while (contador < 50)
            {
                Console.WriteLine(contador);
                contador += 5;
            }
            Console.WriteLine(" Terminei de contar");


            contador = 10;
            while (contador >= 0)
            { 
                Console.WriteLine(contador);
                contador--;
            }
            Console.WriteLine(" Terminei de contar");

            //  int teste = 0;
            //  Console.WriteLine($"Teste 1 {++teste}");
            //
            //  teste = 0;
            //  Console.WriteLine($"Teste 2 {teste++}");
            //
            //  Console.WriteLine($"Teste 3 {teste}");
            // Um teste q o Bruno me ensinou onde a ordem de incrementação influencia no codigo, o teste 1 retorna o numero 1, pois o compilador entende que o 
            // ++ antes necessita ser feito com prioridade.


        }



    }
}
