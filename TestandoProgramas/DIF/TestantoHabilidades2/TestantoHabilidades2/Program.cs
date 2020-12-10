using System;

namespace TestantoHabilidades2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] integrantes = new string[5];
            string[] peso = new string[5];
            string[] altura = new string[5];


            Console.WriteLine("Digite o nome dos 5 Integrantes ");
            integrantes[0] = Console.ReadLine();
            integrantes[1] = Console.ReadLine();
            integrantes[2] = Console.ReadLine();
            integrantes[3] = Console.ReadLine();
            integrantes[4] = Console.ReadLine();


            Console.WriteLine("Digite o peso dos 5 Integrantes ");
            peso[0] = Convert.ToInt32= Console.ReadLine();
            peso[1] = Convert.ToInt32; Console.ReadLine();  
            peso[2] = Convert.ToInt32; Console.ReadLine();
            peso[3] = Convert.ToInt32; Console.ReadLine();
            peso[4] = Convert.ToInt32; Console.ReadLine();

            Console.WriteLine("Digite a altura dos 5 Integrantes ");
            altura[0] =Convert.ToInt32; Console.ReadLine();
            altura[1] =Convert.ToInt32; Console.ReadLine();
            altura[2] =Convert.ToInt32; Console.ReadLine();
            altura[3] =Convert.ToInt32; Console.ReadLine();
            altura[4] =Convert.ToInt32; Console.ReadLine();


            var alturaTotal = altura[0] + altura[1] + altura[2] + altura[3] + altura[4] ;
            var pesoTotal = peso[0] + peso[1] + peso[2] + peso[3] + peso[4];

            var media = alturaTotal / altura;
            Console.WriteLine(" A media é " + media);







        }
    }
}
