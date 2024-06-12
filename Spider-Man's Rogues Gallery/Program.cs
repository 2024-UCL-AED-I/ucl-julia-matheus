//Spider-Man's Rogues Gallery
using System.Text.Json;
using System;
using System.IO;
using System.Collections.Generic;
using Spider_Man_s_Rogues_Gallery;
using System.Net.NetworkInformation;
using System.Xml;


class Program
{
    static void Main()
    {
        //listar fixas (IMPORTANTES PARA O PROGRAMA FUNCIONAR!!)
        List<class_vilao> list_vilao_favoritados = new List<class_vilao>();
        List<class_vilao> list_viloes = new List<class_vilao>();
        String caminho_do_arquivojson = @"C:\Users\mathe\source\repos\2024-UCL-AED-I\ucl-julia-matheus\lista_vilao.json";

        //Caminhos relativos para as máquinas dos desenvolvedores !!
        //caminho Julia: @"C:\Users\clabu\source\repos\ucl-julia-matheus\lista_vilao.json";
        //caminho Matheus - Trabalho: @"C:\Users\matheus.souza\source\repos\2024-UCL-AED-I\ucl-julia-matheus\lista_vilao.json";
        //String caminho_do_arquivojson = @"C:\Users\mathe\source\repos\2024-UCL-AED-I\ucl-julia-matheus\lista_vilao.json";

        //Como é feita a converção do arquivo JSON!!
        string jsonString = File.ReadAllText(caminho_do_arquivojson);
        list_viloes = JsonSerializer.Deserialize<List<class_vilao>>(jsonString);

        //Codigo para agilizar desenvolvimento da função:Exibir lista de favoritos.(Retirar para apresentação!!)
        

        void Pesquisa_Vilao() 
        {
            Console.Clear();
            Exibir_Titulo_da_opcao("Pesquisando vilão...");
            Exibi_lista(list_viloes);
            Console.WriteLine("Digite o nome do Vilão que deseja ver os dados.");
            string nome_do_vilao = Console.ReadLine()!;
            Console.WriteLine("\n");
            class_vilao vilaoEncontrado = list_viloes.Find(v => v.nome_do_vilao.Equals(nome_do_vilao, StringComparison.OrdinalIgnoreCase));

            if (vilaoEncontrado != null)
            {
                vilaoEncontrado.Exibir_detalhes_do_vilao();
            }
            if(int.Parse(nome_do_vilao)<= list_viloes.Count)
            {
                
                list_viloes[(int.Parse(nome_do_vilao)-1)].Exibir_detalhes_do_vilao();
                vilaoEncontrado = list_viloes[(int.Parse(nome_do_vilao) - 1)];
            }
            else
            {
                Console.WriteLine("Vilão não encontrado.");
            }

            Console.WriteLine("\nDeseja favoritar este vilão ? (s/n)");
            string escolha = Console.ReadLine()!;
            if (escolha == "s" || escolha == "S") 
            {
                list_vilao_favoritados.Add(vilaoEncontrado!);
                Console.WriteLine("Vilão adicionado com sucesso !!");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            finaliza_funcao();
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
                        Exibir_lista_de_viloes_favoritos();
                        break;
                    case 3:
                        //Console.WriteLine("Opção 4");
                        Excluir_vilao_da_lista();
                        break;
                    case 0:
                        Console.WriteLine("\nPrograma encerrado!!");
                        Console.WriteLine("Obridago !!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        Console.WriteLine("Tente Novamente");
                        continuar = true;
                        break;
                    case -100:
                        Console.WriteLine("Você encontrou nosso easter egg.");
                        Console.WriteLine("PROGRAMA DESENVOLVIDO COM MUITA LUTA!");
                        Console.WriteLine("Obrigado por ter usado nosso programa.");
                        Console.WriteLine("Esperamos que tenha se divertido!!");
                        Console.WriteLine("Lembre-se :\nUm dia você é o escolhido,\nno outro,\no excluido!\nPassar bem!");
                        return;
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
            Exibi_lista(list_vilao_favoritados);
            finaliza_funcao();
        }
        void Excluir_vilao_da_lista()
        {
            Console.Clear();
            Exibir_Titulo_da_opcao("Excluindo vilão da lista...");
            Console.WriteLine("Qual vilão deseja retirar da lista de Favoritos ?");
            Exibi_lista(list_vilao_favoritados);
            string nome = Console.ReadLine()!;

            class_vilao vilaoEncontrado = list_vilao_favoritados.Find(v => v.nome_do_vilao.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (vilaoEncontrado != null)
            {
                list_vilao_favoritados.Remove(vilaoEncontrado);
                Console.WriteLine($"O vilão {nome} foi removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Vilão não foi encontrado."); 
            }
            Console.WriteLine("");
            finaliza_funcao();
        }
        void Exibir_Titulo_da_opcao(string titulo)
        {
            int qtd_Letras = titulo.Length;
            string molde =  string.Empty.PadLeft(qtd_Letras, '*');
            Console.WriteLine(molde);
            Console.WriteLine(titulo);
            Console.WriteLine(molde+"\n");
        }
        void finaliza_funcao()
        {
            Console.WriteLine("Digite qualquer tecla para voltar ao menu.");
            Console.ReadLine();
            Console.Clear();
            Menu();
        }
        void Exibi_lista(List<class_vilao> lista)
        {
            if (lista.Count > 0)
            {
                int i = 1;
                foreach (class_vilao vilao in lista)
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
        }
        exibir_msg();
        Menu();
    }
}