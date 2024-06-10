using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class RepositorioItemEmArquivo : RepositorioBaseEmArquivo<Item>, IRepositorioItem
    {
        public RepositorioItemEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Item> SelecionarItensDisponiveis()
        {
            return ObterRegistros()
                .Where(i => i.Tema == null)
                .ToList();
        }

        protected override List<Item> ObterRegistros()
        {
            return contexto.Itens;
        }
    }
}
