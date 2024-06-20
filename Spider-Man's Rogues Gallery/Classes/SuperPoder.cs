using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using static Spider_Man_s_Rogues_Gallery.Classes.class_vilao;

namespace Spider_Man_s_Rogues_Gallery.Classes;

public class SuperPoder
{
    public string NomeSuperPoder { get; private set; }

    private static List<string> SuperPoderList = new List<string>
    {
        "Super Força",
        "Velocidade",
        "Voo",
        "preencer",
    };

    public SuperPoder(string NomeSuperPoder1)
    {
        if (SuperPoderList.Contains(NomeSuperPoder1))
        {
            NomeSuperPoder = NomeSuperPoder1;
        }
    }
    public List<SuperPoder> ExtraindoPoderes(string ListaBrutaPoderes)
    {
        List<SuperPoder> superPoderes = new List<SuperPoder>();
        string[] partes = ListaBrutaPoderes.Split(":");

        string[] NomePoderes = partes[0].Split(",");
        foreach (string nomePoder in NomePoderes)
        {
            string nomeFormatado = FormatarNomePoder(nomePoder.Trim());
            superPoderes.Add(new SuperPoder(nomePoder));
        }

        return superPoderes;
    }
    static string FormatarNomePoder(string nome)
    {
        string[] palavras = nome.Split(' ');
        for (int i = 0; i < palavras.Length; i++)
        {
            if (!string.IsNullOrEmpty(palavras[i]))
            {
                palavras[i] = char.ToUpper(palavras[i][0]) + palavras[i].Substring(1).ToLower();
            }
        }
        return string.Join(" ", palavras);
    }


}
