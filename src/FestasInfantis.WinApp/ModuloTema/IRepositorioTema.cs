using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public interface IRepositorioTema
    {
        void Cadastrar(Tema novoTema);
        bool Editar(int id, Tema temaEditado);
        bool Excluir(int id);
        Tema SelecionarPorId(int v);
        List<Tema> SelecionarTodos();

        void AdicionarItens(Tema temaSelecionado, List<Item> itens);
        void AtualizarItens(Tema temaSelecionado, List<Item> itensDesmarcados, List<Item> itensMarcados);
    }
}
