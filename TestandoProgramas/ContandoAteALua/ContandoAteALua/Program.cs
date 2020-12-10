using System;

namespace ContandoAteALua
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int contador = 0;
            int salto = 0;

            Console.WriteLine(" Quer contar até quanto");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Qual será o valor do salto ");
            salto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Você vai chegar ao número: " + valor + " pulando de " + salto + " em " + salto);

            while (contador <= valor)
            {
                Console.WriteLine(contador);
                contador += salto;
            }
            Console.WriteLine(" Muito bem! Chegamos no número " + valor);
        }
    }
}
