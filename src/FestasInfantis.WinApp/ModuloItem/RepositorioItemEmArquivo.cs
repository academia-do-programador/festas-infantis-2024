using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;

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

        public List<Item> SelecionarItensDisponiveis(Tema temaSelecionado)
        {
            return ObterRegistros()
                .Where(i => i.Tema == null)
                .Concat(temaSelecionado.Itens)
                .ToList();
        }

        protected override List<Item> ObterRegistros()
        {
            return contexto.Itens;
        }
    }
}
