using Spider_Man_s_Rogues_Gallery.Classes;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Spider_Man_s_Rogues_Gallery.Controladores;

public class PreencheListaVilao
{
    public List<Vilao> Viloes_em_json()
    {
        String caminho_do_arquivojson = @"..\..\..\..\lista_vilao.json";
        string jsonString = File.ReadAllText(caminho_do_arquivojson);
        List<Vilao> list_viloes = JsonSerializer.Deserialize<List<Vilao>>(jsonString);
        return list_viloes!;
    }

    public List<Vilao> list_vilao_favoritados(List<Vilao> list_viloes)
    {
        List<Vilao> list_vilao_favoritados = new List<Vilao>();
        List<string> Nomes_dos_viloes_favoritados = new List<string>();

        string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string caminhoArquivo = Path.Combine(caminho, "Relatório Spider-Man's Rogues Gallery.txt");

        //Metodo sem usar o stremReader
        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string line in linhas)
            {
                if(line.StartsWith("Nome do Vilão:"))
                {
                    string[] parts = line.Split(":");
                    if(parts.Length == 2)
                    {
                        string nomeVilao = parts[1].Trim();
                        Nomes_dos_viloes_favoritados.Add(nomeVilao);
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Ocorreu um erro ao ler o arquivo:"+ex.Message);
        }
        foreach (string nome in Nomes_dos_viloes_favoritados)
        {
            foreach(Vilao vilao in list_viloes)
            {
                if(vilao.NomeDoVilao == nome)
                {
                    list_vilao_favoritados.Add(vilao);
                    break;
                }
            }
        }
        return list_vilao_favoritados;
    }

    public List<SuperPoder> lista()
    {
        List<SuperPoder> lista = new List<SuperPoder>();

        String caminho_do_arquivojson = @"..\..\..\..\lista_vilao.json";
        string jsonString = File.ReadAllText(caminho_do_arquivojson);
        lista = JsonSerializer.Deserialize<List<SuperPoder>>(jsonString);

        return lista;
    }

}
