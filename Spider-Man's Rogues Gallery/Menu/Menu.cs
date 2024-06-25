using Spider_Man_s_Rogues_Gallery.Apresentação;
using Spider_Man_s_Rogues_Gallery.Classes;

namespace Spider_Man_s_Rogues_Gallery.Menu;
public class Menu:TEXTOS
{
    public void finaliza_funcao()
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu!");
        Console.ReadLine();
        Console.Clear();
    }
    public void Exibir_titulo_funcao(string titulo)
    {
        int qtd_Letras = titulo.Length;
        string molde = string.Empty.PadLeft(qtd_Letras, '*');
        Console.WriteLine(molde);
        Console.WriteLine(titulo);
        Console.WriteLine(molde + "\n");
    }

    public void Exibi_lista(List<class_vilao> lista)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "Relatório Spider-Man's Rogues Gallery.txt");


        if (File.Exists(filePath))
        {
            try
            {
                string ConteudoDoTxt = File.ReadAllText(filePath);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Erro ao ler o arquivo!");
                Console.WriteLine(ex.Message);
            }
        }


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
            Texto_ListaVazia();
        }
    }


}
