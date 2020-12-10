using System;

namespace Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            // O imc é calculado por Massa/Altura² 
            // O ideal é ter o imc entre 18,5 e 25

            int massa = 0;

            do
            {

                Console.WriteLine(" Digite sua massa em KG: ");
                massa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Digite sua altura em M: ");
                decimal altura = Convert.ToDecimal(Console.ReadLine());
                decimal imc = 0;
                imc = massa / (altura * altura);
                Console.WriteLine(imc.ToString("00.00"));

                if (imc < 17)
                {
                    Console.WriteLine(" Muito abaixo do peso ");
                }
                else if (imc >= 17 && imc < 18.5M)
                {
                    Console.WriteLine(" Abaixo do peso ");
                }
                else if (imc >= 18.5M && imc < 25)
                {
                    Console.WriteLine(" Peso Ideal ");
                }
                else if (imc >= 25M && imc < 30)
                {
                    Console.WriteLine(" Sobrepeso ");
                }
                else if (imc >= 30 && imc < 35)
                {
                    Console.WriteLine(" Obsidade ");
                }
                else if (imc >= 35 && imc < 40)
                {
                    Console.WriteLine(" Obsidade ");
                }
                else
                {
                    Console.WriteLine(" Obsidade Morbida ");
                }
            }


            while (massa > 0);

            // Console.Clear(); serve para apagar o código


        }
    }
}
