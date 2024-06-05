using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Spider_Man_s_Rogues_Gallery.Modelos
{
    internal class vilao
    {
        [JsonPropertyName("nome_vilao")]
        public string? nome_vilao { get; set; }

        [JsonPropertyName("nome")]
        public string? nome { get; set; }

        [JsonPropertyName("idade")]
        public string? idade { get; set; }

        [JsonPropertyName("ocupacao")]
        public string? ocupacao { get; set; }

        [JsonPropertyName("extras")]
        public Extras? extras { get; set; }

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
            Console.WriteLine($"Nome do Vilão: {nome_vilao}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Ocupação: {ocupacao}");
            if (extras != null)
            {
                Console.WriteLine($"Formação: {extras.formacao}");
                Console.WriteLine($"Relações: {extras.relacoes}");
                Console.WriteLine($"Curiosidades: {extras.curiosidades}");
            }
        }
    }
}
