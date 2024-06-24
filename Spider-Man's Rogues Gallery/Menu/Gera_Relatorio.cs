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

    

    public void Executar(List<Vilao> list_VilaoFavoritos)
    {
        Console.Clear();
        Limpar_Relatorio();
        Exibir_titulo_funcao("Gerando Relatório...");

        if (list_VilaoFavoritos.Count > 0)
        {

            int i = 1;
            foreach (Vilao vilao in list_VilaoFavoritos)
            {
                File.AppendAllText(filePath, $"Numero:{i}\n");
                File.AppendAllText(filePath,vilao.Relatorio);
                File.AppendAllText(filePath, "------------------------------------------------------------------------------------------------------\n");
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
    public void LimparLista(List<Vilao> listaViloes)
    {
        if (listaViloes.Count > 0 || File.Exists(filePath) == false)
        {
            Exibir_titulo_funcao("Limpando a lista...");
            Console.WriteLine("A sua lista de Vilões Favoritos foi limpo!!");
            Console.WriteLine("Relatórios gerados também foram limpos!!");
            listaViloes.Clear();
            Limpar_Relatorio();
        }
        else
        {
            Texto_ListaVazia();
        }           
        finaliza_funcao();
    }
}
