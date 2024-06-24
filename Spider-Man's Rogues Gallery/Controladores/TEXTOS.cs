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
        Console.WriteLine("Você encontrou nosso easter egg.");
        Console.WriteLine("PROGRAMA DESENVOLVIDO COM MUITA LUTA!");
        Console.WriteLine("Obrigado por ter usado nosso programa.");
        Console.WriteLine("Esperamos que tenha se divertido!!");
        Console.WriteLine("Lembre-se :\nUm dia você é o escolhido,\nno outro,\no excluido!\nPassar bem!");
    }
    public void Texto_Encerra_Programa()
    {
        Console.WriteLine("\nPrograma encerrado!!");
        Console.WriteLine("Obridago !!");
    }
    public void Texto_opcaoInvalida()
    {
        Console.WriteLine("Opção inválida!!");
        Console.WriteLine("Tente Novamente");
    }
    public void TextoDoMenuPrincipal()
    {
        int qtd_Letras = "Digite 2 para mostrar sua lista de vilões favoritos".Length;
        string molde = string.Empty.PadLeft(qtd_Letras, '-');
        string espaço = string.Empty.PadLeft(qtd_Letras / 2, ' ');

        Console.WriteLine(espaço + "MENU");
        Console.WriteLine(molde);
        Console.WriteLine("0- SAIR");
        Console.WriteLine("1- Pesquisar um vilão");
        Console.WriteLine("2- Exibir lista de vilões favoritos");
        Console.WriteLine("3- Excluir um vilão da lista");
        Console.WriteLine("4- Gerar Relatório de Vilões");
        Console.WriteLine("5- Limpar Lista de Vilões Favoritos");
        Console.WriteLine("6- Teste adiciona lista inteira de vilões");
        Console.WriteLine(molde);
        Console.WriteLine("Digite sua opção!\n");
    }
    public void Texto_slogan_EasterEgg()
    {
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
        Console.WriteLine("Sua lista está vazia!!");
    }
}
