using System;

namespace AlunosMediaClassificacao
{
    class Medias
    {
        public void ImprimirClassificacaoA()
        {
            
                Console.WriteLine(" O aproveitamento do aluno foi: A");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] notas = new int[10];

            Console.WriteLine(" ---- ESCOLA ESTADUAL DE LEAGUE OF LEGENDS FNATIC ----\n");
            Console.Write(" Digite a primeira nota:  ");
            notas[0] = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("------------------------------");
            Console.Write(" Digite a segunda nota:  ");
            notas[1] = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("------------------------------");
            notas[2] = (notas[1] + notas[0]) / 2;
            
            Console.WriteLine(" A média é: " + notas[2]);
            int media = 0;
             notas[2] =  media;
           
            if ( media >= 9.0)
            {
                Console.WriteLine("");
            }
            if (media <= 8.9 && media > 8.0)
            {
                Console.WriteLine(" O aproveitamento do aluno foi: B");
            }
            if (media <= 7.9 && media > 7.0)
            {
                Console.WriteLine(" O aproveitamento do aluno foi: C");
            }
            if (media <= 6.9 && media >= 5.0)
            {
                Console.WriteLine(" O aproveitamento do aluno foi: D");
            }
            if (media < 4.9)
            {
                Console.WriteLine(" O aproveitamento do aluno foi: F");
            }
        }
    }
}
