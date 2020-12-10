using System;

namespace ConsultandoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] alunos = new string [5] ;
            foreach (var aluno in alunos)
            {
                Console.WriteLine(" Qual é o meu nome ");
                alunos[0] = Convert.ToString(Console.ReadLine());

                Console.WriteLine(" Em que ano estamos ?");
                var anoAtual = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Qual o meu ano de nascimento ?");
                var anoNascimento = Convert.ToInt32(Console.ReadLine());

                var idade = anoAtual - anoNascimento;

                Console.WriteLine(" Sua idade é : " + idade + " anos !");

                Console.WriteLine(" Uma dúvida, eu sou maior de idade ?");

                if (idade >= 18)
                {
                    Console.WriteLine( alunos [0] + " , sim, você já é maior de idade! ");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine( alunos [0] + " , não, você é menor de idade! ");
                    Console.WriteLine("\n");
                }
            }


        }
    }
}
