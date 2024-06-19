using System.Globalization;
using System.Text.Json.Serialization;
using static Spider_Man_s_Rogues_Gallery.Classes.class_vilao;

namespace Spider_Man_s_Rogues_Gallery.Classes;

public class SuperPoder
{
    [JsonPropertyName("superpoder")]
    public string? SuperPoderOriginal { get; set; }

    public void ExibirSuperPoder()
    {
        Console.WriteLine($"Super Poder: {SuperPoderOriginal}");
    }
}
