

using Spider_Man_s_Rogues_Gallery.Classes;
using System.Collections.Generic;
using System.Linq;

namespace Spider_Man_s_Rogues_Gallery.Menu;

public class FiltraPoder:Menu
{
    public void executar(List<class_vilao> list_viloes)
    {
        Console.Clear();
        Exibir_titulo_funcao("Filtrando Vilões...");
        FiltraPoderes(list_viloes);
        finaliza_funcao();
    }

    public void FiltraPoderes(List<class_vilao> list_viloes)
    {
        List<string> ListaPoderesString = new();

        foreach (class_vilao vilao in list_viloes)
        {
            foreach (SuperPoder poder in vilao.ListaPoderes)
            {
                if(!ListaPoderesString.Contains(poder.Nome))
                {
                    ListaPoderesString.Add(poder.Nome);
                }
            }
        }

        int i = 1;

        foreach(string primeiro in ListaPoderesString)
        {
            Console.WriteLine($"{i}-{primeiro}");
            i++;
        }

        Console.WriteLine($);
        Console.WriteLine("\nDigite o numero do poder que deseja filtrar");

        int PoderEscolhido = int.Parse(Console.ReadLine()!);

        List<class_vilao> viloesFiltrados = new();
        

        foreach (class_vilao vilao in list_viloes)
        {
            //vilao.ListaPoderes.Find(v => v.Nome.Equals(PoderEscolhido, StringComparison.OrdinalIgnoreCase));
            foreach(string pode in vilao.PoderesString)
            {
                if(pode == ListaPoderesString[PoderEscolhido])
                {
                    if(!viloesFiltrados.Contains(vilao))
                    {
                        viloesFiltrados.Add(vilao);
                    }
                }
            }
        }
        foreach(class_vilao vil in viloesFiltrados)
        {
            Console.WriteLine(vil.nome_do_vilao); ;
        }
    }

}





