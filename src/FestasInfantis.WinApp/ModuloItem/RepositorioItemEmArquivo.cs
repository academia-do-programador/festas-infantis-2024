using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class RepositorioItemEmArquivo : RepositorioBaseEmArquivo<Item>, IRepositorioItem
    {
        public RepositorioItemEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Item> ObterRegistros()
        {
            return contexto.Itens;
        }
    }
}
