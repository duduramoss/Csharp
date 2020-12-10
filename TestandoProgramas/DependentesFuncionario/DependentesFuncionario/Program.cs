using System;

namespace DependentesFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Vamos começar! Tecle ENTER para iniciar ou ESC para sair ");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

                Console.WriteLine(" Qual o nome do Funcionario? ");
                string nome = Console.ReadLine();
                Console.WriteLine(" Qual o salario do Funcionario?");
                decimal salario = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" Qual é a quantidade de dependentes?");
                int dependentes = Convert.ToInt32(Console.ReadLine());

                decimal novoSalario = 0;

                switch (dependentes)
                {
                    case 0:
                        novoSalario = salario + (salario * 5 / 100);
                        Console.WriteLine("salrio");
                        break;

                    case 1:
                    case 2:
                    case 3:
                        novoSalario = salario + (salario * 10 / 100);
                        Console.WriteLine(novoSalario);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        novoSalario = salario + (salario * 15 / 100);
                        Console.WriteLine(novoSalario);
                        break;

                    default:
                        novoSalario = salario + (salario * 18 / 100);
                        Console.WriteLine(novoSalario);
                        break;
                }
                Console.WriteLine(nome + " agora tem um salário de : " + novoSalario + " R$ ");
                Console.WriteLine(" Se quise sair pressione ESC ... ");
               
            }
            Console.Clear();


        }
    }
}
