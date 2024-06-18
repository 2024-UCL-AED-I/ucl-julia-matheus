//Spider-Man's Rogues Gallery
using Spider_Man_s_Rogues_Gallery;
using Spider_Man_s_Rogues_Gallery.Apresentação;
using Spider_Man_s_Rogues_Gallery.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Xml;

class Program
{
    static void Main()
    {
        //listar fixas (IMPORTANTES PARA O PROGRAMA FUNCIONAR!!)
        List<class_vilao> list_vilao_favoritados = new List<class_vilao>();
        List<class_vilao> list_viloes = new List<class_vilao>();
        Operacao Inicio = new Operacao();
        String caminho_do_arquivojson = @"..\..\..\..\lista_vilao.json";

        string jsonString = File.ReadAllText(caminho_do_arquivojson);
        list_viloes = JsonSerializer.Deserialize<List<class_vilao>>(jsonString);


       void MenuPrincipal()
        {
            Inicio.TextoDoMenuPrincipal();
            int n;
            bool continuar = false;
            do
            {
                n = int.Parse(Console.ReadLine()!);
                switch (n)
                {
                    case 1:
                        PesquisaVilao VilaoPesquisado = new PesquisaVilao();
                        VilaoPesquisado.Executar(list_viloes, list_vilao_favoritados);
                        break;
                    case 2:
                        Exibir_lista_de_viloes_favoritos Exibindo = new Exibir_lista_de_viloes_favoritos();
                        Exibindo.Exibi_lista(list_vilao_favoritados);
                        break;
                    case 3:
                        Excluir_vilao_da_lista VilaoExcluido = new Excluir_vilao_da_lista();
                        VilaoExcluido.Executar(list_vilao_favoritados, list_viloes);
                        break;
                    case 0:
                        Inicio.Encerra_Programa();
                        return;
                    default:
                        Inicio.Texto_opcaoInvalida();
                        continuar = true;
                        break;
                    case -100:
                        Inicio.Exibe_Texto_EasterEgg();
                        return;
                }
            } while (continuar);
            MenuPrincipal();
        }
        Inicio.Apresenta_Slogan();
        MenuPrincipal();
    }
}