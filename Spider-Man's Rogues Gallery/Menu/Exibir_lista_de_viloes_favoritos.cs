using Spider_Man_s_Rogues_Gallery.Classes;

namespace Spider_Man_s_Rogues_Gallery.Menu;

public class Exibir_lista_de_viloes_favoritos : Menu
{
    public void Executar(List<class_vilao> list_vilao_favoritados)
    {
        Exibir_titulo_funcao("Exibindo Lista de Vilões Favoritados!");
        Exibi_lista(list_vilao_favoritados);
        finaliza_funcao();
    }
}
