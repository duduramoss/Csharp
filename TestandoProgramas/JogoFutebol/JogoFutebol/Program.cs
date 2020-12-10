using System;

namespace JogoFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" O jogo de hoje é entre ----Barcelona VS Real Madrid----");

            int[] gols = new int[2];

            Console.WriteLine(" Quantos gols do Barcelona?");
            gols[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Quantos gols do Real Madrid?");
            gols[1] = Convert.ToInt32(Console.ReadLine());
            int diferenca = Math.Abs (gols[0] - gols[1]);

            if (gols[0] == gols[1])
            {
                Console.WriteLine(" ----Status: Empate----");
                Console.WriteLine(" Diferença de gols: 0 ");
            }

            else if (diferenca < 5)
            {
                Console.WriteLine(" ----Status: Partida Normal----");
                Console.WriteLine(" Diferença de gols:  " +  (diferenca));
            }

            if (diferenca >= 5)
            {
                Console.WriteLine(" ----Status: Goleada----");
                Console.WriteLine(" Diferença de gols:  " + diferenca);
            }

        }
    }
}
