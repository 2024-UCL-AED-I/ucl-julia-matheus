using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using static Spider_Man_s_Rogues_Gallery.Classes.class_vilao;

namespace Spider_Man_s_Rogues_Gallery.Classes;

public class SuperPoder
{
    [JsonPropertyName("superpoder")]
    public string? SuperPoderOriginal { get; set; }

    [JsonIgnore]
    public List<string> SuperPoderes { get; private set; } = new List<string>();

    [OnDeserialized]
    private void OnDeserializedMethod(StreamingContext context)
    {
        if (!string.IsNullOrEmpty(SuperPoderOriginal))
        {
            // Dividir a string original pelos delimitadores (",")
            var poderes = SuperPoderOriginal.Split(',');

            // Adicionar cada poder à lista, removendo espaços desnecessários
            foreach (var poder in poderes)
            {
                SuperPoderes.Add(poder.Trim());
            }
        }
    }

    public void ExibirSuperPoder()
    {
        Console.WriteLine($"Super Poder: {SuperPoderOriginal}");
    }
}
