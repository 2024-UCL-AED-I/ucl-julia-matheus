//Spider-Man's Rogues Gallery
using System.Text.Json;
using System;
using Spider_Man_s_Rogues_Gallery.Modelos;
using Spider_Man_s_Rogues_Gallery;
using vilao = Spider_Man_s_Rogues_Gallery.Modelos.vilao;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/Matheus-Emanoel-Souza/Amigos.da.vizinhanca/main/Lista%20de%20vil%C3%B5es.JSON");
        List<vilao> viloes = JsonSerializer.Deserialize<List<vilao>>(resposta);

        foreach (vilao vilao in viloes)
        {
            vilao.Exibir_detalhes_do_vilao();
        }
        //vilao vilaoEncontrado = viloes.Find(v => v.nome_vilao.Equals(nome, StringComparison.OrdinalIgnoreCase));

        //if (vilaoEncontrado != null)
        //{
        //    Console.WriteLine($"Vilão encontrado: {vilaoEncontrado.nome_vilao}");
        //    Console.WriteLine($"Descrição: {vilaoEncontrado.nome_vilao}");
        //}
        //else
        //{
        //    Console.WriteLine("Vilão não encontrado.");
        //}
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

//class Program
//{
//    static void Main()
//    {
//        //Criando as funções;
//        void exibir_msg()
//        {
//            Console.WriteLine(@"
//                    ░██████╗██████╗░██╗██████╗░███████╗██████╗░░░░░░░███╗░░░███╗░█████╗░███╗░░██╗██╗░██████╗
//                    ██╔════╝██╔══██╗██║██╔══██╗██╔════╝██╔══██╗░░░░░░████╗░████║██╔══██╗████╗░██║╚█║██╔════╝
//                    ╚█████╗░██████╔╝██║██║░░██║█████╗░░██████╔╝█████╗██╔████╔██║███████║██╔██╗██║░╚╝╚█████╗░
//                    ░╚═══██╗██╔═══╝░██║██║░░██║██╔══╝░░██╔══██╗╚════╝██║╚██╔╝██║██╔══██║██║╚████║░░░░╚═══██╗
//                    ██████╔╝██║░░░░░██║██████╔╝███████╗██║░░██║░░░░░░██║░╚═╝░██║██║░░██║██║░╚███║░░░██████╔╝
//                    ╚═════╝░╚═╝░░░░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝░░░░░░╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░░░╚═════╝░

//                    ██████╗░░█████╗░░██████╗░██╗░░░██╗███████╗░██████╗  ░██████╗░░█████╗░██╗░░░░░██╗░░░░░███████╗██████╗░██╗░░░██╗
//                    ██╔══██╗██╔══██╗██╔════╝░██║░░░██║██╔════╝██╔════╝  ██╔════╝░██╔══██╗██║░░░░░██║░░░░░██╔════╝██╔══██╗╚██╗░██╔╝
//                    ██████╔╝██║░░██║██║░░██╗░██║░░░██║█████╗░░╚█████╗░  ██║░░██╗░███████║██║░░░░░██║░░░░░█████╗░░██████╔╝░╚████╔╝░
//                    ██╔══██╗██║░░██║██║░░╚██╗██║░░░██║██╔══╝░░░╚═══██╗  ██║░░╚██╗██╔══██║██║░░░░░██║░░░░░██╔══╝░░██╔══██╗░░╚██╔╝░░
//                    ██║░░██║╚█████╔╝╚██████╔╝╚██████╔╝███████╗██████╔╝  ╚██████╔╝██║░░██║███████╗███████╗███████╗██║░░██║░░░██║░░░
//                    ╚═╝░░╚═╝░╚════╝░░╚═════╝░░╚═════╝░╚══════╝╚═════╝░  ░╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░");// texto: Spider-Man's Rogues Gallery
//            Console.WriteLine(@"
//                                                                       ,,,, 
//                                                                 ,;) .';;;;',
//                                                     ;;,,_,-.-.,;;'_,|I\;;;/),,_
//                                                      `';;/:|:);{ ;;;|| \;/ /;;;\__
//                                                          L;/-';/ \;;\',/;\/;;;.') \
//                                                          .:`''` - \;;'.__/;;;/  . _'-._ 
//                                                        .'/   \     \;;;;;;/.'_7:.  '). \_
//                                                      .''/     | '._ );}{;//.'    '-:  '.,L
//                                                    .'. /       \  ( |;;;/_/         \._./;\   _,
//                                                     . /        |\ ( /;;/_/             ';;;\,;;_,
//                                                    . /         )__(/;;/_/                (;;'''''
//                                                     /        _;:':;;;;:';-._             );
//                                                    /        /   \  `'`   --.'-._         \/
//                                                           .'     '.  ,'         '-,
//                                                          /    /   r--,..__       '.\
//                                                        .'    '  .'        '--._     ]
//                                                        (     :.(;>        _ .' '- ;/
//                                                        |      /:;(    ,_.';(   __.'
//                                                         '- -'""|;:/    (;;;;-'--'
//                                                               |;/      ;;(
//                                                               ''      /;;|
//                                                                       \;;|
//                                                                        \/");
//        }
//        void exibir_opcoes()
//        {
//            Console.WriteLine("Digite 1 para pesquisar um vilão");
//            Console.WriteLine("Digite 2 para Favoritar um Vilão");
//            Console.WriteLine("Digite 3 para mostrar sua lista de vilões favoritos");
//            Console.WriteLine("Digite 4 para excluir um vilão da lista");
//            Console.WriteLine("\n Digite sua opção!");
//        }
//        void coleta_opcao()
//        {
//            int n;
//            bool continuar = false;
//            do
//            {
//                n = int.Parse(Console.ReadLine()!);
//                switch (n)
//                {
//                    case 1:
//                        //Console.WriteLine("Opção 1");
//                        pesquisa_vilaoAsync();
//                        break;
//                    case 2:
//                        //Console.WriteLine("Opção 2");
//                        Favoritar_vilao();
//                        break;
//                    case 3:
//                        //Console.WriteLine("Opção 3");
//                        Exibir_lista_de_viloes_favoritos();
//                        break;
//                    case 4:
//                        //Console.WriteLine("Opção 4");
//                        Excluir_vilao_da_lista();
//                        break;
//                    default:
//                        Console.WriteLine("Opção inválida!!");
//                        Console.WriteLine("Tente Novamente");
//                        continuar = true;
//                        break;
//                }
//            } while (continuar);
//        }
//        void Menu()
//        {
//            exibir_opcoes();
//            coleta_opcao();
//        }
//        static async Task pesquisa_vilaoAsync()
//        {
            
//        }
//        static void Favoritar_vilao()
//        {

//        }
//        static void Exibir_lista_de_viloes_favoritos()
//        {

//        }
//        static void Excluir_vilao_da_lista()
//        {

//        }
//        exibir_msg();
//        Menu();
//    }
//}