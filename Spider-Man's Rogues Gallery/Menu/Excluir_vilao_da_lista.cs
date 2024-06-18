using Spider_Man_s_Rogues_Gallery.Classes;

namespace Spider_Man_s_Rogues_Gallery.Menu;

public class Excluir_vilao_da_lista:Menu
{
    public void Executar(List<class_vilao> list_vilao_favoritados, List<class_vilao> list_viloes)
    {
        if (list_vilao_favoritados.Count != 0)
        {
            Console.Clear();
            Exibir_titulo_funcao("Excluindo vilão da lista...");
            Console.WriteLine("Qual vilão deseja retirar da lista de Favoritos ?");
            Exibi_lista(list_vilao_favoritados);
            string nome = Console.ReadLine()!;

            class_vilao vilaoEncontrado = list_vilao_favoritados.Find(v => v.nome_do_vilao.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (vilaoEncontrado != null)
            {
                list_vilao_favoritados.Remove(vilaoEncontrado);
                Console.WriteLine($"O vilão {nome} foi removido com sucesso!");
            }
            if (int.Parse(nome) <= list_viloes.Count)
            {
                vilaoEncontrado = list_vilao_favoritados[(int.Parse(nome) - 1)];
                list_vilao_favoritados.Remove(vilaoEncontrado);
                Console.WriteLine($"O vilão: ({vilaoEncontrado.nome_do_vilao}) foi removido com sucesso!");

            }
            else
            {
                Console.WriteLine("Vilão não foi encontrado!");
            }
        }
        else
        {
            Console.WriteLine("\nA sua lista está Vazia!!");
        }
        finaliza_funcao();
    }
}
