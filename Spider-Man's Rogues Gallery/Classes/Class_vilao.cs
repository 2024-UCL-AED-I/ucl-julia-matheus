
using Spider_Man_s_Rogues_Gallery.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Spider_Man_s_Rogues_Gallery.Classes;

public class class_vilao
{
    [JsonPropertyName("superpoder")]
    public string? ListaBrutaPoderes { get; set; }

    [JsonPropertyName("nome_vilao")]
    public string? nome_do_vilao { get; set; }

    [JsonPropertyName("nome")]
    public string? nome { get; set; }

    [JsonPropertyName("idade")]
    public string idade { get; set; }

    [JsonPropertyName("ocupacao")]
    public string? ocupacao { get; set; }

    [JsonPropertyName("extras")]
    public Extras? extras { get; set; }

    private List<SuperPoder> _superPoders;

    public List<SuperPoder> SuperPoders
    {
        get
        {
            if (_superPoders == null) // Verifica se a lista ainda não foi inicializada
            {
                _superPoders = new List<SuperPoder>();
                SuperPoder preencer = new SuperPoder("preencer");
                _superPoders = preencer.ExtraindoPoderes(ListaBrutaPoderes);
            }
            return _superPoders; // Retorna a lista
        }
        set
        {
            _superPoders = value; // Define o valor da lista
        }
    }
    public string ConteudoRelatorio
    {
        get
        {
            string conteudo = $"Nome do Vilão: {nome_do_vilao}\n" +
                              $"Nome: {nome}\n" +
                              $"Idade: {idade}\n" +
                              $"Ocupação: {ocupacao}\n"+
                              $"SuperPoderes:{ListaBrutaPoderes}";

            if (extras != null)
            {
                conteudo += $"Formação: {extras.formacao}\n" +
                            $"Relações: {extras.relacoes}\n" +
                            $"Curiosidades: {extras.curiosidades}\n";
            }
            return conteudo;
        }          
    }
    public class Extras
    {
        [JsonPropertyName("formacao")]
        public string? formacao { get; set; }

        [JsonPropertyName("relacoes")]
        public string? relacoes { get; set; }

        [JsonPropertyName("curiosidades")]
        public string? curiosidades { get; set; }
    }

    public void Exibir_detalhes_do_vilao()
    {
        Console.WriteLine($"Nome do Vilão: {nome_do_vilao}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Ocupação: {ocupacao}");
        foreach(SuperPoder poder in SuperPoders)
        {
            Console.WriteLine(poder.NomeSuperPoder); 
        }
        if (extras != null)
        {
            Console.WriteLine($"Formação: {extras.formacao}");
            Console.WriteLine($"Relações: {extras.relacoes}");
            Console.WriteLine($"Curiosidades: {extras.curiosidades}");
        }
    }
    



}







