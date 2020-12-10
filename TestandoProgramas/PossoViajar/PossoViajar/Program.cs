using System;

namespace PossoViajar
{
    class Lugares
    {
        public string CityNome;
    }
    class Hoteis
    {
        public string HotelNome;
    }
    class Pessoa
    {
        public string Dados;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lugares city = new Lugares();
            city.CityNome = "Buenos Aires";
            Lugares city2 = new Lugares();
            city2.CityNome = "Londres";
            Lugares city3 = new Lugares();
            city3.CityNome = "Moscow";

            Hoteis hotel = new Hoteis();
            hotel.HotelNome = "ÍBIS";
            Hoteis hotel2 = new Hoteis();
            hotel2.HotelNome = "DAN INN";

            Pessoa nome = new Pessoa();
            nome.Dados = " ";
            Pessoa telefone = new Pessoa();
            telefone.Dados = " ";
            Pessoa doc = new Pessoa();
            doc.Dados = " ";

            string opcao = " ";

            Console.WriteLine(" ----- Bem vindo (a) à plataforma de viagens TRAVEL HORIZON ----- \n");

            Console.WriteLine(" Para aonde você deseja viajar?");

            Console.WriteLine(" |-" + city.CityNome);
            Console.WriteLine(" |-" + city2.CityNome);
            Console.WriteLine(" |-" + city3.CityNome);
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "Buenos Aires":
                   
                    Console.WriteLine(" Muito bem!\n Para " + city.CityNome + ", temos um voô privelegiado e com várias opções de hóteis 5 ou 4 estrelas para a sua hospedagem.");

                    Console.WriteLine(" Deseja a hospedagem de 5 ou 4 estrelas? ");
                    
                   int hospedagem = Convert.ToInt32(Console.ReadLine());

                    if (hospedagem >= 5)
                    {
                        Console.WriteLine(" Ótima escolha!\n Nossa hospedagem 5 estrelas é em parceria com o hotel " + hotel.HotelNome + "! ");
                        Console.WriteLine(" O valor para a viagem de " + city.CityNome + " com a hospedagem 5 Estrelas do Hotel " + hotel.HotelNome + " é de 4000 R$. \n Informe quanto você tem em dinheiro:  ");

                        int resposta = Convert.ToInt32(Console.ReadLine());

                        if (resposta >= 4000)
                        {
                            Console.WriteLine(" Uhul! Partiu " + city.CityNome + "!");

                            Console.WriteLine(" Vamos realizar sua reserva! \n Preencha os dados abaixo.\n");
                            Console.Write(" Nome: ");
                            nome.Dados = Console.ReadLine();

                            Console.Write(" Telefone: ");
                            telefone.Dados = Console.ReadLine();

                            Console.Write(" RG: ");
                            doc.Dados = Console.ReadLine();

                            Console.WriteLine(" Sua reserva foi " + city.CityNome + " efetuada com sucesso! Confira os dados por favor:");
                            Console.WriteLine("|" + nome.Dados + " \n|" + telefone.Dados + " \n|" + doc.Dados);
                        }

                        else
                        {
                            Console.WriteLine(" #chateado");
                        }

                    }

                    else
                    {
                        Console.WriteLine(" Ótima escolha!\n Nossa hospedagem 4 estrelas é em parceria com o hotel " + hotel2.HotelNome + ".");
                        Console.WriteLine(" O valor para a viagem de" + city.CityNome + "com a hospedagem 4 Estrelas do Hotel " + hotel2.HotelNome + " é de 3000 R$. \n Informe quanto você tem em dinheiro:  ");

                        int resposta = Convert.ToInt32(Console.ReadLine());

                        if (resposta >= 3000)
                        {
                            Console.WriteLine(" Uhul! Partiu" + city.CityNome + "!");
                            Console.WriteLine(" Vamos realizar sua reserva! \n Preencha os dados abaixo.\n");
                            Console.Write(" Nome: ");
                            nome.Dados = Console.ReadLine();

                            Console.Write(" Telefone: ");
                            telefone.Dados = Console.ReadLine();

                            Console.Write(" RG: ");
                            doc.Dados = Console.ReadLine();

                            Console.WriteLine(" Sua reserva para " + city.CityNome + " foi efetuada com sucesso! Confira os dados por favor:");
                            Console.WriteLine("|" + nome.Dados + " \n|" + telefone.Dados + " \n|" + doc.Dados);
                        }
                        else
                        {
                            Console.WriteLine(" #chateado");
                        }
                    }

                    break;

                case "Londres":
                    Console.WriteLine(" Muito bem!\n Para " + city.CityNome + ", temos um voô privelegiado e com várias opções de hóteis 5 ou 4 estrelas para a sua hospedagem.");

                    Console.WriteLine(" Deseja a hospedagem de 5 ou 4 estrelas? ");

                    hospedagem = Convert.ToInt32(Console.ReadLine());

                    if (hospedagem >= 5)
                    {
                       
                        Console.WriteLine(" Ótima escolha!\n Nossa hospedagem 5 estrelas é em parceria com o hotel " + hotel.HotelNome + "! ");
                        Console.WriteLine(" O valor para a viagem de" + city2.CityNome + " com a hospedagem 5 Estrelas do Hotel " + hotel.HotelNome + " é de 4000 R$. \n Informe quanto você tem em dinheiro: ");
                        int resposta = Convert.ToInt32(Console.ReadLine());

                        if (resposta > 4000)
                        {
                            Console.WriteLine(" Uhul! Partiu " + city2.CityNome + "!");
                            Console.WriteLine(" Vamos realizar sua reserva! \n Preencha os dados abaixo.\n");
                            Console.Write(" Nome: ");
                            nome.Dados = Console.ReadLine();

                            Console.Write(" Telefone: ");
                            telefone.Dados = Console.ReadLine();

                            Console.Write(" RG: ");
                            doc.Dados = Console.ReadLine();

                            Console.WriteLine(" Sua reserva para  " + city2.CityNome + "foi efetuada com sucesso! Confira os dados por favor:");
                            Console.WriteLine("|" + nome.Dados + " \n|" + telefone.Dados + " \n|" + doc.Dados);
                        }

                        else
                        {
                            Console.WriteLine(" #chateado");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Ótima escolha!\n Nossa hospedagem 4 estrelas é em parceria com o hotel " + hotel2.HotelNome + ".");
                        Console.WriteLine(" O valor para a viagem de" + city2.CityNome + "com a hospedagem 4 Estrelas" + hotel2.HotelNome + " é de 3000 R$. \n Informe quanto você tem. ");
                        int resposta = Convert.ToInt32(Console.ReadLine());
                        if (resposta > 3000)
                        {
                            Console.WriteLine(" Uhul! Partiu" + city2.CityNome + "!");
                            Console.WriteLine(" Vamos realizar sua reserva! \n Preencha os dados abaixo.\n");
                            Console.Write(" Nome: ");
                            nome.Dados = Console.ReadLine();

                            Console.Write(" Telefone: ");
                            telefone.Dados = Console.ReadLine();

                            Console.Write(" RG: ");
                            doc.Dados = Console.ReadLine();

                            Console.WriteLine(" Sua reserva para  " + city2.CityNome + "foi efetuada com sucesso! Confira os dados por favor:");
                            Console.WriteLine("|" + nome.Dados + " \n|" + telefone.Dados + " \n|" + doc.Dados);
                        }
                        else
                        {
                            Console.WriteLine(" #chateado");
                        }       
             

                    }

                    break;

                case "Moscow":
                    Console.WriteLine(" Muito bem!\n Para Moscow, temos um voô privelegiado e com várias opções de hóteis 5 ou 4 estrelas para a sua hospedagem.");

                    Console.WriteLine(" Deseja a hospedagem de 5 ou 4 estrelas? ");
                    hospedagem = Convert.ToInt32(Console.ReadLine());

                    if (hospedagem >= 5)
                    {

                        Console.WriteLine(" Ótima escolha!\n Nossa hospedagem 5 estrelas é em parceria com o hotel " + hotel.HotelNome + "! ");
                        Console.WriteLine(" O valor para a viagem de " + city3.CityNome + " com a hospedagem 5 Estrelas do Hotel " + hotel.HotelNome + " é de 4000 R$. \n Informe quanto você tem em dinheiro: ");
                        int resposta = Convert.ToInt32(Console.ReadLine());

                        if (resposta > 4000)
                        {
                            Console.WriteLine(" Uhul! Partiu " + city3.CityNome + "!");
                            Console.WriteLine(" Vamos realizar sua reserva! \n Preencha os dados abaixo.\n");
                            Console.Write(" Nome: ");
                            nome.Dados = Console.ReadLine();

                            Console.Write(" Telefone: ");
                            telefone.Dados = Console.ReadLine();

                            Console.Write(" RG: ");
                            doc.Dados = Console.ReadLine();

                            Console.WriteLine(" Sua reserva para  " + city3.CityNome + " foi efetuada com sucesso! Confira os dados por favor:");
                            Console.WriteLine("|" + nome.Dados + " \n|" + telefone.Dados + " \n|" + doc.Dados);
                        }

                        else
                        {
                            Console.WriteLine(" #chateado");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Ótima escolha!\n Nossa hospedagem 4 estrelas é em parceria com o hotel " + hotel2.HotelNome + ".");
                        Console.WriteLine(" O valor para a viagem de " + city3.CityNome + " com a hospedagem 4 Estrelas do Hotel " + hotel2.HotelNome + " é de 3000 R$. \n Informe quanto você tem em dinheiro:  ");

                        int resposta = Convert.ToInt32(Console.ReadLine());

                        if (resposta >= 3000)
                        {
                            Console.WriteLine(" Uhul! Partiu" + city3.CityNome + "!");
                            Console.WriteLine(" Vamos realizar sua reserva! \n Preencha os dados abaixo.\n");
                            Console.Write(" Nome: ");
                            nome.Dados = Console.ReadLine();

                            Console.Write(" Telefone: ");
                            telefone.Dados = Console.ReadLine();

                            Console.Write(" RG: ");
                            doc.Dados = Console.ReadLine();

                            Console.WriteLine(" Sua reserva para " + city3.CityNome + " foi efetuada com sucesso! Confira os dados por favor:");
                            Console.WriteLine("|" + nome.Dados + " \n|" + telefone.Dados + " \n|" + doc.Dados);
                        }
                        else
                        {
                            Console.WriteLine(" #chateado");
                        }
                    }

                    break;

                default:
                    Console.WriteLine(" Tente Novamente");
                    break;
            }




        }
    }
}
