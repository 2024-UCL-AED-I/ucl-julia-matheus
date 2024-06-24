using Spider_Man_s_Rogues_Gallery.Classes;

namespace Spider_Man_s_Rogues_Gallery.Menu;

public  class PesquisaVilao : Menu
{
    public void Executar(List<Vilao> list_viloes, List<Vilao> list_vilao_favoritados)
    {
        Console.Clear();
        Exibir_titulo_funcao("Pesquisando vilão...");
        Exibi_lista(list_viloes);
        Console.WriteLine("\nDigite o nome ou Numero do Vilão que deseja ver os dados.");
        string nome_do_vilao = Console.ReadLine();
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Vilao vilaoEncontrado = list_viloes.Find(v => v.NomeDoVilao.Equals(nome_do_vilao, StringComparison.OrdinalIgnoreCase));

        if (vilaoEncontrado != null)
        {
            vilaoEncontrado.ExibirDetalhesDoVilao();
        }
        if (int.Parse(nome_do_vilao) <= list_viloes.Count)
        {

            list_viloes[(int.Parse(nome_do_vilao) - 1)].ExibirDetalhesDoVilao();
            vilaoEncontrado = list_viloes[(int.Parse(nome_do_vilao) - 1)];
        }
        else
        {
            Console.WriteLine("Vilão não encontrado.");
        }

        Console.WriteLine("\nDeseja favoritar este vilão? (s,1) ou (n)");
        string escolha = Console.ReadLine()!;
        //if (int.Parse(escolha) == 1)
        //if (escolha == "s" || escolha == "S" || int.Parse(escolha) == 1)
        if (escolha.ToLower() == "s" || escolha == "1")
        {
            if (!list_vilao_favoritados.Contains(vilaoEncontrado))
            {
                list_vilao_favoritados.Add(vilaoEncontrado!);
                Console.WriteLine("Vilão adicionado com sucesso !!");
            }
            else
            {
                Console.WriteLine("Vilão já presente na sua lista!!");
            }
        }
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        finaliza_funcao();
    }

}
