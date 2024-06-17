namespace FestasInfantis.WinApp.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Cadastrar(Aluguel novoAluguel);
        bool Editar(int id, Aluguel aluguelEditado);
        bool Excluir(int id);

        Aluguel SelecionarPorId(int id);
        List<Aluguel> SelecionarTodos();
        List<Aluguel> SelecionarAlugueisPendentes();
        List<Aluguel> SelecionarAlugueisConcluidos();

        void ConcluirAluguel(Aluguel aluguel);
    }
}
