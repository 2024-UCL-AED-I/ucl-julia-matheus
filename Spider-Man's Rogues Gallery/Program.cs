//Spider-Man's Rogues Gallery
using Spider_Man_s_Rogues_Gallery.Apresentação;
using Spider_Man_s_Rogues_Gallery.Classes;
using Spider_Man_s_Rogues_Gallery.Controladores;
using Spider_Man_s_Rogues_Gallery.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        //Centralizando Operação
        PreencheListaVilao vilao = new PreencheListaVilao();
       
        //listar fixas (IMPORTANTES PARA O PROGRAMA FUNCIONAR!!)
        List<class_vilao> list_viloes = new List<class_vilao>();
        List<class_vilao> list_vilao_favoritados = new List<class_vilao>();

        
        //Escreve Primeira Lista.
        list_viloes = vilao.Viloes_em_json();

        //Escreve 2 Lista.
        list_vilao_favoritados = vilao.list_vilao_favoritados(list_viloes);


        TEXTOS Inicio = new TEXTOS();
        Inicio.Texto_Slogan();
        
        MenuPrincipal();

        void MenuPrincipal()
        {

            bool continuar = true;
            do
            {
                Inicio.TextoDoMenuPrincipal();
                int n = int.Parse(Console.ReadLine()!);
                Console.Clear();
                switch (n)
                {
                    case 1:
                        PesquisaVilao VilaoPesquisado = new PesquisaVilao();
                        VilaoPesquisado.Executar(list_viloes, list_vilao_favoritados);
                        break;
                    case 2:
                        Exibir_lista_de_viloes_favoritos Exibindo = new Exibir_lista_de_viloes_favoritos();
                        Exibindo.Exibi_lista(list_vilao_favoritados);
                        Exibindo.finaliza_funcao();
                        break;
                    case 3:
                        Excluir_vilao_da_lista VilaoExcluido = new Excluir_vilao_da_lista();
                        VilaoExcluido.Executar(list_vilao_favoritados, list_viloes);
                        break;
                    case 4:
                        Gera_Relatorio Novo_Relatorio = new Gera_Relatorio();
                        Novo_Relatorio.Executar(list_vilao_favoritados);
                        break;
                    case 5:
                        Gera_Relatorio Limpar_Lista_Relatório = new Gera_Relatorio();
                        Limpar_Lista_Relatório.LimparLista(list_vilao_favoritados);
                        break;
                    case 0:
                        Inicio.Texto_Encerra_Programa();
                        continuar = false;
                        return;
                    default:
                        Inicio.Texto_opcaoInvalida();
                        MenuPrincipal();
                        break;
                    case -100:
                        Inicio.Texto_slogan_EasterEgg();
                        Inicio.Texto_EasterEgg();
                        return;
                    case 6:
                        list_vilao_favoritados.AddRange(list_viloes);
                        MenuPrincipal();
                        break;
                }
            } while (continuar);
        }
    }
}