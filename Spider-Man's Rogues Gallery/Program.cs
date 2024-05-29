//Spider-Man's Rogues Gallery
class Program
{
    static void Main()
    {
        //Criando as funções;
        void exibir_msg()
        {
            Console.WriteLine(@"
░██████╗██████╗░██╗██████╗░███████╗██████╗░░░░░░░███╗░░░███╗░█████╗░███╗░░██╗██╗░██████╗
██╔════╝██╔══██╗██║██╔══██╗██╔════╝██╔══██╗░░░░░░████╗░████║██╔══██╗████╗░██║╚█║██╔════╝
╚█████╗░██████╔╝██║██║░░██║█████╗░░██████╔╝█████╗██╔████╔██║███████║██╔██╗██║░╚╝╚█████╗░
░╚═══██╗██╔═══╝░██║██║░░██║██╔══╝░░██╔══██╗╚════╝██║╚██╔╝██║██╔══██║██║╚████║░░░░╚═══██╗
██████╔╝██║░░░░░██║██████╔╝███████╗██║░░██║░░░░░░██║░╚═╝░██║██║░░██║██║░╚███║░░░██████╔╝
╚═════╝░╚═╝░░░░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝░░░░░░╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░░░╚═════╝░

██████╗░░█████╗░░██████╗░██╗░░░██╗███████╗░██████╗  ░██████╗░░█████╗░██╗░░░░░██╗░░░░░███████╗██████╗░██╗░░░██╗
██╔══██╗██╔══██╗██╔════╝░██║░░░██║██╔════╝██╔════╝  ██╔════╝░██╔══██╗██║░░░░░██║░░░░░██╔════╝██╔══██╗╚██╗░██╔╝
██████╔╝██║░░██║██║░░██╗░██║░░░██║█████╗░░╚█████╗░  ██║░░██╗░███████║██║░░░░░██║░░░░░█████╗░░██████╔╝░╚████╔╝░
██╔══██╗██║░░██║██║░░╚██╗██║░░░██║██╔══╝░░░╚═══██╗  ██║░░╚██╗██╔══██║██║░░░░░██║░░░░░██╔══╝░░██╔══██╗░░╚██╔╝░░
██║░░██║╚█████╔╝╚██████╔╝╚██████╔╝███████╗██████╔╝  ╚██████╔╝██║░░██║███████╗███████╗███████╗██║░░██║░░░██║░░░
╚═╝░░╚═╝░╚════╝░░╚═════╝░░╚═════╝░╚══════╝╚═════╝░  ░╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░");// texto: Spider-Man's Rogues Gallery
            Console.WriteLine(@"");
        }
        void exibir_opcoes()
        {
            Console.WriteLine("Digite 1 para pesquisar um vilão");
            Console.WriteLine("Digite 2 para Favoritar um Vilão");
            Console.WriteLine("Digite 3 para mostrar sua lista de vilões favoritos");
            Console.WriteLine("Digite 4 para excluir um vilão da lista");
            Console.WriteLine("\n Digite sua opção!");
        }
        void coleta_opcao()
        {
            int n;
            bool continuar = false;
            do
            {
                n = int.Parse(Console.ReadLine()!);
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Opção 1");
                        break;
                    case 2:
                        Console.WriteLine("Opção 2");

                        break;
                    case 3:
                        Console.WriteLine("Opção 3");
                        break;
                    case 4:
                        Console.WriteLine("Opção 4");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        Console.WriteLine("Tente Novamente");
                        continuar = true;
                        break;
                }
            } while (continuar);
        }
        void Menu()
        {
            exibir_opcoes();
            coleta_opcao();
        }

        //Chamando as funções.
        exibir_msg();
        Menu();
    }
}