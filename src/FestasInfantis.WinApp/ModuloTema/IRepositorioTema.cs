using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public interface IRepositorioTema
    {
        void AdicionarItens(Tema novoTema, List<Item> itensMarcados);
        void AtualizarItens(Tema temaSelecionado, List<Item> itensMarcados, List<Item> itensDesmarcados);
        void Cadastrar(Tema novoTema);
        bool Editar(int id, Tema temaEditado);
        bool Excluir(int id);
        Tema SelecionarPorId(int id);
        List<Tema> SelecionarTodos();
    }
}
