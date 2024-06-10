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
            var registrosRelacionados = ObterRegistros()
                .Where(i => i.Tema != null)
                .Where(i => i.Tema.Id == temaSelecionado.Id);

            return ObterRegistros()
                .Where(i => i.Tema == null)
                .Concat(registrosRelacionados)
                .ToList();
        }

        protected override List<Item> ObterRegistros()
        {
            return contexto.Itens;
        }
    }
}
