using System.Text.Json.Serialization;

namespace Spider_Man_s_Rogues_Gallery.Classes;

public class SuperPoder
{
    public string Nome { get; set; }

    public SuperPoder(string nome)
    {
        this.Nome = nome;
    }

    // Método estático que recebe uma lista de strings e retorna uma lista de SuperPoder
    public static List<SuperPoder> CriarListaDeSuperPoderes(List<string> nomes)
    {
        List<SuperPoder> superPoderes = new List<SuperPoder>();
        foreach (string nome in nomes)
        {
            superPoderes.Add(new SuperPoder(nome)); 
        }
        return superPoderes;
    }

}
