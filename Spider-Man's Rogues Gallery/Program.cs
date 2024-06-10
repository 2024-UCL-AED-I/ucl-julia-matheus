//Spider-Man's Rogues Gallery
using System.Text.Json;
using System;
using System.IO;
using System.Collections.Generic;
using Spider_Man_s_Rogues_Gallery;
using System.Net.NetworkInformation;


class Program
{
    static void Main()
    {
        List<class_vilao> list_vilao_favoritados = new List<class_vilao>();
        List<class_vilao> list_viloes = new List<class_vilao>();
        String caminho_do_arquivojson = @"C:\Users\matheus.souza\source\repos\2024-UCL-AED-I\ucl-julia-matheus\lista_vilao.json";
        //caminho Julia: @"C:\Users\clabu\source\repos\ucl-julia-matheus\lista_vilao.json";
        //caminho Matheus - Trabalho: @"C:\Users\matheus.souza\source\repos\2024-UCL-AED-I\ucl-julia-matheus\lista_vilao.json";
        //caminho Matheus - casa: @"C:";
        string jsonString = File.ReadAllText(caminho_do_arquivojson);
        list_viloes = JsonSerializer.Deserialize<List<class_vilao>>(jsonString);  
        
        void Pesquisa_Vilao() 
        {
            Console.Clear();
            Exibir_Titulo_da_opcao("Pesquisando vilão...");
            Console.WriteLine("Digite o nome do Vilão que deseja pesquisar.");
            string nome_do_vilao = Console.ReadLine()!;
            Console.WriteLine("\n");
            class_vilao vilaoEncontrado = list_viloes.Find(v => v.nome_do_vilao.Equals(nome_do_vilao, StringComparison.OrdinalIgnoreCase));

            if (vilaoEncontrado != null)
            {
                vilaoEncontrado.Exibir_detalhes_do_vilao();
            }
            else
            {
                Console.WriteLine("Vilão não encontrado.");
                Menu();
            }

            Console.WriteLine("\nDeseja favoritar este vilão ? (s/n)");
            string escolha = Console.ReadLine()!;
            if (escolha == "s") 
            {
                list_vilao_favoritados.Add(vilaoEncontrado!);
                Console.WriteLine("Vilão adicionado com sucesso !");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu Principal!");
            Console.ReadLine();
            Console.Clear();
            Menu();
        }

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
            Console.WriteLine(@"
                                                                       ,,,, 
                                                                 ,;) .';;;;',
                                                     ;;,,_,-.-.,;;'_,|I\;;;/),,_
                                                      `';;/:|:);{ ;;;|| \;/ /;;;\__
                                                          L;/-';/ \;;\',/;\/;;;.') \
                                                          .:`''` - \;;'.__/;;;/  . _'-._ 
                                                        .'/   \     \;;;;;;/.'_7:.  '). \_
                                                      .''/     | '._ );}{;//.'    '-:  '.,L
                                                    .'. /       \  ( |;;;/_/         \._./;\   _,
                                                     . /        |\ ( /;;/_/             ';;;\,;;_,
                                                    . /         )__(/;;/_/                (;;'''''
                                                     /        _;:':;;;;:';-._             );
                                                    /        /   \  `'`   --.'-._         \/
                                                           .'     '.  ,'         '-,
                                                          /    /   r--,..__       '.\
                                                        .'    '  .'        '--._     ]
                                                        (     :.(;>        _ .' '- ;/
                                                        |      /:;(    ,_.';(   __.'
                                                         '- -'""|;:/    (;;;;-'--'
                                                               |;/      ;;(
                                                               ''      /;;|
                                                                       \;;|
                                                                        \/");
        }
        void exibir_opcoes()
        {
            int qtd_Letras = "Digite 2 para mostrar sua lista de vilões favoritos".Length;
            string espaço = string.Empty.PadLeft(qtd_Letras/2, ' ');
            Console.WriteLine(espaço+"MENU");
            //PODEMOS ESTILIZAR ESSE MENU.
            
            string molde = string.Empty.PadLeft(qtd_Letras, '-');

            Console.WriteLine(molde);
            Console.WriteLine("Digite 1 para pesquisar um vilão");
            Console.WriteLine("Digite 2 para mostrar sua lista de vilões favoritos");
            Console.WriteLine("Digite 3 para excluir um vilão da lista");
            Console.WriteLine(molde);

            Console.WriteLine("Digite sua opção!");
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
                        Pesquisa_Vilao();
                        break;
                    case 2:
                        //Console.WriteLine("Opção 3");
                        Exibir_lista_de_viloes_favoritos();
                        break;
                    case 3:
                        //Console.WriteLine("Opção 4");
                        Excluir_vilao_da_lista();
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
        void Exibir_lista_de_viloes_favoritos()
        {
            Console.Clear();
            Exibir_Titulo_da_opcao("Exibindo todos os vilões Favoritados");
            int rep = list_viloes.Count;
            for (int i = 0; i < rep; i++)
            {
                list_vilao_favoritados.Add(list_viloes[i]);
            }
            if (list_vilao_favoritados.Count > 0 )
            {
                int i = 1;
                foreach (class_vilao vilao in list_vilao_favoritados)
                {
                    
                    Console.Write($"{i} - ");
                    Console.Write(vilao.nome_do_vilao);
                    Console.WriteLine("");
                    i++;
                                     
                }
            }
            else
            {
                Console.WriteLine("Lista vazia");
            }
            Console.WriteLine("");
            Console.WriteLine("Digite qualquer tecla para voltar para o menu!");
            Console.ReadLine();
            Menu();
        }
        void Excluir_vilao_da_lista()
        {
            Console.Clear();
            Exibir_Titulo_da_opcao("Excluindo vilão da lista...");
            Menu();
        }
        void Exibir_Titulo_da_opcao(string titulo)
        {
            int qtd_Letras = titulo.Length;
            string molde =  string.Empty.PadLeft(qtd_Letras, '*');
            Console.WriteLine(molde);
            Console.WriteLine(titulo);
            Console.WriteLine(molde+"\n");
        }
        exibir_msg();
        Menu();
    }
}