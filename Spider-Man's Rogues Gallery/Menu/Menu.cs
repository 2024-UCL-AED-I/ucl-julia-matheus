namespace Spider_Man_s_Rogues_Gallery.Menu;
public class Menu
{
    public void finaliza_funcao()
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu!");
        Console.ReadLine();
        Console.Clear();
    }
    public void Exibi_lista(List<class_vilao> lista)
    {
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
            Console.WriteLine("Lista vazia!!");
        }
    }
    public void Exibir_Titulo_da_opcao(string titulo)
    {
        int qtd_Letras = titulo.Length;
        string molde = string.Empty.PadLeft(qtd_Letras, '*');
        Console.WriteLine(molde);
        Console.WriteLine(titulo);
        Console.WriteLine(molde + "\n");
    }


}
