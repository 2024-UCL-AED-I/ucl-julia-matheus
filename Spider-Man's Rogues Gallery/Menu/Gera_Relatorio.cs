using Spider_Man_s_Rogues_Gallery.Classes;

namespace Spider_Man_s_Rogues_Gallery.Menu;

public class Gera_Relatorio:Menu
{
    
    public void Executar(List<class_vilao> list_VilaoFavoritos)
    {
        Console.Clear();
        Exibir_titulo_funcao("Gerando Relatório...");

        if (list_VilaoFavoritos.Count > 0)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Relatório Spider-Man's Rogues Gallery.txt");

            foreach (class_vilao vilao in list_VilaoFavoritos)
            {
                
                File.AppendAllText(filePath,vilao.ConteudoRelatorio);
                File.AppendAllText(filePath, "-------------------------------------------------\n");
            }

            Console.WriteLine("Relatório criado com sucesso na área de trabalho!");
        }
        else
        {
            Console.WriteLine("A sua lista está vazia!!");
        }
        finaliza_funcao();
    }
}
