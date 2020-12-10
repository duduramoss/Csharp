using System;

namespace NaoSei


{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pessoa = new string[10];

            int[] idade = new int[10];


            Console.WriteLine("Informe seu nome para começar");
            pessoa[0] = Console.ReadLine();
            Console.WriteLine("Olá, " + pessoa[0]);
            Console.WriteLine("Informe sua idade");
            idade[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pessoa[0] + ", você tem " + idade[0] + " anos");

            Console.WriteLine("Informe seu nome para começar");
            pessoa[1] = Console.ReadLine();
            Console.WriteLine("Olá, " + pessoa[1]);
            Console.WriteLine("Informe sua idade");
            idade[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pessoa[1] + ", você tem " + idade[1] + " anos");

            Console.WriteLine("Informe seu nome para começar");
            pessoa[2] = Console.ReadLine();
            Console.WriteLine("Olá, " + pessoa[2]);
            Console.WriteLine("Informe sua idade");
            idade[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pessoa[2] + ", você tem " + idade[2] + " anos");

            Console.WriteLine("Informe seu nome para começar");
            pessoa[3] = Console.ReadLine();
            Console.WriteLine("Olá, " + pessoa[3]);
            Console.WriteLine("Informe sua idade");
            idade[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pessoa[3] + ", você tem " + idade[3] + " anos");














            /* Console.WriteLine(pessoa[1] + ", Quantos anos você tem ?");
             Console.ReadLine();


             var idade = Console.ReadLine();
             Console.WriteLine("Você tem " + idade + " anos ");

             Console.WriteLine("Informe seu nome para começar");
             pessoa[2] = Console.ReadLine();

             Console.WriteLine("Informe seu nome para começar");
             pessoa[3] = Console.ReadLine();

             Console.WriteLine(pessoa[1] + ", Quantos anos você tem ?");
             Console.ReadLine(); */







        }
    }
}
