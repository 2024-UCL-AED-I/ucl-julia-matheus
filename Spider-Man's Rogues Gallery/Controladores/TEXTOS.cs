namespace Spider_Man_s_Rogues_Gallery.Apresentação;

public class TEXTOS
{
   public void Texto_Slogan()
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
    public void Texto_EasterEgg()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("      Você encontrou nosso easter egg!");
        Console.WriteLine("========================================\n");
        Console.WriteLine("    PROGRAMA DESENVOLVIDO COM MUITA LUTA!\n");
        Console.WriteLine("Obrigado por ter usado nosso programa.");
        Console.WriteLine("Esperamos que tenha se divertido!!\n");
        Console.WriteLine("Lembre-se:");
        Console.WriteLine("Um dia você é o escolhido,");
        Console.WriteLine("no outro,");
        Console.WriteLine("o excluído!");
        Console.WriteLine("\nPassar bem!\n");
        Console.WriteLine("========================================");
    }
    public void Texto_Encerra_Programa()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("          Programa encerrado!!");
        Console.WriteLine("             Obrigado!!");
        Console.WriteLine("========================================\n");
    }
    public void Texto_opcaoInvalida()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("            Opção inválida!!");
        Console.WriteLine("            Tente Novamente");
        Console.WriteLine("========================================");

    }
    public void TextoDoMenuPrincipal()
    {
        string titulo = "MENU";
        int larguraTitulo = titulo.Length;

        string[] opcoes = new string[]
        {
    "0- SAIR",
    "1- Pesquisar um vilão",
    "2- Exibir lista de vilões favoritos",
    "3- Excluir um vilão da lista",
    "4- Gerar Relatório de Vilões",
    "5- Limpar Lista de Vilões Favoritos",
        };

        int larguraOpcaoMaxima = 0;

        foreach (string opcao in opcoes)
        {
            if (opcao.Length > larguraOpcaoMaxima)
            {
                larguraOpcaoMaxima = opcao.Length;
            }
        }

        string linha = new string('=', larguraOpcaoMaxima);
        string espacos = new string(' ', (larguraOpcaoMaxima - larguraTitulo) / 2);

        Console.WriteLine(espacos + titulo);
        Console.WriteLine(linha);
        foreach (string opcao in opcoes)
        {
            Console.WriteLine(opcao);
        }
        Console.WriteLine(linha);
        Console.WriteLine("Digite sua opção!\n");
    }

    public void Texto_slogan_EasterEgg()
    {
        Console.WriteLine();
        Console.WriteLine(@"
                _,,gg,,_                                 _,,gg,,_
            ,a888P88Y888a,                           ,a888P88Y888a,
          ,d""8""8"",YY,""8""8""b,                       ,d""8""8"",YY,""8""8""b,
         d"",P'd' d'`b `b`Y,""b,                    d"",P'd' d'`b `b`Y,""b,
       ,P"",P',P  8  8  Y,`Y,""Y,                 ,P"",P',P  8  8  Y,`Y,""Y,
      ,P ,P' d'  8  8  `b `Y, Y,               ,P ,P' d'  8  8  `b `Y, Y,
     ,P ,P_,,8ggg8gg8ggg8,,_Y, Y,             ,P ,P_,,8ggg8gg8ggg8,,_Y, Y,
    ,8P""""""""""""""''      ``""""""""""""""Y8,           ,8P""""""""""""""''      ``""""""""""""""Y8,
    d'/~\    /~\    /~\    /~\  `b           d' ,a8a,    /\ /\    ,a8a,  `b
    8/   \  /   \  /   \  /   \  8           8 ,P"" ""Y,    ( )    ,P"" ""Y,  8
    8 ,8, \/ ,8, \/ ,8, \/ ,8, \/8           8,P'   `Y, .( o ). ,P'   `Y, 8
    8 ""Y"" /\ ""Y"" /\ ""Y"" /\ ""Y"" /\8           8P'/\ /\`Y,   _   ,P'/\ /\`Y,8
    8\   /  \   /  \   /  \   /  8           8'  ( )  `Y, (_) ,P'  ( )  `Y8
    8 \_/    \_/    \_/    \_/   8           8 .( o ). `Ya   aP' .( o ). `8
    8                            8           8 =-=-=-=   ""YaP""   =-=-=-=  8
    Y""""""""YYYaaaa,,,,,,aaaaPPP""""""""P           Y""""""""YYYaaaa,,,,,,aaaaPPP""""""""P
    `b ag,   ``""""""""""""""""''   ,ga d'           `b ag,   ``""""""""""""""""''   ,ga d'
     `YP ""b,  ,aa,  ,aa,  ,d"" YP'             `YP ""b,  ,aa,  ,aa,  ,d"" YP'
       ""Y,_""Ya,_)8  8(_,aP""_,P""                 ""Y,_""Ya,_)8  8(_,aP""_,P""
          `""Ya_""""""    """"""_aP""'                     `""Ya_""""""    """"""_aP""'
             `""""YYbbddPP""""'                           `""""YYbbddPP""""'");
    }
    public void Texto_ListaVazia()
    {
        Console.WriteLine(@"Oops! Sua lista está vazia. Que tal adicionar alguns vilões?");
    }
}
