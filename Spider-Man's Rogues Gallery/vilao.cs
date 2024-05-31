using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_Man_s_Rogues_Gallery
{
    public class vilao
    {
        public string NomeVilao { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Ocupacao { get; set; }
        public string Superpoder { get; set; }
        public string Equipamentos { get; set; }
        public string Fraquezas { get; set; }
        public string Formacao { get; set; }
        public string Relacoes { get; set; }
        public string Curiosidades { get; set; }

        public vilao(string nomeVilao, string nome, string idade, string ocupacao, Dictionary<string, string> informacoesDoVilao, Dictionary<string, string> extras)
        {
            NomeVilao = nomeVilao;
            Nome = nome;
            Idade = idade;
            Ocupacao = ocupacao;
            Superpoder = informacoesDoVilao.ContainsKey("superpoder") ? informacoesDoVilao["superpoder"] : null;
            Equipamentos = informacoesDoVilao.ContainsKey("equipamentos") ? informacoesDoVilao["equipamentos"] : null;
            Fraquezas = informacoesDoVilao.ContainsKey("fraquezas") ? informacoesDoVilao["fraquezas"] : null;
            Formacao = extras.ContainsKey("formacao") ? extras["formacao"] : null;
            Relacoes = extras.ContainsKey("relacoes") ? extras["relacoes"] : null;
            Curiosidades = extras.ContainsKey("curiosidades") ? extras["curiosidades"] : null;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do Vilão: {NomeVilao}");
            Console.WriteLine($"Nome Real: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Ocupação: {Ocupacao}");
            Console.WriteLine($"Superpoder: {Superpoder}");
            Console.WriteLine($"Equipamentos: {Equipamentos}");
            Console.WriteLine($"Fraquezas: {Fraquezas}");
            Console.WriteLine($"Formação: {Formacao}");
            Console.WriteLine($"Relações: {Relacoes}");
            Console.WriteLine($"Curiosidades: {Curiosidades}");
        }
    }

}
