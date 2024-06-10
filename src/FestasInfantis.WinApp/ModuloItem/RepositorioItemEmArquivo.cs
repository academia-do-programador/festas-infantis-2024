using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;

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

        public List<Item> SelecionarItensDisponiveis()
        {
            return ObterRegistros()
                    .Where(e => e.Tema == null)
                    .ToList();
        }

        public List<Item> SelecionarItensDisponiveisParaTema(Tema tema)
        {
            var registrosRelacionados = ObterRegistros()
                .Where(i => i.Tema != null)
                .Where(i => i.Tema.Id == tema.Id);

            return ObterRegistros()
                    .Where(e => e.Tema == null)
                    .Concat(registrosRelacionados)
                    .ToList();
        }
    }
}
