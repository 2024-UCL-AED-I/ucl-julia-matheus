using Spider_Man_s_Rogues_Gallery.Apresentação;
using Spider_Man_s_Rogues_Gallery.Classes;

namespace Spider_Man_s_Rogues_Gallery.Menu;

public class Gera_Relatorio:Menu
{
    private string desktopPath
    {
        get
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return desktopPath;
        }
    }
    private string filePath
    {
        get
        {
            string filePath = Path.Combine(desktopPath, "Relatório Spider-Man's Rogues Gallery.txt");
            return filePath;
        }
    }

    

    public void Executar(List<class_vilao> list_VilaoFavoritos)
    {
        Console.Clear();
        Limpar_Relatorio();
        Exibir_titulo_funcao("Gerando Relatório...");

        if (list_VilaoFavoritos.Count > 0)
        {

            int j = list_VilaoFavoritos.Count;
            int i = 1;

            File.AppendAllText(filePath, $"\nVocê tem {j} vilões Favoritados!!\n");
            File.AppendAllText(filePath, "\n-----------------------------------------------------------------------------------------------------------------------\n");


            foreach (class_vilao vilao in list_VilaoFavoritos)
            {
                File.AppendAllText(filePath, $"\nNumero:{i}\n");
                File.AppendAllText(filePath,vilao.ConteudoRelatorio);
                File.AppendAllText(filePath, "\n-----------------------------------------------------------------------------------------------------------------------\n");
                i++;
            }

            Console.WriteLine("Relatório criado com sucesso na área de trabalho!");
        }
        else
        {
            Texto_ListaVazia();
        }
        finaliza_funcao();
    }
    public void Limpar_Relatorio()
    {
        File.WriteAllText(filePath, string.Empty);
    }
    public void LimparLista(List<class_vilao> listaViloes)
    {
        if (listaViloes.Count > 0 || File.Exists(filePath) == false)
        {
            Console.WriteLine("Você tem certeza que deseja limpar a lista de vilões favoritados ?\nCaso deseje digite (\"Sim\")");
            string escolha = Console.ReadLine()!;
            if (escolha.TrimStart().ToUpper() == "Sim")
            {
                Exibir_titulo_funcao("Limpando a lista...");
                Console.WriteLine("A sua lista de Vilões Favoritos foi limpo!!");
                Console.WriteLine("Relatórios gerados também foram limpos!!");
                listaViloes.Clear();
                Limpar_Relatorio();
            }
            else
            {
                Console.WriteLine("Lista Preservada!!");
            }           
        }
        else
        {
            Texto_ListaVazia();
        }           
        finaliza_funcao();
    }
}
