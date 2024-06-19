using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Spider_Man_s_Rogues_Gallery.Classes;

public class SuperPoder
{
    [JsonPropertyName("superpoder")]
    public string? Superpoder { get; set; }

    public SuperPoder(string? superpoder)
    {
        Superpoder = superpoder;
    }

    public void ExibirSuperPoder()
    {
        Console.WriteLine($"SUPERPODER: {Superpoder}");
    }

    public static List<SuperPoder> CriarSuperPoderes(string poderes)
    {
        List<SuperPoder> listaDePoderes = new List<SuperPoder>();

        // Separar a string por vírgula e "e"
        string[] poderArray = poderes.Split(new[] { ',', 'e' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string poder in poderArray)
        {
            // Remover espaços em branco extras
            string poderLimpo = poder.Trim();
            if (!string.IsNullOrEmpty(poderLimpo))
            {
                listaDePoderes.Add(new SuperPoder(poderLimpo));
            }
        }

        return listaDePoderes;
    }

    public static void ImprimirListaDePoderes(List<SuperPoder> listaDePoderes)
    {
        foreach (SuperPoder poder in listaDePoderes)
        {
            poder.ExibirSuperPoder();
        }
    }
}

