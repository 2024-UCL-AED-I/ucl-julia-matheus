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
        String caminho_do_arquivojson = @"C:\Users\clabu\source\repos\ucl-julia-matheus\lista_vilao.json";
        //caminho Julia: @"C:\Users\clabu\source\repos\ucl-julia-matheus\lista_vilao.json";
        //caminho Matheus: @"C:\Users\matheus.souza\source\repos\2024-UCL-AED-I\ucl-julia-matheus\lista_vilao.json";
        string jsonString = File.ReadAllText(caminho_do_arquivojson);
        list_viloes = JsonSerializer.Deserialize<List<class_vilao>>(jsonString);  
        
        void Pesquisa_Vilao() 
        {
            Console.WriteLine("\nDigite o nome do Vilão que deseja pesquisar.");
            string nome_do_vilao = Console.ReadLine()!;

            class_vilao vilaoEncontrado = list_viloes.Find(v => v.nome_do_vilao.Equals(nome_do_vilao, StringComparison.OrdinalIgnoreCase));

            if (vilaoEncontrado != null)
            {
                Console.WriteLine("\n");
                vilaoEncontrado.Exibir_detalhes_do_vilao();
            }
            else
            {
                Console.WriteLine("Vilão não encontrado.");
            }

            Console.WriteLine("Deseja favoritar este vilão ? s/n");
            string escolha = Console.ReadLine()!;
            if (escolha == "s") 
            {
                list_vilao_favoritados.Add(vilaoEncontrado);
            }

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
                        Pesquisa_Vilao();
                        break;
                    case 2:
                        //Console.WriteLine("Opção 2");
                        
                        break;
                    case 3:
                        //Console.WriteLine("Opção 3");
                        Exibir_lista_de_viloes_favoritos();
                        break;
                    case 4:
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
        static void Exibir_lista_de_viloes_favoritos()
        {

        }
        static void Excluir_vilao_da_lista()
        {

        }
        exibir_msg();
        Menu();
    }
}