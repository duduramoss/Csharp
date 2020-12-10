using System;

namespace ReajusteDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int salario = 0;
            int salarionovo = 0;

            Console.WriteLine("Qual o seu salario atual ?");
            salario = Convert.ToInt32 (Console.ReadLine());
            salarionovo = salario * 50 / 100;
          
            if (salario > 1000)
            {
                Console.WriteLine("Seu salário não teve alterações");
                
            }
            else
            {
                Console.WriteLine("Você teve um reajuste de salário!");
                Console.WriteLine("Seu salário aumentou em " + salarionovo);
                Console.WriteLine("Seu novo salário é de " + (salario + salarionovo));
                
            }


        }
    }
}
