using System;

namespace AptoDirigir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Departamento de Trânsito \n ");
            Console.WriteLine(" Digite seu ano de nascimento ");
            int dt = Convert.ToInt32(Console.ReadLine());
            int ano = 2020;
            Console.WriteLine(" -------------------------------");
            Console.WriteLine(" O ano atual é : " + ano);
            Console.WriteLine(" O ano do seu nascimento é : " + dt);
            Console.WriteLine(" ----------STATUS---------------");
            int idade = ano - dt;
            Console.WriteLine(" IDADE: " + idade + " ANOS");

            if (idade >= 18)
            {
                Console.WriteLine(" Você tem 1.600,00 R$ para pagar a habilitação ? ");
                int dinheiro = Convert.ToInt32(Console.ReadLine());
                if (dinheiro >= 1600)
                {
                    Console.WriteLine(" APTO A TIRAR A HABILITAÇÃO");
                }
                if (dinheiro >1500)
                {
                    Console.WriteLine(" INAPTO A TIRAR A HABILITAÇÃO");
                }
                else
                {
                    Console.WriteLine(" INAPTO A TIRAR A HABILITAÇÃO");
                }
            }

        }
    }
}
