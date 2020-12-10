using System;

namespace AprovadoReprovado
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int media = (n1 + n2) / 2;
            Console.WriteLine(media + " , essa foi a média do aluno");
            if (media > 7)
            {
                Console.WriteLine(" Aluno Aprovado");
            }
            if (media >= 5 && media <= 7)
            {
                Console.WriteLine(" ----Aluno em recuperação----");
            }
            else
            {
                Console.WriteLine(" Aluno Reprovado");
            }


        }
    }
}
