using System;

namespace ArrumouQuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            string quarto = "";
            /* Repita */
            do
            {
           Console.WriteLine(" Você já arrumou o quarto meu filho ?");
           quarto = Console.ReadLine();
               if ( quarto == "Não")
               {
                   Console.WriteLine(" VOCÊ ESTÁ DE CASTIGO");
               }
              
           }
           
           // OPERADOR DE COMPARAÇÃO == NÃO ESQUECER
           while (quarto == "Não");
                   Console.WriteLine(" VOCÊ SAIU DO CASTIGO");



          /* Enquanto */
            while (quarto == "não")
            {
                Console.WriteLine(" VOCÊ ESTÁ DE CASTIGO");
            }
            Console.WriteLine(" VOCÊ SAIU DO CASTIGO");

        }
    }
}
