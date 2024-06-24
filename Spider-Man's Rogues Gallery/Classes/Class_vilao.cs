
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Spider_Man_s_Rogues_Gallery.Classes;

public class class_vilao
{

    [JsonPropertyName("nome_vilao")]
    public string? nome_do_vilao { get; set; }

    [JsonPropertyName("nome")]
    public string? nome { get; set; }

    [JsonPropertyName("idade")]
    public string? idade { get; set; }

    [JsonPropertyName("ocupacao")]
    public string? ocupacao { get; set; }

    [JsonPropertyName("extras")]
    public Extras? extras { get; set; }

    [JsonPropertyName("superpoderes")]
    public List<string> PoderesString { get; set; }

    public List<SuperPoder>? ListaPoderes {  get; set; }

    public class_vilao( List<string> PoderesString)
    {
        ListaPoderes = SuperPoder.CriarListaDeSuperPoderes(PoderesString);
    }


    public string ConteudoRelatorio
    {
        get
        {
            string conteudo = $"Nome do Vilão: {nome_do_vilao}.\n" +
                              $"Nome: {nome}.\n" +
                              $"Idade: {idade}.\n" +
                              $"Ocupação: {ocupacao}.\n";
            if (extras != null)
            {
                conteudo += $"Formação: {extras.formacao}.\n" +
                            $"Relações: {extras.relacoes}.\n" +
                            $"Curiosidades: {extras.curiosidades}.\n";
            }
            if (ListaPoderes != null)
            {
                conteudo += "Poderes:";
                int i = 1;
                foreach (SuperPoder poder in ListaPoderes)
                {
                    conteudo += $"{poder.Nome}";
                    if (i != ListaPoderes.Count)
                        conteudo += ",";
                    if (i == ListaPoderes.Count)
                        conteudo += ".";
                    i++;
                }

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
        if (extras != null)
        {
            Console.WriteLine($"Formação: {extras.formacao}");
            Console.WriteLine($"Relações: {extras.relacoes}");
            Console.WriteLine($"Curiosidades: {extras.curiosidades}");
        }
        if(ListaPoderes != null)
        {
            Console.Write("Poderes:");
            int i = 1;
            foreach (SuperPoder poder in ListaPoderes)
            { 
                Console.Write(poder.Nome);
                if (i != ListaPoderes.Count)
                { Console.Write(","); }
                if(i == ListaPoderes.Count)
                { Console.Write("."); }
                i++;
            }

        }
    }

    //internal List<string> superPoder { get; set; }
    //public List<SuperPoder> ListaDePoder { get; set; }

}
