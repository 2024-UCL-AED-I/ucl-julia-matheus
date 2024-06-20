namespace Spider_Man_s_Rogues_Gallery.Classes;

public class SuperPoder
{
    public string Nome { get; set; }

    public SuperPoder(string nome)
    {
        Nome = nome;
    }

    public void ExibirSuperPoder()
    {
        Console.WriteLine($"Super Poder: {}");
    }
    public void ExibirLista(List<SuperPoder> lista)
    {
        foreach(SuperPoder poder in lista)
        {
            Console.WriteLine(poder.Nome);
        }
    }
}
