using System;

namespace SeletorPessoas
{
    class Program
    {
        static void Main(string[] args)
        {

            string sexo = " ";
            string cor = " ";
            int idade = 0;
            int sexoM = 0;
            int sexoF = 0;
            int idadeM = 0;
            string resposta = "";
            try
            {
                do
                {
                    Console.WriteLine("====================");
                    Console.WriteLine(" SELETOR DE PESSOAS");
                    Console.WriteLine("====================");

                    Console.Write("QUAL O SEXO? M OU F : ");
                    sexo = Console.ReadLine();
                    if ( sexo == "M")
                    {
                        sexoM++;
                    }
                    if (sexo == "F")
                    {
                        sexoF++;
                    }

                    Console.Write("QUAL A IDADE ? : ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    if ( idade >= 18)
                    {
                        idadeM++;
                    }

                    Console.WriteLine("QUAL A COR O CABELO? : ");
                    Console.WriteLine("====================");
                    Console.Write("[1] PRETO ");
                    Console.Write("[2] CASTANHO ");
                    Console.Write("[3] LOIRO ");
                    Console.Write("[4] RUIVO ");
                    cor = Console.ReadLine();

                    Console.WriteLine(" Quer continuar ? [S/N] ");
                    resposta = Console.ReadLine();
                    Console.Clear();
                }
                while (resposta != "N");
            }
            catch
            {
                Console.WriteLine(" Tente novamente");
            }
            Console.WriteLine(" Resultado Final");
            Console.WriteLine("Total de pessoas com mais de 18 anos : " + idadeM );
            Console.WriteLine("Total de homens : " + sexoM );
            Console.WriteLine("Total de mulheres : " + sexoF );

        }
    }
}
