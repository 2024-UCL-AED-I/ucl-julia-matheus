using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spider_Man_s_Rogues_Gallery.Classes
{
    public class Vilao
    {
        [JsonPropertyName("superpoder")]
        public string? ListaBrutaPoderes { get; set; }

        [JsonPropertyName("nome_vilao")]
        public string? NomeDoVilao { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("idade")]
        public string Idade { get; set; }

        [JsonPropertyName("ocupacao")]
        public string? Ocupacao { get; set; }

        [JsonPropertyName("extras")]
        public Extras? Extras { get; set; }

        private List<SuperPoder> _superPoderes;

        public List<SuperPoder> SuperPoderes
        {
            get
            {
                if (_superPoderes == null && ListaBrutaPoderes != null)
                {
                    _superPoderes = new List<SuperPoder>();
                    _superPoderes = SuperPoder.ExtrairPoderes(ListaBrutaPoderes);
                }
                return _superPoderes ?? new List<SuperPoder>();
            }
        }

        public string Relatorio
        {
            get
            {
                string conteudo = $"Nome do Vilão: {NomeDoVilao}\n" +
                                  $"Nome: {Nome}\n" +
                                  $"Idade: {Idade}\n" +
                                  $"Ocupação: {Ocupacao}\n" +
                                  $"SuperPoderes:\n";

                foreach (SuperPoder poder in SuperPoderes)
                {
                    conteudo += $"{poder.NomeSuperPoder}\n";
                }

                if (Extras != null)
                {
                    conteudo += $"Formação: {Extras.Formacao}\n" +
                                $"Relações: {Extras.Relacoes}\n" +
                                $"Curiosidades: {Extras.Curiosidades}\n";
                }

                return conteudo;
            }
        }

        public void ExibirDetalhesDoVilao()
        {
            Console.WriteLine($"Nome do Vilão: {NomeDoVilao}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Ocupação: {Ocupacao}");
            Console.WriteLine("SuperPoderes:");
            foreach (SuperPoder poder in SuperPoderes)
            {
                Console.WriteLine(poder.NomeSuperPoder);
            }
            if (Extras != null)
            {
                Console.WriteLine($"Formação: {Extras.Formacao}");
                Console.WriteLine($"Relações: {Extras.Relacoes}");
                Console.WriteLine($"Curiosidades: {Extras.Curiosidades}");
            }
        }
    }

    public class Extras
    {
        [JsonPropertyName("formacao")]
        public string? Formacao { get; set; }

        [JsonPropertyName("relacoes")]
        public string? Relacoes { get; set; }

        [JsonPropertyName("curiosidades")]
        public string? Curiosidades { get; set; }
    }

    
}
