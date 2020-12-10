using System;

namespace SuperContador
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            int contador = 1;
            do
            {
                Console.WriteLine("\n ----- MENU ------ ");
                Console.WriteLine(" ================= ");
                Console.WriteLine(" | [1] DE 1 A 10 | ");
                Console.WriteLine(" | [2] DE 10 A 1 | ");
                Console.WriteLine(" | [3] SAIR      | ");
                Console.WriteLine(" ================= ");

              

                escolha = Convert.ToInt32(Console.ReadLine());


                if (escolha == 1)
                {

                    while (contador <= 10)
                    {
                        Console.Write(contador + "... ");
                        contador++;
                    }

                }

                if (escolha == 2)
                {
                    contador = 10;
                    while (contador >= 1)
                    {
                        Console.Write(contador + "... ");
                        contador--;
                    }

                }

            }
            while (escolha != 3);

        }
    }
}
