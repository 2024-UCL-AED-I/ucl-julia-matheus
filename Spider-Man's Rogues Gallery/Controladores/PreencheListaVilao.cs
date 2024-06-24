using Spider_Man_s_Rogues_Gallery.Classes;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Spider_Man_s_Rogues_Gallery.Controladores;

public class PreencheListaVilao
{
    static String caminho_do_arquivojson = @"..\..\..\..\lista_vilao.json";
    static string jsonString = File.ReadAllText(caminho_do_arquivojson);
    public List<class_vilao> Viloes_em_json()
    {
        List<class_vilao> list_viloes = JsonSerializer.Deserialize<List<class_vilao>>(jsonString);

        string[] linhas = File.ReadAllLines(caminho_do_arquivojson);
        List<string> linhasFiltradas = linhas
        .Where(linha => linha.Trim().StartsWith("\"superpoder\""))
        .Select(linha => linha.Split(':')[1].Trim().Trim('"', ',', ' '))
        .ToList();

        return list_viloes!;
    }

    public List<class_vilao> list_vilao_favoritados(List<class_vilao> list_viloes)
    {
        List<class_vilao> list_vilao_favoritados = new List<class_vilao>();
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
            foreach(class_vilao vilao in list_viloes)
            {
                if(vilao.nome_do_vilao == nome)
                {
                    list_vilao_favoritados.Add(vilao);
                    break;
                }
            }
        }
        return list_vilao_favoritados;
    }

     //public List<SuperPoder> ListaPoderes()
    //{

    //    List<SuperPoder> ListaPoderes = new List<SuperPoder>();

    //    string[] linhas = File.ReadAllLines(caminho_do_arquivojson);
    //    List<string> linhasFiltradas = linhas
    //    .Where(linha => linha.Trim().StartsWith("\"superpoder\""))
    //    .Select(linha => linha.Split(':')[1].Trim().Trim('"', ',', ' ')) 
    //    .ToList();

        

    //    // Concatena todas as linhas filtradas em uma única string
    //    string superpoderesConcatenados = string.Join(", ", linhasFiltradas);

    //    // Divide a string concatenada em partes individuais
    //    string[] partes = superpoderesConcatenados.Split(new[] { ','}, StringSplitOptions.RemoveEmptyEntries);

    //        List<string> ListaDeSuperPoderes = new List<string>();
    //        HashSet<string> superPoderesSet = new HashSet<string>();

    //        // Formatar cada parte: Primeira letra maiúscula e o restante minúsculo
    //        for (int i = 0; i < partes.Length; i++)
    //        {
             
    //            string parteFormatada = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(partes[i].Trim().ToLower());

    //            // Adicionar à lista se não estiver presente no HashSet
    //            if (superPoderesSet.Add(parteFormatada))
    //            {
    //                ListaDeSuperPoderes.Add(parteFormatada);
    //            }
    //        }
    //    //Console.WriteLine("\nLista de Superpoderes:");
    //    foreach (string superPoder in ListaDeSuperPoderes)
    //    {
    //        //Console.WriteLine(superPoder);
    //         SuperPoder PoderNovo = new SuperPoder(superPoder);
    //        ListaPoderes.Add(PoderNovo);
    //    }
    //    return ListaPoderes;
    //}

}
