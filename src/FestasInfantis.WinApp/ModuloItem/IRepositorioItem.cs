namespace FestasInfantis.WinApp.ModuloItem
{
    public interface IRepositorioItem
    {
        void Cadastrar(Item novoItem);
        bool Editar(int id, Item itemEditado);
        bool Excluir(int id);
        Item SelecionarPorId(int id);
        List<Item> SelecionarTodos();
        List<Item> SelecionarItensDisponiveis();
    }
}
